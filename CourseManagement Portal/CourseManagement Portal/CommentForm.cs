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
        SqlConnection sqlConnection = new SqlConnection(@"Server=localhost; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

        public CommentForm()
        {
            InitializeComponent();
        }

        private void CommentForm_Load(object sender, EventArgs e)
        {

            dgw_Comments.DataSource = ReadAllComments();

            sqlConnection.Open();
            cb_ACC.Items.Clear();

            SqlCommand command = new SqlCommand("select Name from Course");

            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cb_ACC.Items.Add(reader["Name"].ToString());
            }
            sqlConnection.Close();
        }
        public int GetCourseId(string name)
        {
            int id = 0;

            SqlCommand command = new SqlCommand($"select Id from Course where Name = '{name}'", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            reader.Close();

            sqlConnection.Close();

            return id;
        }

        public int GetGroupId(string name)
        {
            int id = 0;

            sqlConnection.Open();

            SqlCommand command = new SqlCommand($"select GroupId from NewGroup where GroupName = '{name}'", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();

            sqlConnection.Close();

            return id;
        }

        public int GetStudentId(string name)
        {
            int id = 0;

            sqlConnection.Open();

            SqlCommand command = new SqlCommand($"select Id from Student where Name = '{name}'", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();

            sqlConnection.Close();

            return id;
        }

        public void AddComment(CommentClass commentClass)
        {
            sqlConnection.Open();

            SqlCommand command =
                new SqlCommand(
                    "insert into Comment values(@courseId,@groupId,@studentId,@lesson,@date,@attendance,@comment)",
                    sqlConnection);

            command.Parameters.AddWithValue("CourseId", commentClass.CourseId);
            command.Parameters.AddWithValue("GroupId", commentClass.GroupId);
            command.Parameters.AddWithValue("StudentId", commentClass.StudentId);
            command.Parameters.AddWithValue("Lesson", commentClass.Lesson);
            command.Parameters.AddWithValue("Date", commentClass.Date);
            command.Parameters.AddWithValue("Attendance", commentClass.Attendance);
            command.Parameters.AddWithValue("Comment", commentClass.Comment);

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn_AddComment_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            CommentClass commentClass = new CommentClass();
            commentClass.CourseId = GetCourseId(cb_ACC.Text);
            commentClass.GroupId = GetGroupId(cb_CommentGroup.Text);
            commentClass.StudentId = GetStudentId(cb_ACS.Text);
            commentClass.Lesson = tbx_LessonComment.Text;
            commentClass.Date = dtp_ACD.Value;
            commentClass.Attendance = Attendance;
            commentClass.Comment = rtb_ACComment.Text;

            AddComment(commentClass);

            sqlConnection.Close();

            dgw_Comments.DataSource = ReadAllComments();
        }

         string Attendance;

        private void rb_Iedb_CheckedChanged(object sender, EventArgs e)
        {
            Attendance = "In Lesson";
        }

        private void rb_Ietmb_CheckedChanged(object sender, EventArgs e)
        {
            Attendance = "Not In Lesson";
        }

        public List<CommentClassDgw> ReadAllComments()
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("select c.Name as CourseName,ng.GroupName,s.Name as StudentName,s.Surname as StudentSurname,Lesson,cm.Date,cm.Attendance,cm.Comment from Comment cm "+
            "join Course c on cm.CourseId = c.Id " +
            "join NewGroup ng on cm.GroupId = ng.GroupId "+
            "join Student s on cm.StudentId = s.Id",sqlConnection);

            List<CommentClassDgw> list = new List<CommentClassDgw>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CommentClassDgw commentClassDgw = new CommentClassDgw();

                commentClassDgw.CourseName = reader.GetString(0);
                commentClassDgw.GroupName = reader.GetString(1);
                commentClassDgw.StudentName = reader.GetString(2);
                commentClassDgw.StudentSurname = reader.GetString(3);
                commentClassDgw.Lesson = reader.GetString(4);
                commentClassDgw.Date = reader.GetDateTime(5);
                commentClassDgw.Attendance = reader.GetString(6);
                commentClassDgw.Comment = reader.GetString(7);

                list.Add(commentClassDgw);
            }

            reader.Close();

            sqlConnection.Close();
            return list;
        }

        private void cb_CommentGroup_Click(object sender, EventArgs e)
        {
            cb_CommentGroup.Items.Clear();

            string name = cb_ACC.Text;

            AddStudentToGroups addStudent = new AddStudentToGroups();
            addStudent.GetGroupName(name,cb_CommentGroup);
        }


        public void GetStudentName(string name,ComboBox comboBox)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand($"select s.Name,ng.GroupName from AddStudentToGroup ag " +
            $"join Student s on ag.StudentId = s.Id " +
            $"join NewGroup ng on ag.GroupId = ng.GroupId where ng.GroupName = '{name}'", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader.GetString(0));
            }

            reader.Close();

            sqlConnection.Close();
        }
        private void cb_ACS_Click(object sender, EventArgs e)
        {
            cb_ACS.Items.Clear();

            string name = cb_CommentGroup.Text;

            GetStudentName(name,cb_ACS);
        }
    }
}
