﻿using System;
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
    public partial class FormCourse : Form
    {
        public void CreateCourse(CourseClass courseClass)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into Course values(@name,@duration,@price,@creationTime,@modificationTime)", sqlConnection);
            cmd.Parameters.AddWithValue("Name", courseClass.Name);
            cmd.Parameters.AddWithValue("Duration", courseClass.Duration);
            cmd.Parameters.AddWithValue("Price", courseClass.Price);
            cmd.Parameters.AddWithValue("CreationTime", courseClass.CreationTime);
            cmd.Parameters.AddWithValue("ModificationTime", courseClass.ModificationTime);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public FormCourse()
        {
            InitializeComponent();
        }

        private void btn_crtCourse_Click(object sender, EventArgs e)
        {
            CourseClass courseClass = new CourseClass();

            courseClass.Name = tbx_crtCourseName.Text;
            courseClass.Duration = int.Parse(tbx_crtCourseDur.Text);
            courseClass.Price =Convert.ToInt32(nud_crtCoursePrice.Value);
            courseClass.CreationTime = Convert.ToDateTime(dtp_crtCourseCT.Value);
            courseClass.ModificationTime = Convert.ToDateTime(dtp_crtCourseMT.Value);

            CreateCourse(courseClass);

            MessageBox.Show("Course Added!");
        }


        public List<CourseClass> ReadAllCourse()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("Select * from Course", sqlConnection);

            SqlDataReader reader = cmd.ExecuteReader();
            List<CourseClass> list = new List<CourseClass>();
            while (reader.Read())
            {
                CourseClass courseClass = new CourseClass();
                courseClass.Id = (int)reader.GetInt32("Id");
                courseClass.Name = reader.GetString("Name");
                courseClass.Duration = (int)reader.GetInt32("Duration");
                courseClass.CreationTime = reader.GetDateTime("CreationTime");
                courseClass.ModificationTime = reader.GetDateTime("ModificationTime");

                list.Add(courseClass);
            }

            reader.Close();

            sqlConnection.Close();

            return list;
        }

        private void btn_rdCourse_Click(object sender, EventArgs e)
        {
            dgw_Course.DataSource = ReadAllCourse();
        }

        private void dgw_Course_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_updtCourseName.Text = dgw_Course.CurrentRow.Cells[1].Value.ToString();
            tbx_updtCourseDur.Text = dgw_Course.CurrentRow.Cells[2].Value.ToString();
            nud_updtCoursePrice.Value = (int)dgw_Course.CurrentRow.Cells[3].Value;
            dtp_updtCourseCT.Value = (DateTime)dgw_Course.CurrentRow.Cells[4].Value;
            dtp_updtCourseMT.Value = (DateTime)dgw_Course.CurrentRow.Cells[5].Value;
        }

        public void CourseUpdate(CourseClass courseClass, int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update  Course set Name=@name,Duration=@duration,Price=@price,CreationTime=@creationTime,ModificationTime=@modificationTime where Id=@id", sqlConnection);

            cmd.Parameters.AddWithValue("Id", id);
            cmd.Parameters.AddWithValue("Name", courseClass.Name);
            cmd.Parameters.AddWithValue("Duration", courseClass.Duration);
            cmd.Parameters.AddWithValue("Price", courseClass.Price);
            cmd.Parameters.AddWithValue("CreationTime", courseClass.CreationTime);
            cmd.Parameters.AddWithValue("ModificationTime", courseClass.ModificationTime);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Updated!");
        }

        private void btn_updtCourse_Click(object sender, EventArgs e)
        {
            CourseClass courseClass = new CourseClass();

            courseClass.Name = tbx_updtCourseName.Text;
            courseClass.Duration = int.Parse(tbx_updtCourseDur.Text);
            courseClass.Price = Convert.ToInt32(nud_updtCoursePrice.Value);
            courseClass.CreationTime = Convert.ToDateTime(dtp_updtCourseCT.Value);
            courseClass.ModificationTime = Convert.ToDateTime(dtp_updtCourseMT.Value);

            CourseUpdate(courseClass, (int)dgw_Course.CurrentRow.Cells[0].Value);
        }


        public void CourseDelete(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("Delete from Course where Id = @id", sqlConnection);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();


        }

        private void btn_dltCourse_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           
            if (dialogResult == DialogResult.OK)
            {
                CourseClass courseClass = new CourseClass();

                int id = (int)dgw_Course.CurrentRow.Cells[0].Value;

                CourseDelete(id);

                MessageBox.Show("Course deleted!");
            }
            else
            {
            }
        }
    }
}
