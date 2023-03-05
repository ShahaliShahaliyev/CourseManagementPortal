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
        SqlConnection sqlConnection = new SqlConnection(@"Server =localhost\SQLEXPRESS; Database=LoginPage; Trusted_Connection=true;TrustServerCertificate=true;");

        public FormStudent()
        {
            InitializeComponent();
        }

        public void CreateStudent(StudentClass studentClass)
        {
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into Student values(@name,@surname,@birthdate,@creationTime,@modificationTime)", sqlConnection);

            cmd.Parameters.AddWithValue("Name", studentClass.Name);
            cmd.Parameters.AddWithValue("Surname", studentClass.Surname);
            cmd.Parameters.AddWithValue("BirthDate", studentClass.BirthDate);
            cmd.Parameters.AddWithValue("CreationTime", studentClass.CreationTime);
            cmd.Parameters.AddWithValue("ModificationTime", studentClass.ModificationTime);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btn_crtStudent_Click(object sender, EventArgs e)
        {
            StudentClass studentClass = new StudentClass();

            studentClass.Name = tbx_crtStudentName.Text;
            studentClass.Surname = tbx_crtStudentSur.Text;
            studentClass.BirthDate = Convert.ToDateTime(dtp_crtStudentBD.Value);
            studentClass.CreationTime = DateTime.Today;
            studentClass.ModificationTime = DateTime.Today;

            CreateStudent(studentClass);

            MessageBox.Show("Student added!");

            dgw_Student.DataSource = ReadAllStudents();
        }

        public List<StudentClass> ReadAllStudents()
        {
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

        private void dgw_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_updtStudentName.Text = dgw_Student.CurrentRow.Cells[1].Value.ToString();
            tbx_updtStudentSur.Text = dgw_Student.CurrentRow.Cells[2].Value.ToString();
            dtp_updtStudentBD.Value = (DateTime)dgw_Student.CurrentRow.Cells[3].Value;
        }

        public void UpdateStudent(StudentClass studentClass, int id)
        {
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update Student set Name=@name,Surname=@surname,BirthDate=@birthdate,CreationTime=@creationTime,ModificationTime=@modificationTime where Id=@id", sqlConnection);

            cmd.Parameters.AddWithValue("Id", id);
            cmd.Parameters.AddWithValue("Name", studentClass.Name);
            cmd.Parameters.AddWithValue("Surname", studentClass.Surname);
            cmd.Parameters.AddWithValue("BirthDate", studentClass.BirthDate);
            cmd.Parameters.AddWithValue("CreationTime", studentClass.CreationTime);
            cmd.Parameters.AddWithValue("ModificationTime", studentClass.ModificationTime);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Student updated!");
        }

        private void btn_updtStudent_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Selected Student will be UPDATED!\r\nDo you want to contunie?", "Update",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                StudentClass studentClass = new StudentClass();
                studentClass.Name = tbx_updtStudentName.Text;
                studentClass.Surname = tbx_updtStudentSur.Text;
                studentClass.BirthDate = Convert.ToDateTime(dtp_updtStudentBD.Value);
                studentClass.CreationTime = (DateTime)dgw_Student.CurrentRow.Cells[4].Value;
                studentClass.ModificationTime = DateTime.Today;

                UpdateStudent(studentClass, (int)dgw_Student.CurrentRow.Cells[0].Value);

                dgw_Student.DataSource = ReadAllStudents();
            }
            else
            {
            }
        }

        public void StudentDelete(int id)
        {
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("delete from Student where @id=Id", sqlConnection);

            cmd.Parameters.AddWithValue("Id", id);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btn_dltStudent_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Selected Student will be DELETED!" +
                "\r\nDo you want to continue?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                StudentClass studentClass = new StudentClass();

                int id = (int)dgw_Student.CurrentRow.Cells[0].Value;

                StudentDelete(id);

                MessageBox.Show("Student deleted!");

                dgw_Student.DataSource = ReadAllStudents();
            }
            else
            {
            }
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            dgw_Student.DataSource = ReadAllStudents();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (textBox1.Text.Length >= 2)
            {
                dgw_Student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView view = new DataView();

                adapter = new SqlDataAdapter($"select * from Student where Name like '{textBox1.Text}%'", sqlConnection);

                sqlConnection.Open();
                adapter.Fill(ds);
                view = new DataView(ds.Tables[0]);
                dgw_Student.DataSource = view;
                sqlConnection.Close();
            }
            else if (textBox1.Text.Length <= 1)
            {
                dgw_Student.DataSource = ReadAllStudents();
            }
        }
    }
}
