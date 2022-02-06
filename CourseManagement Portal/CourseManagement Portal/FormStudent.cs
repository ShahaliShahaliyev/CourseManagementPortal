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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }


        public void CreateStudent(StudentClass studentClass)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into Student values(@name,@surname,@birthdate,@creationTime,@modificationTime)",sqlConnection);

            cmd.Parameters.AddWithValue("Name", studentClass.Name);
            cmd.Parameters.AddWithValue("Surname", studentClass.Surname);
            cmd.Parameters.AddWithValue("BirthDate",studentClass.BirthDate);
            cmd.Parameters.AddWithValue("CreationTime",studentClass.CreationTime); 
            cmd.Parameters.AddWithValue("ModificationTime",studentClass.ModificationTime);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btn_crtStudent_Click(object sender, EventArgs e)
        {
            StudentClass studentClass = new StudentClass();

            studentClass.Name = tbx_crtStudentName.Text;
            studentClass.Surname = tbx_crtStudentSur.Text;
            studentClass.BirthDate = Convert.ToDateTime(dtp_crtStudentBD.Value);
            studentClass.CreationTime = Convert.ToDateTime(dtp_crtStudentCT.Value);
            studentClass.ModificationTime= Convert.ToDateTime(dtp_crtStudentMT.Value);

            CreateStudent(studentClass);

            MessageBox.Show("Student added!");
        }

        public List<StudentClass> ReadAllStudents()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("Select * from Student", sqlConnection);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<StudentClass> list = new List<StudentClass>();
            while (sqlDataReader.Read())
            {
                StudentClass studentClass = new StudentClass();

                studentClass.Id = Convert.ToInt32(sqlDataReader["ID"]);
                studentClass.Name = sqlDataReader.GetString("Name");
                studentClass.Surname = sqlDataReader.GetString("Surname");
                studentClass.BirthDate = sqlDataReader.GetDateTime("BirthDate");
                studentClass.CreationTime = sqlDataReader.GetDateTime("CreationTime");
                studentClass.ModificationTime = sqlDataReader.GetDateTime("ModificationTime");

                list.Add(studentClass);
            }
            sqlDataReader.Close();

            sqlConnection.Close();

            return list;

        }

        private void btn_rdStudent_Click(object sender, EventArgs e)
        {
            dgw_Student.DataSource = ReadAllStudents();
        }




        private void dgw_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_updtStudentName.Text = dgw_Student.CurrentRow.Cells[1].Value.ToString();
            tbx_updtStudentSur.Text = dgw_Student.CurrentRow.Cells[2].Value.ToString();
            dtp_updtStudentBD.Value = (DateTime)dgw_Student.CurrentRow.Cells[3].Value;
            dtp_updtStudentCT.Value = (DateTime)dgw_Student.CurrentRow.Cells[4].Value;
            dtp_updtStudentMT.Value = (DateTime)dgw_Student.CurrentRow.Cells[5].Value;
        }


        public void UpdateStudent(StudentClass studentClass,int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update Student set Name=@name,Surname=@surname,BirthDate=@birthdate,CreationTime=@creationTime,ModificationTime=@modificationTime where Id=@id", sqlConnection);

            cmd.Parameters.AddWithValue("Id",id);
            cmd.Parameters.AddWithValue("Name", studentClass.Name);
            cmd.Parameters.AddWithValue("Surname", studentClass.Surname);
            cmd.Parameters.AddWithValue("BirthDate", studentClass.BirthDate);
            cmd.Parameters.AddWithValue("CreationTime", studentClass.CreationTime);
            cmd.Parameters.AddWithValue("ModificationTime", studentClass.ModificationTime);

            cmd.ExecuteNonQuery();

            sqlConnection.Close ();

            MessageBox.Show("Student updated!");

        }

        private void btn_updtStudent_Click(object sender, EventArgs e)
        {
            StudentClass studentClass = new StudentClass();
            studentClass.Name = tbx_updtStudentName.Text;
            studentClass.Surname = tbx_updtStudentSur.Text;
            studentClass.BirthDate = Convert.ToDateTime(dtp_updtStudentBD.Value);
            studentClass.CreationTime = Convert.ToDateTime(dtp_updtStudentCT.Value);
            studentClass.ModificationTime = Convert.ToDateTime(dtp_updtStudentMT.Value);

            UpdateStudent(studentClass, (int)dgw_Student.CurrentRow.Cells[0].Value);
        }

        public void StudentDelete(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("delete from Student where @id=Id",sqlConnection);

            cmd.Parameters.AddWithValue("Id",id);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();

        }


        private void btn_dltStudent_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                StudentClass studentClass = new StudentClass();

                int id = (int)dgw_Student.CurrentRow.Cells[0].Value;

                StudentDelete(id);

                MessageBox.Show("Student deleted!");
            }
            else
            {

            }
        }
    }
}
