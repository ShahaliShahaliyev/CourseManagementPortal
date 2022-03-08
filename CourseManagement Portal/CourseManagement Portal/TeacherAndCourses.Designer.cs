namespace CourseManagement_Portal
{
    partial class TeacherAndCourses
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
            this.cb_TACTN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TACCN = new System.Windows.Forms.ComboBox();
            this.btn_TACSave = new System.Windows.Forms.Button();
            this.dgw_TeacherAndCourses = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TeacherAndCourses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_TACTN
            // 
            this.cb_TACTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TACTN.FormattingEnabled = true;
            this.cb_TACTN.Location = new System.Drawing.Point(67, 45);
            this.cb_TACTN.MaxDropDownItems = 80;
            this.cb_TACTN.Name = "cb_TACTN";
            this.cb_TACTN.Size = new System.Drawing.Size(206, 24);
            this.cb_TACTN.Sorted = true;
            this.cb_TACTN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(365, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course";
            // 
            // cb_TACCN
            // 
            this.cb_TACCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TACCN.FormattingEnabled = true;
            this.cb_TACCN.Location = new System.Drawing.Point(365, 45);
            this.cb_TACCN.Name = "cb_TACCN";
            this.cb_TACCN.Size = new System.Drawing.Size(206, 24);
            this.cb_TACCN.TabIndex = 3;
            // 
            // btn_TACSave
            // 
            this.btn_TACSave.BackColor = System.Drawing.Color.Lime;
            this.btn_TACSave.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TACSave.Location = new System.Drawing.Point(655, 36);
            this.btn_TACSave.Name = "btn_TACSave";
            this.btn_TACSave.Size = new System.Drawing.Size(75, 35);
            this.btn_TACSave.TabIndex = 4;
            this.btn_TACSave.Text = "SAVE";
            this.btn_TACSave.UseVisualStyleBackColor = false;
            this.btn_TACSave.Click += new System.EventHandler(this.btn_TACSave_Click);
            // 
            // dgw_TeacherAndCourses
            // 
            this.dgw_TeacherAndCourses.AllowUserToOrderColumns = true;
            this.dgw_TeacherAndCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_TeacherAndCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_TeacherAndCourses.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgw_TeacherAndCourses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgw_TeacherAndCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_TeacherAndCourses.Location = new System.Drawing.Point(11, 100);
            this.dgw_TeacherAndCourses.Name = "dgw_TeacherAndCourses";
            this.dgw_TeacherAndCourses.RowTemplate.Height = 25;
            this.dgw_TeacherAndCourses.Size = new System.Drawing.Size(777, 338);
            this.dgw_TeacherAndCourses.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_TACTN);
            this.groupBox1.Controls.Add(this.btn_TACSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_TACCN);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHOOSE THE COURSE THAT THE TEACHER WILL TEACH";
            // 
            // TeacherAndCourses
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgw_TeacherAndCourses);
            this.Name = "TeacherAndCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherAndCourses";
            this.Load += new System.EventHandler(this.TeacherAndCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TeacherAndCourses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TACTN;
        private System.Windows.Forms.ComboBox cb_TACCN;
        private System.Windows.Forms.Button btn_TACSave;
        private System.Windows.Forms.DataGridView dgw_TeacherAndCourses;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}