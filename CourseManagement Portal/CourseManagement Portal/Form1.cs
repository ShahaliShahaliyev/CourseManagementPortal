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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            FormCourse formCourse = new FormCourse();
            formCourse.ShowDialog();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent();
            formStudent.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTeacher formTeacher = new FormTeacher();
            formTeacher.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThePlanOfCourse thePlanOfCourse = new ThePlanOfCourse();
            thePlanOfCourse.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           CommentForm commentForm = new CommentForm();
            commentForm.ShowDialog();
        }
    }
}
