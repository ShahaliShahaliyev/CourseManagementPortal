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
    public partial class NewGroup : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

        public NewGroup()
        {
            InitializeComponent();
        }

        public void CreateNewGroup(NewGroupClass newGroup)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("insert into NewGroup values(@groupName,@courseId,@plannedStartDate,@plannedEndDate)", sqlConnection);

            command.Parameters.AddWithValue("GroupName", newGroup.GroupName);
            command.Parameters.AddWithValue("CourseId", newGroup.CourseId);
            command.Parameters.AddWithValue("PlannedStartDate", newGroup.PlannedStartDate);
            command.Parameters.AddWithValue("PlannedEndDate", newGroup.PlannedEndDate);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void NewGroup_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            cb_NewGroupCourse.Items.Clear();

            SqlCommand command = new SqlCommand("select Name from Course");
            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cb_NewGroupCourse.Items.Add(reader["Name"].ToString());
            }
            sqlConnection.Close();
        }

        private int GetCourseId(string name)
        {
            int id = 0;

            sqlConnection.Open();

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

        private void btn_CreateGroup_Click(object sender, EventArgs e)
        {
            NewGroupClass newGroup = new NewGroupClass();

            newGroup.GroupName = tbx_NewGroupGN.Text;
            newGroup.CourseId = GetCourseId(cb_NewGroupCourse.Text);
            newGroup.PlannedStartDate = dtp_PSNG.Value;
            newGroup.PlannedEndDate = dtp_PENG.Value;

            CreateNewGroup(newGroup);

            Close();
        }
    }
}
