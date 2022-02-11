using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseManagement_Portal
{
    public partial class CommentForm : Form
    {
        public CommentForm()
        {
            InitializeComponent();
        }
        string Attendance;

        private void rb_Iedb_CheckedChanged(object sender, EventArgs e)
        {
            Attendance = "İştirak edib";
        }

        private void rb_Ietmb_CheckedChanged(object sender, EventArgs e)
        {
            Attendance = "İştirak etməyib";
        }

        private void CommentForm_Load(object sender, EventArgs e)
        {
            dgw_Comments.DataSource = ReadAllComments();

            cb_ACS.Items.Clear();
            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");
            connection.Open();
            SqlCommand cmd = new SqlCommand("select StudentName from StartedCourses", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_ACS.Items.Add(reader["StudentName"]).ToString();
            }
            connection.Close();
         
            SqlConnection connection2 = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");
            connection2.Open();
            SqlCommand cmd2 = new SqlCommand ("select CourseName from StartedCourses", connection2);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                cb_ACC.Items.Add(reader2["CourseName"].ToString());
            }
            connection2.Close();
        }

        public void AddComment(CommentStudentClass commentClass)
        {
            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");
            connection.Open();

            SqlCommand command = new SqlCommand("insert into CommentForStudent values(@student,@course,@lesson,@date,@attendance,@comment)", connection);
            command.Parameters.AddWithValue("Student", commentClass.Student);
            command.Parameters.AddWithValue("Course", commentClass.Course);
            command.Parameters.AddWithValue("Lesson", commentClass.Lesson);
            command.Parameters.AddWithValue("Date", commentClass.Date);
            command.Parameters.AddWithValue("Attendance",commentClass.Attendance);
            command.Parameters.AddWithValue("Comment", commentClass.Comment);

            command.ExecuteNonQuery();
            connection.Close();
        }
           
        private void btn_AddComment_Click(object sender, EventArgs e)
        {
            CommentStudentClass commentClass = new CommentStudentClass();
           
            commentClass.Student = cb_ACS.Text.ToString();
            commentClass.Course =cb_ACC.Text.ToString();
            commentClass.Date = Convert.ToDateTime(dtp_ACD.Value);
            commentClass.Lesson = tbx_LessonComment.Text.ToString();
            commentClass.Attendance = Attendance.ToString();
            commentClass.Comment = rtb_ACComment.Text.ToString();

            AddComment(commentClass);

            MessageBox.Show("Comment Added!");

            dgw_Comments.DataSource = ReadAllComments();
        }

        public List<CommentStudentClass> ReadAllComments()
        {
            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from CommentForStudent", connection);

            SqlDataReader reader = command.ExecuteReader();
            List<CommentStudentClass> list = new List<CommentStudentClass>();
            while (reader.Read())
            {
                CommentStudentClass commentClass = new CommentStudentClass();

                commentClass.Student = reader.GetString("Student");
                commentClass.Course = reader.GetString("Course");
                commentClass.Lesson = reader.GetString("Lesson");
                commentClass.Date = reader.GetDateTime("Date");
                commentClass.Attendance = reader.GetString("Attendance");
                commentClass.Comment = reader.GetString("Comment");

                list.Add(commentClass);
            }
            connection.Close();

            reader.Close();

            return list;
        }
    }
}
