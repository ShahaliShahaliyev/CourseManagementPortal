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
    public partial class Groups : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server =localhost\SQLEXPRESS; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

        public Groups()
        {
            InitializeComponent();
        }

        private void btn_CNG_Click(object sender, EventArgs e)
        {
            NewGroup newGroup = new NewGroup();
            newGroup.ShowDialog();
        }

        private void btn_ASG_Click(object sender, EventArgs e)
        {
            AddStudentToGroups addStudentToGroups = new AddStudentToGroups();
            addStudentToGroups.ShowDialog();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            dgw_GroupsNameInfo.DataSource = ReadAllGroups();
            dgw_StudentAndGroups.DataSource = ReadStudentInGroup();
        }
        public List<NewGroupDGW> ReadAllGroups()
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("select ng.GroupId,ng.GroupName,c.Name as CourseName,ng.PlannedStartDate,ng.PlannedEndDate from NewGroup ng " +
                                                "join Course c on ng.CourseId = c.Id",sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            List<NewGroupDGW> list = new List<NewGroupDGW>();

            while (reader.Read())
            {
                NewGroupDGW newGroup = new NewGroupDGW();

                newGroup.GroupId = reader.GetInt32(0);
                newGroup.GroupName = reader["GroupName"].ToString();
                newGroup.CourseName = reader["CourseName"].ToString();
                newGroup.PalnnedStartDate = reader.GetDateTime(3);
                newGroup.PlannedEndDate = reader.GetDateTime(4);

                list.Add(newGroup);
            }

            reader.Close();

            sqlConnection.Close();
            return list;
        }

        public List<AddStudentToGroupClassDGW> ReadStudentInGroup()
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand(
                "select c.Name as CourseName,ng.GroupName,s.Name as StudentName,s.Surname as StudentSurname from AddStudentToGroup sg " +
                "join Course c on sg.CourseId = c.Id " +
                "join NewGroup ng on sg.GroupId = ng.GroupId " +
                "join Student s on sg.StudentId = s.Id", sqlConnection);

            SqlDataReader dr = command.ExecuteReader();
            List<AddStudentToGroupClassDGW> list = new List<AddStudentToGroupClassDGW>();

            while (dr.Read())
            {
                AddStudentToGroupClassDGW newStudent = new AddStudentToGroupClassDGW();

                newStudent.CourseName = dr.GetString(0);
                newStudent.GroupName = dr.GetString(1);
                newStudent.StudentName = dr.GetString(2);
                newStudent.StudentSurname = dr.GetString(3);

                list.Add(newStudent);
            }
            dr.Close();

            sqlConnection.Close();

            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgw_GroupsNameInfo.DataSource = ReadAllGroups();
            dgw_StudentAndGroups.DataSource = ReadStudentInGroup();
        }
    }
}
