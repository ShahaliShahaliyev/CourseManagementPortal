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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        public void CreateTeacher(TeacherClass teacherClass)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into Teacher values(@name,@surname,@birthDate,@profession)",sqlConnection);
            cmd.Parameters.AddWithValue("Name", teacherClass.Name);
            cmd.Parameters.AddWithValue("Surname",teacherClass.Surname);
            cmd.Parameters.AddWithValue("BirthDate",teacherClass.BirthDate);
            cmd.Parameters.AddWithValue("Profession", teacherClass.Profession);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btn_crtTeacher_Click(object sender, EventArgs e)
        {
           TeacherClass teacherClass = new TeacherClass();
            teacherClass.Name =tbx_crtTeacherName.Text;
            teacherClass.Surname = tbx_crtTeacherSur.Text;
            teacherClass.BirthDate =Convert.ToDateTime(dtp_crtTeacherBD.Value);
            teacherClass.Profession = tbx_crtTeacherProf.Text;

            CreateTeacher(teacherClass);

            MessageBox.Show("Teacher added!");
        }

        public List<TeacherClass> ReadAllTeacher()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from Teacher",sqlConnection);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<TeacherClass> list = new List<TeacherClass>();
            while (sqlDataReader.Read())
            {
                TeacherClass teacherClass = new TeacherClass();

                teacherClass.Id = Convert.ToInt32(sqlDataReader["ID"]);
                teacherClass.Name=sqlDataReader.GetString("Name");
                teacherClass.Surname = sqlDataReader.GetString("Surname");
                teacherClass.BirthDate = sqlDataReader.GetDateTime("BirthDate");
                teacherClass.Profession = sqlDataReader.GetString("Profession");

                list.Add(teacherClass);
            }

            sqlDataReader.Close();

            sqlConnection.Close();

            return list;
        }

        private void btn_rdTeacher_Click(object sender, EventArgs e)
        {
            dgw_Teacher.DataSource = ReadAllTeacher();
        }

        private void dgw_Teacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_updtTeacherName.Text = dgw_Teacher.CurrentRow.Cells[1].Value.ToString();
            tbx_updtTeacherSur.Text = dgw_Teacher.CurrentRow.Cells[2].Value.ToString();
            dtp_updtTeacherBD.Value =Convert.ToDateTime(dgw_Teacher.CurrentRow.Cells[3].Value);
            tbx_updtTeacherProf.Text = dgw_Teacher.CurrentRow.Cells[4].Value.ToString();
        }

        public void TeacherUpdate(TeacherClass teacherClass,int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update Teacher set Name=@name,Surname=@surname,BirthDate=@birthDate,Profession=@profession where Id=@id",sqlConnection);
           cmd.Parameters.AddWithValue("Id", id);
            cmd.Parameters.AddWithValue("Name", teacherClass.Name);
            cmd.Parameters.AddWithValue("Surname",teacherClass.Surname);
            cmd.Parameters.AddWithValue("BirthDate",teacherClass.BirthDate);
            cmd.Parameters.AddWithValue("Profession", teacherClass.Profession);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Teacher updated!");
        }

        private void btn_updtTeacher_Click(object sender, EventArgs e)
        {
            TeacherClass teacherClass = new TeacherClass();

            teacherClass.Name = tbx_updtTeacherName.Text;
            teacherClass.Surname = tbx_updtTeacherSur.Text;
            teacherClass.BirthDate=Convert.ToDateTime(dtp_updtTeacherBD.Value);
            teacherClass.Profession= tbx_updtTeacherProf.Text;

            TeacherUpdate(teacherClass,(int)dgw_Teacher.CurrentRow.Cells[0].Value);
        }

        public void DeleteTeacher(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("delete Teacher where Id=@id",sqlConnection);
            cmd.Parameters.AddWithValue("Id", id);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btn_dltTeacher_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("Are you sure?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(dialogResult == DialogResult.OK)
            {
                TeacherClass teacherClass = new TeacherClass();
                int id = (int)dgw_Teacher.CurrentRow.Cells[0].Value;

                DeleteTeacher(id);

                MessageBox.Show("Student delete!");
            }
            else
            {

            }
        }
    }
}
