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
    public partial class ThePlanOfCourse : Form
    {
        public ThePlanOfCourse()
        {
            InitializeComponent();
        }

        const string sqlConnection = @"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;";

        public static void StartCourse(StartedCourses startedCourses)
        {
            SqlConnection connection = new SqlConnection(sqlConnection);
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("insert into StartedCourses values(@studentName,@courseName,@startDate,@endDate,@duration)", connection);

            sqlCommand.Parameters.AddWithValue("StudentName", startedCourses.StudentName);
            sqlCommand.Parameters.AddWithValue("CourseName", startedCourses.CourseName);
            sqlCommand.Parameters.AddWithValue("StartDate", startedCourses.StartDate);
            sqlCommand.Parameters.AddWithValue("EndDate", startedCourses.EndDate);
            sqlCommand.Parameters.AddWithValue("Duration", startedCourses.Duration);

            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void btn_SC_Click(object sender, EventArgs e)
        {
            StartedCourses startedCourses = new StartedCourses();
            startedCourses.StudentName = cb_SCS.Text.ToString();
            startedCourses.CourseName = cb_SCC.Text.ToString();
            startedCourses.StartDate = DateTime.Today;
            startedCourses.EndDate = DateTime.Today.AddMonths((int)nud_SCD.Value);
            startedCourses.Duration = (int)nud_SCD.Value;

            StartCourse(startedCourses);
            MessageBox.Show("Course Started!");

            dgw_OngoingCourse.DataSource = AllStartedCourses();
        }

        private void ThePlanOfCourse_Load(object sender, EventArgs e)
        {
            dgw_OngoingCourse.DataSource = AllStartedCourses();

            cb_SCS.Items.Clear();
            SqlDataReader sqlDataReader;
            sqlConnection1.Open();
            SqlCommand.Connection = sqlConnection1;
            SqlCommand.CommandText = "select Name from Student";
            sqlDataReader = SqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cb_SCS.Items.Add(sqlDataReader["Name"].ToString());
            }
            sqlConnection1.Close();

            cb_SCC.Items.Clear();
            SqlDataReader sqlDataReader1;
            sqlConnection1.Open();
            SqlCommand.Connection = sqlConnection1;
            SqlCommand.CommandText = "select Name from Course";
            sqlDataReader1 = SqlCommand.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                cb_SCC.Items.Add(sqlDataReader1["Name"].ToString());
            }
            sqlConnection1.Close();
        }
        SqlConnection sqlConnection1 = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");
        SqlCommand SqlCommand = new SqlCommand();

        public List<StartedCourses> AllStartedCourses()
        {
            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("select * from StartedCourses", connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<StartedCourses> list = new List<StartedCourses>();
            while (reader.Read())
            {
                StartedCourses startedCourses = new StartedCourses();

                startedCourses.StudentName = reader["StudentName"].ToString();
                startedCourses.CourseName = reader["CourseName"].ToString();
                startedCourses.StartDate = Convert.ToDateTime(reader["StartDate"]);
                startedCourses.EndDate = Convert.ToDateTime(reader["EndDate"]);
                startedCourses.Duration = (int)reader["Duration"];

                list.Add(startedCourses);
            }
            reader.Close();
            connection.Close();

            return list;
        }
    }
}
