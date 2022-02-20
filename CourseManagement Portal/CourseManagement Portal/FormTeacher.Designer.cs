namespace CourseManagement_Portal
{
    partial class FormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.dgw_Teacher = new System.Windows.Forms.DataGridView();
            this.btn_dltTeacher = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_updtTeacher = new System.Windows.Forms.ComboBox();
            this.btn_updtTeacher = new System.Windows.Forms.Button();
            this.dtp_updtTeacherBD = new System.Windows.Forms.DateTimePicker();
            this.tbx_updtTeacherSur = new System.Windows.Forms.TextBox();
            this.tbx_updtTeacherName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_crtTeacher = new System.Windows.Forms.ComboBox();
            this.tbx_crtTeacherSur = new System.Windows.Forms.TextBox();
            this.dtp_crtTeacherBD = new System.Windows.Forms.DateTimePicker();
            this.tbx_crtTeacherName = new System.Windows.Forms.TextBox();
            this.btn_crtTeacher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Teacher)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_Teacher
            // 
            this.dgw_Teacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Teacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgw_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Teacher.Location = new System.Drawing.Point(12, 6);
            this.dgw_Teacher.Name = "dgw_Teacher";
            this.dgw_Teacher.RowTemplate.Height = 25;
            this.dgw_Teacher.Size = new System.Drawing.Size(776, 266);
            this.dgw_Teacher.TabIndex = 14;
            this.dgw_Teacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Teacher_CellClick);
            // 
            // btn_dltTeacher
            // 
            this.btn_dltTeacher.BackColor = System.Drawing.Color.Red;
            this.btn_dltTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dltTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dltTeacher.Location = new System.Drawing.Point(263, 128);
            this.btn_dltTeacher.Name = "btn_dltTeacher";
            this.btn_dltTeacher.Size = new System.Drawing.Size(109, 32);
            this.btn_dltTeacher.TabIndex = 2;
            this.btn_dltTeacher.Text = "DELETE";
            this.btn_dltTeacher.UseVisualStyleBackColor = false;
            this.btn_dltTeacher.Click += new System.EventHandler(this.btn_dltTeacher_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.cb_updtTeacher);
            this.groupBox2.Controls.Add(this.btn_dltTeacher);
            this.groupBox2.Controls.Add(this.btn_updtTeacher);
            this.groupBox2.Controls.Add(this.dtp_updtTeacherBD);
            this.groupBox2.Controls.Add(this.tbx_updtTeacherSur);
            this.groupBox2.Controls.Add(this.tbx_updtTeacherName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(410, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 168);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE TEACHER";
            // 
            // cb_updtTeacher
            // 
            this.cb_updtTeacher.FormattingEnabled = true;
            this.cb_updtTeacher.Location = new System.Drawing.Point(151, 101);
            this.cb_updtTeacher.Name = "cb_updtTeacher";
            this.cb_updtTeacher.Size = new System.Drawing.Size(221, 23);
            this.cb_updtTeacher.TabIndex = 7;
            // 
            // btn_updtTeacher
            // 
            this.btn_updtTeacher.BackColor = System.Drawing.Color.Blue;
            this.btn_updtTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updtTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_updtTeacher.Location = new System.Drawing.Point(151, 128);
            this.btn_updtTeacher.Name = "btn_updtTeacher";
            this.btn_updtTeacher.Size = new System.Drawing.Size(109, 32);
            this.btn_updtTeacher.TabIndex = 12;
            this.btn_updtTeacher.Text = "UPDATE";
            this.btn_updtTeacher.UseVisualStyleBackColor = false;
            this.btn_updtTeacher.Click += new System.EventHandler(this.btn_updtTeacher_Click);
            // 
            // dtp_updtTeacherBD
            // 
            this.dtp_updtTeacherBD.Location = new System.Drawing.Point(151, 72);
            this.dtp_updtTeacherBD.Name = "dtp_updtTeacherBD";
            this.dtp_updtTeacherBD.Size = new System.Drawing.Size(221, 23);
            this.dtp_updtTeacherBD.TabIndex = 6;
            // 
            // tbx_updtTeacherSur
            // 
            this.tbx_updtTeacherSur.Location = new System.Drawing.Point(151, 46);
            this.tbx_updtTeacherSur.Name = "tbx_updtTeacherSur";
            this.tbx_updtTeacherSur.Size = new System.Drawing.Size(221, 23);
            this.tbx_updtTeacherSur.TabIndex = 5;
            // 
            // tbx_updtTeacherName
            // 
            this.tbx_updtTeacherName.Location = new System.Drawing.Point(151, 18);
            this.tbx_updtTeacherName.Name = "tbx_updtTeacherName";
            this.tbx_updtTeacherName.Size = new System.Drawing.Size(221, 23);
            this.tbx_updtTeacherName.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Profession";
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cb_crtTeacher);
            this.groupBox1.Controls.Add(this.tbx_crtTeacherSur);
            this.groupBox1.Controls.Add(this.dtp_crtTeacherBD);
            this.groupBox1.Controls.Add(this.tbx_crtTeacherName);
            this.groupBox1.Controls.Add(this.btn_crtTeacher);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE TEACHER";
            // 
            // cb_crtTeacher
            // 
            this.cb_crtTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_crtTeacher.FormattingEnabled = true;
            this.cb_crtTeacher.Location = new System.Drawing.Point(165, 101);
            this.cb_crtTeacher.Name = "cb_crtTeacher";
            this.cb_crtTeacher.Size = new System.Drawing.Size(221, 23);
            this.cb_crtTeacher.TabIndex = 3;
            // 
            // tbx_crtTeacherSur
            // 
            this.tbx_crtTeacherSur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_crtTeacherSur.Location = new System.Drawing.Point(165, 46);
            this.tbx_crtTeacherSur.Name = "tbx_crtTeacherSur";
            this.tbx_crtTeacherSur.Size = new System.Drawing.Size(221, 23);
            this.tbx_crtTeacherSur.TabIndex = 1;
            // 
            // dtp_crtTeacherBD
            // 
            this.dtp_crtTeacherBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_crtTeacherBD.Location = new System.Drawing.Point(165, 72);
            this.dtp_crtTeacherBD.Name = "dtp_crtTeacherBD";
            this.dtp_crtTeacherBD.Size = new System.Drawing.Size(221, 23);
            this.dtp_crtTeacherBD.TabIndex = 2;
            // 
            // tbx_crtTeacherName
            // 
            this.tbx_crtTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_crtTeacherName.Location = new System.Drawing.Point(165, 18);
            this.tbx_crtTeacherName.Name = "tbx_crtTeacherName";
            this.tbx_crtTeacherName.Size = new System.Drawing.Size(221, 23);
            this.tbx_crtTeacherName.TabIndex = 0;
            // 
            // btn_crtTeacher
            // 
            this.btn_crtTeacher.BackColor = System.Drawing.Color.Blue;
            this.btn_crtTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crtTeacher.ForeColor = System.Drawing.Color.White;
            this.btn_crtTeacher.Location = new System.Drawing.Point(277, 128);
            this.btn_crtTeacher.Name = "btn_crtTeacher";
            this.btn_crtTeacher.Size = new System.Drawing.Size(109, 32);
            this.btn_crtTeacher.TabIndex = 6;
            this.btn_crtTeacher.Text = "CREATE";
            this.btn_crtTeacher.UseVisualStyleBackColor = false;
            this.btn_crtTeacher.Click += new System.EventHandler(this.btn_crtTeacher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Profession";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "BirtDate";
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
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_Teacher);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Teacher)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Teacher;
        private System.Windows.Forms.Button btn_dltTeacher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_updtTeacher;
        private System.Windows.Forms.DateTimePicker dtp_updtTeacherBD;
        private System.Windows.Forms.TextBox tbx_updtTeacherSur;
        private System.Windows.Forms.TextBox tbx_updtTeacherName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_crtTeacherSur;
        private System.Windows.Forms.DateTimePicker dtp_crtTeacherBD;
        private System.Windows.Forms.TextBox tbx_crtTeacherName;
        private System.Windows.Forms.Button btn_crtTeacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_crtTeacher;
        private System.Windows.Forms.ComboBox cb_updtTeacher;
    }
}