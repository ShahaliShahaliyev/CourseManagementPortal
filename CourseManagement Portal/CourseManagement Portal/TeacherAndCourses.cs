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
    public partial class TeacherAndCourses : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=localhost; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

        public TeacherAndCourses()
        {
            InitializeComponent();
        }

        public void SaveTeacherAndCourses(TeacherAndCoursesClass teacherAndCoursesClass)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("insert into TeacherAndCourses values(@teacherId,@courseId)",sqlConnection);

            command.Parameters.AddWithValue("TeacherId", teacherAndCoursesClass.TeacherId);
            command.Parameters.AddWithValue("CourseId", teacherAndCoursesClass.CourseId);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public List<TeacherAndCoursesClassDGW> ReadAllTeacherAndCourses()
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("select t.Name as TeacherName,t.Surname as TeacherSurname,c.Name as CourseName from TeacherAndCourses tac " +
            "join Teacher t on tac.TeacherId = t.Id " +
            "join Course c on tac.CourseId = c.Id", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            List<TeacherAndCoursesClassDGW> list = new List<TeacherAndCoursesClassDGW>();

            while (reader.Read())
            {
                TeacherAndCoursesClassDGW teacherAndCoursesClass = new TeacherAndCoursesClassDGW();
                
                teacherAndCoursesClass.TeacherName = reader.GetString(0);
                teacherAndCoursesClass.TeacherSurname =reader.GetString(1);
                teacherAndCoursesClass.CourseName = reader.GetString(2);

                list.Add(teacherAndCoursesClass);
            }
            reader.Close();

            sqlConnection.Close();

            return list;
        }

        public void TeacherAndCourses_Load(object sender, EventArgs e)
        {
            dgw_TeacherAndCourses.DataSource = ReadAllTeacherAndCourses();

            cb_TACTN.Items.Clear();
            SqlDataReader reader;
            sqlConnection.Open();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "select Name from Teacher";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb_TACTN.Items.Add(reader["Name"].ToString());
            }
            sqlConnection.Close();

            cb_TACCN.Items.Clear();
            SqlDataReader reader1;
            sqlConnection.Open();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "select Name from Course";
            reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                cb_TACCN.Items.Add(reader1["Name"].ToString());
            }
            sqlConnection.Close();
        }
        SqlCommand cmd = new SqlCommand();

        private int GetTeacherId(string name)
        {
            var id = 0;

            sqlConnection.Open();

            SqlCommand command = new SqlCommand($"select Id from Teacher where Name ='{name}'");

            command.Connection = sqlConnection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();

            sqlConnection.Close();
            return id;
        }

        private int GetCourseId(string name)
        {
            var id = 0;

            sqlConnection.Open();

            SqlCommand command = new SqlCommand($"select Id from Course where Name ='{name}'");

            command.Connection = sqlConnection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();

            sqlConnection.Close();
            return id;
        }

        private void btn_TACSave_Click(object sender, EventArgs e)
        {
            TeacherAndCoursesClass teacherAndCoursesClass = new TeacherAndCoursesClass();

            teacherAndCoursesClass.TeacherId = GetTeacherId(cb_TACTN.Text);
            teacherAndCoursesClass.CourseId = GetCourseId(cb_TACCN.Text);

            SaveTeacherAndCourses(teacherAndCoursesClass);

            dgw_TeacherAndCourses.DataSource = ReadAllTeacherAndCourses();
        }
    }
}
