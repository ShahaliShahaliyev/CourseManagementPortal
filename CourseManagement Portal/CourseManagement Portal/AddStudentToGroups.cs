using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagement_Portal
{
    public partial class AddStudentToGroups : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

        public AddStudentToGroups()
        {
            InitializeComponent();
        }

        private void AddStudentToGroups_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            cb_ASCourseName.Items.Clear();

            SqlCommand command = new SqlCommand("select Name from Course");
            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cb_ASCourseName.Items.Add(reader["Name"].ToString());
            }
            sqlConnection.Close();
            //**
            sqlConnection.Open();

            cb_ASStudentName.Items.Clear();

            SqlCommand command2 = new SqlCommand("select Name from Student");
            command2.Connection = sqlConnection;
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cb_ASStudentName.Items.Add(reader2["Name"].ToString());
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

        public void GetGroupName(string name, ComboBox comboBox)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand($"select ng.GroupName,c.Name from NewGroup ng " +
            $"join Course c on ng.CourseId = c.Id where c.Name = '{name}'", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader.GetString(0));
            }

            reader.Close();

            sqlConnection.Close();
        }

        public void AddStudentToGroup(AddStudentToGroupClass addStudentToGroup)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("insert into AddStudentToGroup values(@courseId,@GroupId,@studentId)", sqlConnection);

            command.Parameters.AddWithValue("CourseID", addStudentToGroup.CourseId);
            command.Parameters.AddWithValue("GroupId", addStudentToGroup.GroupId);
            command.Parameters.AddWithValue("StudentId", addStudentToGroup.StudentId);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btn_SaveStudentInGroup_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            AddStudentToGroupClass student = new AddStudentToGroupClass();

            student.CourseId = GetCourseId(cb_ASCourseName.Text);
            student.GroupId = GetGroupId(cb_ASGroupName.Text);
            student.StudentId = GetStudentId(cb_ASStudentName.Text);

            AddStudentToGroup(student);

            sqlConnection.Close();

            Close();
        }

        private void cb_ASGroupName_Click(object sender, EventArgs e)
        {
            cb_ASGroupName.Items.Clear();

            string name = cb_ASCourseName.Text;

            GetGroupName(name, cb_ASGroupName);
        }
    }
}
