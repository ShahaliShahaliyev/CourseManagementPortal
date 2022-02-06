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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            FormCourse formCourse = new FormCourse();
            formCourse.ShowDialog();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent();
            formStudent.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTeacher formTeacher = new FormTeacher();
            formTeacher.ShowDialog();
        }

        public List<OngoingCourses> WiewOngoingCourses()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from OngoingCourses", sqlConnection);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<OngoingCourses> list = new List<OngoingCourses>();
            while (sqlDataReader.Read())
            {
                OngoingCourses ongoingCourses = new OngoingCourses();
                ongoingCourses.StudentId = sqlDataReader.GetInt32("StudentId");
                ongoingCourses.CourseId = sqlDataReader.GetInt32("CourseId");
                ongoingCourses.TeacherId = sqlDataReader.GetInt32("TeacherId");
                ongoingCourses.StartDate = sqlDataReader.GetDateTime("StartDate");
                ongoingCourses.EndDate = sqlDataReader.GetDateTime("EndDate");

                list.Add(ongoingCourses);
            }

            sqlConnection.Close();

            sqlDataReader.Close();

            return list;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dgw_OC.DataSource = WiewOngoingCourses();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormComments formComments = new FormComments();
            formComments.ShowDialog();
        }
    }
}
