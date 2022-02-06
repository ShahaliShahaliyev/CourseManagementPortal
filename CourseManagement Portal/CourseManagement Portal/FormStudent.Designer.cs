namespace CourseManagement_Portal
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.dgw_Student = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_dltStudent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_rdStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_updtStudentBD = new System.Windows.Forms.DateTimePicker();
            this.btn_updtStudent = new System.Windows.Forms.Button();
            this.dtp_updtStudentMT = new System.Windows.Forms.DateTimePicker();
            this.dtp_updtStudentCT = new System.Windows.Forms.DateTimePicker();
            this.tbx_updtStudentSur = new System.Windows.Forms.TextBox();
            this.tbx_updtStudentName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_crtStudentBD = new System.Windows.Forms.DateTimePicker();
            this.tbx_crtStudentSur = new System.Windows.Forms.TextBox();
            this.dtp_crtStudentMT = new System.Windows.Forms.DateTimePicker();
            this.dtp_crtStudentCT = new System.Windows.Forms.DateTimePicker();
            this.tbx_crtStudentName = new System.Windows.Forms.TextBox();
            this.btn_crtStudent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Student)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_Student
            // 
            this.dgw_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Student.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgw_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Student.Location = new System.Drawing.Point(12, 6);
            this.dgw_Student.Name = "dgw_Student";
            this.dgw_Student.RowTemplate.Height = 25;
            this.dgw_Student.Size = new System.Drawing.Size(776, 171);
            this.dgw_Student.TabIndex = 9;
            this.dgw_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Student_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.btn_dltStudent);
            this.groupBox4.Location = new System.Drawing.Point(533, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 155);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DELETE";
            // 
            // btn_dltStudent
            // 
            this.btn_dltStudent.BackColor = System.Drawing.Color.Red;
            this.btn_dltStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dltStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dltStudent.Location = new System.Drawing.Point(54, 67);
            this.btn_dltStudent.Name = "btn_dltStudent";
            this.btn_dltStudent.Size = new System.Drawing.Size(154, 37);
            this.btn_dltStudent.TabIndex = 2;
            this.btn_dltStudent.Text = "DELETE";
            this.btn_dltStudent.UseVisualStyleBackColor = false;
            this.btn_dltStudent.Click += new System.EventHandler(this.btn_dltStudent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.btn_rdStudent);
            this.groupBox3.Location = new System.Drawing.Point(533, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "READ";
            // 
            // btn_rdStudent
            // 
            this.btn_rdStudent.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_rdStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rdStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rdStudent.Location = new System.Drawing.Point(54, 33);
            this.btn_rdStudent.Name = "btn_rdStudent";
            this.btn_rdStudent.Size = new System.Drawing.Size(154, 52);
            this.btn_rdStudent.TabIndex = 0;
            this.btn_rdStudent.Text = "Read Student İnformation\r\n";
            this.btn_rdStudent.UseVisualStyleBackColor = false;
            this.btn_rdStudent.Click += new System.EventHandler(this.btn_rdStudent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.dtp_updtStudentBD);
            this.groupBox2.Controls.Add(this.btn_updtStudent);
            this.groupBox2.Controls.Add(this.dtp_updtStudentMT);
            this.groupBox2.Controls.Add(this.dtp_updtStudentCT);
            this.groupBox2.Controls.Add(this.tbx_updtStudentSur);
            this.groupBox2.Controls.Add(this.tbx_updtStudentName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(266, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 261);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE STUDENT";
            // 
            // dtp_updtStudentBD
            // 
            this.dtp_updtStudentBD.Location = new System.Drawing.Point(110, 72);
            this.dtp_updtStudentBD.Name = "dtp_updtStudentBD";
            this.dtp_updtStudentBD.Size = new System.Drawing.Size(139, 23);
            this.dtp_updtStudentBD.TabIndex = 13;
            // 
            // btn_updtStudent
            // 
            this.btn_updtStudent.BackColor = System.Drawing.Color.Blue;
            this.btn_updtStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updtStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_updtStudent.Location = new System.Drawing.Point(92, 219);
            this.btn_updtStudent.Name = "btn_updtStudent";
            this.btn_updtStudent.Size = new System.Drawing.Size(75, 36);
            this.btn_updtStudent.TabIndex = 12;
            this.btn_updtStudent.Text = "UPDATE";
            this.btn_updtStudent.UseVisualStyleBackColor = false;
            this.btn_updtStudent.AutoSizeChanged += new System.EventHandler(this.btn_rdStudent_Click);
            this.btn_updtStudent.Click += new System.EventHandler(this.btn_updtStudent_Click);
            // 
            // dtp_updtStudentMT
            // 
            this.dtp_updtStudentMT.Location = new System.Drawing.Point(110, 134);
            this.dtp_updtStudentMT.Name = "dtp_updtStudentMT";
            this.dtp_updtStudentMT.Size = new System.Drawing.Size(139, 23);
            this.dtp_updtStudentMT.TabIndex = 11;
            // 
            // dtp_updtStudentCT
            // 
            this.dtp_updtStudentCT.Location = new System.Drawing.Point(110, 105);
            this.dtp_updtStudentCT.Name = "dtp_updtStudentCT";
            this.dtp_updtStudentCT.Size = new System.Drawing.Size(139, 23);
            this.dtp_updtStudentCT.TabIndex = 10;
            // 
            // tbx_updtStudentSur
            // 
            this.tbx_updtStudentSur.Location = new System.Drawing.Point(110, 46);
            this.tbx_updtStudentSur.Name = "tbx_updtStudentSur";
            this.tbx_updtStudentSur.Size = new System.Drawing.Size(139, 23);
            this.tbx_updtStudentSur.TabIndex = 9;
            // 
            // tbx_updtStudentName
            // 
            this.tbx_updtStudentName.Location = new System.Drawing.Point(110, 18);
            this.tbx_updtStudentName.Name = "tbx_updtStudentName";
            this.tbx_updtStudentName.Size = new System.Drawing.Size(139, 23);
            this.tbx_updtStudentName.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Modification Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Creation Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "BirthDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Surname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.dtp_crtStudentBD);
            this.groupBox1.Controls.Add(this.tbx_crtStudentSur);
            this.groupBox1.Controls.Add(this.dtp_crtStudentMT);
            this.groupBox1.Controls.Add(this.dtp_crtStudentCT);
            this.groupBox1.Controls.Add(this.tbx_crtStudentName);
            this.groupBox1.Controls.Add(this.btn_crtStudent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 261);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE STUDENT";
            // 
            // dtp_crtStudentBD
            // 
            this.dtp_crtStudentBD.Location = new System.Drawing.Point(103, 72);
            this.dtp_crtStudentBD.Name = "dtp_crtStudentBD";
            this.dtp_crtStudentBD.Size = new System.Drawing.Size(139, 23);
            this.dtp_crtStudentBD.TabIndex = 14;
            // 
            // tbx_crtStudentSur
            // 
            this.tbx_crtStudentSur.Location = new System.Drawing.Point(103, 46);
            this.tbx_crtStudentSur.Name = "tbx_crtStudentSur";
            this.tbx_crtStudentSur.Size = new System.Drawing.Size(139, 23);
            this.tbx_crtStudentSur.TabIndex = 13;
            // 
            // dtp_crtStudentMT
            // 
            this.dtp_crtStudentMT.Location = new System.Drawing.Point(103, 134);
            this.dtp_crtStudentMT.Name = "dtp_crtStudentMT";
            this.dtp_crtStudentMT.Size = new System.Drawing.Size(139, 23);
            this.dtp_crtStudentMT.TabIndex = 12;
            // 
            // dtp_crtStudentCT
            // 
            this.dtp_crtStudentCT.Location = new System.Drawing.Point(103, 103);
            this.dtp_crtStudentCT.Name = "dtp_crtStudentCT";
            this.dtp_crtStudentCT.Size = new System.Drawing.Size(139, 23);
            this.dtp_crtStudentCT.TabIndex = 11;
            // 
            // tbx_crtStudentName
            // 
            this.tbx_crtStudentName.Location = new System.Drawing.Point(103, 18);
            this.tbx_crtStudentName.Name = "tbx_crtStudentName";
            this.tbx_crtStudentName.Size = new System.Drawing.Size(139, 23);
            this.tbx_crtStudentName.TabIndex = 10;
            // 
            // btn_crtStudent
            // 
            this.btn_crtStudent.BackColor = System.Drawing.Color.Blue;
            this.btn_crtStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crtStudent.ForeColor = System.Drawing.Color.White;
            this.btn_crtStudent.Location = new System.Drawing.Point(84, 219);
            this.btn_crtStudent.Name = "btn_crtStudent";
            this.btn_crtStudent.Size = new System.Drawing.Size(75, 36);
            this.btn_crtStudent.TabIndex = 6;
            this.btn_crtStudent.Text = "CREATE";
            this.btn_crtStudent.UseVisualStyleBackColor = false;
            this.btn_crtStudent.Click += new System.EventHandler(this.btn_crtStudent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "ModificationTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Creation Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "BirthDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_Student);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Student)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Student;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_dltStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_rdStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_updtStudent;
        private System.Windows.Forms.DateTimePicker dtp_updtStudentMT;
        private System.Windows.Forms.DateTimePicker dtp_updtStudentCT;
        private System.Windows.Forms.TextBox tbx_updtStudentSur;
        private System.Windows.Forms.TextBox tbx_updtStudentName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_crtStudentSur;
        private System.Windows.Forms.DateTimePicker dtp_crtStudentMT;
        private System.Windows.Forms.DateTimePicker dtp_crtStudentCT;
        private System.Windows.Forms.TextBox tbx_crtStudentName;
        private System.Windows.Forms.Button btn_crtStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_crtStudentBD;
        private System.Windows.Forms.DateTimePicker dtp_updtStudentBD;
    }
}