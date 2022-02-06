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
    public partial class FormComments : Form
    {
        public FormComments()
        {
            InitializeComponent();
        }

        public void AddComment(CommentClass commentClass)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("insert into Comments values (@studentName,@comment)",sqlConnection);

            sqlCommand.Parameters.AddWithValue("StudentName", commentClass.StudentName);
            sqlCommand.Parameters.AddWithValue("Comment", commentClass.Comment);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            CommentClass commentClass = new CommentClass();

            commentClass.StudentName = tbx_AC.Text;
            commentClass.Comment = rtb_C.Text + "/Tarix- " + DateTime.Now;
            AddComment(commentClass);

            MessageBox.Show("Comment Added!");
        }

        public List<CommentClass> ReadAllComments()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-402TSI6\SQLSERVER; Database=CourseManagementPortal; Trusted_Connection=true;TrustServerCertificate=true;");

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("select * from Comments", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<CommentClass> list = new List<CommentClass>();
            while (sqlDataReader.Read())
            {
                CommentClass commentClass = new CommentClass();
                commentClass.StudentName = sqlDataReader.GetString("StudentName");
                commentClass.Comment = sqlDataReader.GetString("Comment");

                list.Add(commentClass);
            }

            sqlDataReader.Close();

            sqlConnection.Close();

            return list;
        }

        private void btn_RC_Click(object sender, EventArgs e)
        {
            dgw_Comments.DataSource = ReadAllComments();
        }
    }
}
