namespace CourseManagement_Portal
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btn_none = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_TC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_none
            // 
            this.btn_none.BackColor = System.Drawing.Color.Lime;
            this.btn_none.CausesValidation = false;
            resources.ApplyResources(this.btn_none, "btn_none");
            this.btn_none.ForeColor = System.Drawing.Color.Red;
            this.btn_none.Name = "btn_none";
            this.btn_none.UseVisualStyleBackColor = false;
            // 
            // btn_course
            // 
            this.btn_course.AllowDrop = true;
            resources.ApplyResources(this.btn_course, "btn_course");
            this.btn_course.BackColor = System.Drawing.Color.DarkRed;
            this.btn_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_course.Name = "btn_course";
            this.btn_course.UseVisualStyleBackColor = false;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_student
            // 
            resources.ApplyResources(this.btn_student, "btn_student");
            this.btn_student.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_student.Name = "btn_student";
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_TC
            // 
            resources.ApplyResources(this.btn_TC, "btn_TC");
            this.btn_TC.BackColor = System.Drawing.Color.Chocolate;
            this.btn_TC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TC.ForeColor = System.Drawing.Color.White;
            this.btn_TC.Name = "btn_TC";
            this.btn_TC.UseVisualStyleBackColor = false;
            this.btn_TC.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_TC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_none);
            this.Controls.Add(this.btn_course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_none;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_TC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
