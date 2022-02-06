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
            this.btn_OC = new System.Windows.Forms.Button();
            this.dgw_OC = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_OC)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_none
            // 
            this.btn_none.BackColor = System.Drawing.Color.Gold;
            this.btn_none.Font = new System.Drawing.Font("Bodoni MT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_none.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_none.Location = new System.Drawing.Point(157, 10);
            this.btn_none.Name = "btn_none";
            this.btn_none.Size = new System.Drawing.Size(492, 81);
            this.btn_none.TabIndex = 0;
            this.btn_none.Text = "Course Management Portal";
            this.btn_none.UseVisualStyleBackColor = false;
            // 
            // btn_course
            // 
            this.btn_course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_course.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_course.Location = new System.Drawing.Point(12, 97);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(250, 48);
            this.btn_course.TabIndex = 1;
            this.btn_course.Text = "COURSE";
            this.btn_course.UseVisualStyleBackColor = false;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_student
            // 
            this.btn_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_student.Location = new System.Drawing.Point(268, 97);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(265, 48);
            this.btn_student.TabIndex = 2;
            this.btn_student.Text = "STUDENT";
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(539, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "TEACHER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_OC
            // 
            this.btn_OC.BackColor = System.Drawing.Color.Green;
            this.btn_OC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OC.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OC.ForeColor = System.Drawing.Color.White;
            this.btn_OC.Location = new System.Drawing.Point(386, 151);
            this.btn_OC.Name = "btn_OC";
            this.btn_OC.Size = new System.Drawing.Size(402, 48);
            this.btn_OC.TabIndex = 4;
            this.btn_OC.Text = "Ongoing Courses\r\n";
            this.btn_OC.UseVisualStyleBackColor = false;
            this.btn_OC.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgw_OC
            // 
            this.dgw_OC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_OC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgw_OC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_OC.GridColor = System.Drawing.Color.Red;
            this.dgw_OC.Location = new System.Drawing.Point(12, 218);
            this.dgw_OC.Name = "dgw_OC";
            this.dgw_OC.RowTemplate.Height = 25;
            this.dgw_OC.Size = new System.Drawing.Size(776, 212);
            this.dgw_OC.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Comments";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgw_OC);
            this.Controls.Add(this.btn_OC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.btn_none);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_OC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_none;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_OC;
        private System.Windows.Forms.DataGridView dgw_OC;
        private System.Windows.Forms.Button button1;
    }
}
