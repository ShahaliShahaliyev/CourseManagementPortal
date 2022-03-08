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
        SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

        public FormTeacher()
        {
            InitializeComponent();
        }

        public void CreateTeacher(TeacherClass teacherClass)
        {
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into Teacher values(@name,@surname,@birthDate,@profession)", sqlConnection);
            cmd.Parameters.AddWithValue("Name", teacherClass.Name);
            cmd.Parameters.AddWithValue("Surname", teacherClass.Surname);
            cmd.Parameters.AddWithValue("BirthDate", teacherClass.BirthDate);
            cmd.Parameters.AddWithValue("Profession", teacherClass.Profession);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btn_crtTeacher_Click(object sender, EventArgs e)
        {
            TeacherClass teacherClass = new TeacherClass();
            teacherClass.Name = tbx_crtTeacherName.Text;
            teacherClass.Surname = tbx_crtTeacherSur.Text;
            teacherClass.BirthDate = Convert.ToDateTime(dtp_crtTeacherBD.Value);
            teacherClass.Profession = cb_crtTeacher.Text;

            CreateTeacher(teacherClass);

            MessageBox.Show("Teacher added!");

            dgw_Teacher.DataSource = ReadAllTeacher();
        }

        public List<TeacherClass> ReadAllTeacher()
        {
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from Teacher", sqlConnection);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<TeacherClass> list = new List<TeacherClass>();
            while (sqlDataReader.Read())
            {
                TeacherClass teacherClass = new TeacherClass();

                teacherClass.Id = Convert.ToInt32(sqlDataReader["ID"]);
                teacherClass.Name = sqlDataReader.GetString("Name");
                teacherClass.Surname = sqlDataReader.GetString("Surname");
                teacherClass.BirthDate = sqlDataReader.GetDateTime("BirthDate");
                teacherClass.Profession = sqlDataReader.GetString("Profession");

                list.Add(teacherClass);
            }

            sqlDataReader.Close();

            sqlConnection.Close();

            return list;
        }
        private void dgw_Teacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_updtTeacherName.Text = dgw_Teacher.CurrentRow.Cells[1].Value.ToString();
            tbx_updtTeacherSur.Text = dgw_Teacher.CurrentRow.Cells[2].Value.ToString();
            dtp_updtTeacherBD.Value = Convert.ToDateTime(dgw_Teacher.CurrentRow.Cells[3].Value);
            cb_updtTeacher.Text = dgw_Teacher.CurrentRow.Cells[4].Value.ToString();
        }

        public void TeacherUpdate(TeacherClass teacherClass, int id)
        {
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update Teacher set Name=@name,Surname=@surname,BirthDate=@birthDate,Profession=@profession where Id=@id", sqlConnection);
            cmd.Parameters.AddWithValue("Id", id);
            cmd.Parameters.AddWithValue("Name", teacherClass.Name);
            cmd.Parameters.AddWithValue("Surname", teacherClass.Surname);
            cmd.Parameters.AddWithValue("BirthDate", teacherClass.BirthDate);
            cmd.Parameters.AddWithValue("Profession", teacherClass.Profession);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Teacher updated!");
        }

        private void btn_updtTeacher_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Selected Teacher will be UPDATED!\r\nDo you want to contunie?", "Update",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                TeacherClass teacherClass = new TeacherClass();

                teacherClass.Name = tbx_updtTeacherName.Text;
                teacherClass.Surname = tbx_updtTeacherSur.Text;
                teacherClass.BirthDate = Convert.ToDateTime(dtp_updtTeacherBD.Value);
                teacherClass.Profession = cb_updtTeacher.Text;

                TeacherUpdate(teacherClass, (int)dgw_Teacher.CurrentRow.Cells[0].Value);

                dgw_Teacher.DataSource = ReadAllTeacher();
            }
        }

        public void DeleteTeacher(int id)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("delete Teacher where Id=@id", sqlConnection);
            cmd.Parameters.AddWithValue("Id", id);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btn_dltTeacher_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Selected Teacher will be DELETED!" +
                "\r\n Do you want to continue?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                TeacherClass teacherClass = new TeacherClass();
                int id = (int)dgw_Teacher.CurrentRow.Cells[0].Value;

                DeleteTeacher(id);

                MessageBox.Show("Teacher deleted!");

                dgw_Teacher.DataSource = ReadAllTeacher();
            }
            else
            {
            }
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            dgw_Teacher.DataSource = ReadAllTeacher();

            cb_crtTeacher.Items.Clear();
            SqlDataReader reader;

            sqlConnection.Open();

            cmd.Connection = sqlConnection;
            cmd.CommandText = "select Name from Course";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
               cb_crtTeacher.Items.Add(reader["Name"].ToString());
            }

            sqlConnection.Close();

            cb_updtTeacher.Items.Clear();
            SqlDataReader reader1;
            sqlConnection.Open();

            cmd.Connection = sqlConnection;
            cmd.CommandText = "select Name from Course";
            reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                cb_updtTeacher.Items.Add(reader1["Name"].ToString());
            }

            sqlConnection.Close();
        }
         SqlCommand cmd = new SqlCommand();

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (textBox1.Text.Length > 1)
            {
                dgw_Teacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView view = new DataView();

                adapter = new SqlDataAdapter($"select * from Teacher where Name like '{textBox1.Text}%'", sqlConnection);

                sqlConnection.Open();
                adapter.Fill(ds);
                view = new DataView(ds.Tables[0]);
                dgw_Teacher.DataSource = view;
                sqlConnection.Close();
            }
            else if (textBox1.Text.Length <= 1)
            {
                dgw_Teacher.DataSource = ReadAllTeacher();
            }
        }
    }
}
