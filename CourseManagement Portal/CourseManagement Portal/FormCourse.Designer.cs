namespace CourseManagement_Portal
{
    partial class FormCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCourse));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_crtCoursePrice = new System.Windows.Forms.NumericUpDown();
            this.tbx_crtCourseDur = new System.Windows.Forms.TextBox();
            this.tbx_crtCourseName = new System.Windows.Forms.TextBox();
            this.btn_crtCourse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_dltCourse = new System.Windows.Forms.Button();
            this.btn_updtCourse = new System.Windows.Forms.Button();
            this.tbx_updtCourseDur = new System.Windows.Forms.TextBox();
            this.tbx_updtCourseName = new System.Windows.Forms.TextBox();
            this.nud_updtCoursePrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgw_Course = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_crtCoursePrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_updtCoursePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.nud_crtCoursePrice);
            this.groupBox1.Controls.Add(this.tbx_crtCourseDur);
            this.groupBox1.Controls.Add(this.tbx_crtCourseName);
            this.groupBox1.Controls.Add(this.btn_crtCourse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE COURSE";
            // 
            // nud_crtCoursePrice
            // 
            this.nud_crtCoursePrice.Location = new System.Drawing.Point(158, 74);
            this.nud_crtCoursePrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_crtCoursePrice.Name = "nud_crtCoursePrice";
            this.nud_crtCoursePrice.Size = new System.Drawing.Size(224, 23);
            this.nud_crtCoursePrice.TabIndex = 2;
            // 
            // tbx_crtCourseDur
            // 
            this.tbx_crtCourseDur.Location = new System.Drawing.Point(158, 45);
            this.tbx_crtCourseDur.Name = "tbx_crtCourseDur";
            this.tbx_crtCourseDur.Size = new System.Drawing.Size(224, 23);
            this.tbx_crtCourseDur.TabIndex = 1;
            // 
            // tbx_crtCourseName
            // 
            this.tbx_crtCourseName.Location = new System.Drawing.Point(158, 16);
            this.tbx_crtCourseName.Name = "tbx_crtCourseName";
            this.tbx_crtCourseName.Size = new System.Drawing.Size(224, 23);
            this.tbx_crtCourseName.TabIndex = 0;
            // 
            // btn_crtCourse
            // 
            this.btn_crtCourse.BackColor = System.Drawing.Color.Blue;
            this.btn_crtCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crtCourse.ForeColor = System.Drawing.Color.White;
            this.btn_crtCourse.Location = new System.Drawing.Point(293, 103);
            this.btn_crtCourse.Name = "btn_crtCourse";
            this.btn_crtCourse.Size = new System.Drawing.Size(89, 40);
            this.btn_crtCourse.TabIndex = 6;
            this.btn_crtCourse.Text = "CREATE";
            this.btn_crtCourse.UseVisualStyleBackColor = false;
            this.btn_crtCourse.Click += new System.EventHandler(this.btn_crtCourse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price(AZN)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btn_dltCourse);
            this.groupBox2.Controls.Add(this.btn_updtCourse);
            this.groupBox2.Controls.Add(this.tbx_updtCourseDur);
            this.groupBox2.Controls.Add(this.tbx_updtCourseName);
            this.groupBox2.Controls.Add(this.nud_updtCoursePrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(400, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE COURSE";
            // 
            // btn_dltCourse
            // 
            this.btn_dltCourse.BackColor = System.Drawing.Color.Red;
            this.btn_dltCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dltCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dltCourse.Location = new System.Drawing.Point(293, 102);
            this.btn_dltCourse.Name = "btn_dltCourse";
            this.btn_dltCourse.Size = new System.Drawing.Size(89, 40);
            this.btn_dltCourse.TabIndex = 2;
            this.btn_dltCourse.Text = "DELETE";
            this.btn_dltCourse.UseVisualStyleBackColor = false;
            this.btn_dltCourse.Click += new System.EventHandler(this.btn_dltCourse_Click);
            // 
            // btn_updtCourse
            // 
            this.btn_updtCourse.BackColor = System.Drawing.Color.Blue;
            this.btn_updtCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updtCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_updtCourse.Location = new System.Drawing.Point(198, 103);
            this.btn_updtCourse.Name = "btn_updtCourse";
            this.btn_updtCourse.Size = new System.Drawing.Size(89, 40);
            this.btn_updtCourse.TabIndex = 12;
            this.btn_updtCourse.Text = "UPDATE";
            this.btn_updtCourse.UseVisualStyleBackColor = false;
            this.btn_updtCourse.Click += new System.EventHandler(this.btn_updtCourse_Click);
            // 
            // tbx_updtCourseDur
            // 
            this.tbx_updtCourseDur.Location = new System.Drawing.Point(158, 45);
            this.tbx_updtCourseDur.Name = "tbx_updtCourseDur";
            this.tbx_updtCourseDur.Size = new System.Drawing.Size(224, 23);
            this.tbx_updtCourseDur.TabIndex = 4;
            // 
            // tbx_updtCourseName
            // 
            this.tbx_updtCourseName.Location = new System.Drawing.Point(158, 16);
            this.tbx_updtCourseName.Name = "tbx_updtCourseName";
            this.tbx_updtCourseName.Size = new System.Drawing.Size(224, 23);
            this.tbx_updtCourseName.TabIndex = 3;
            // 
            // nud_updtCoursePrice
            // 
            this.nud_updtCoursePrice.Location = new System.Drawing.Point(158, 74);
            this.nud_updtCoursePrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_updtCoursePrice.Name = "nud_updtCoursePrice";
            this.nud_updtCoursePrice.Size = new System.Drawing.Size(224, 23);
            this.nud_updtCoursePrice.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Price(AZN)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Duration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            // 
            // dgw_Course
            // 
            this.dgw_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Course.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw_Course.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgw_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Course.Location = new System.Drawing.Point(12, 8);
            this.dgw_Course.Name = "dgw_Course";
            this.dgw_Course.RowTemplate.Height = 25;
            this.dgw_Course.Size = new System.Drawing.Size(776, 285);
            this.dgw_Course.TabIndex = 4;
            this.dgw_Course.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Course_CellClick);
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_Course);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCourse";
            this.Load += new System.EventHandler(this.FormCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_crtCoursePrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_updtCoursePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_crtCourseName;
        private System.Windows.Forms.Button btn_crtCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgw_Course;
        private System.Windows.Forms.TextBox tbx_crtCourseDur;
        private System.Windows.Forms.Button btn_updtCourse;
        private System.Windows.Forms.TextBox tbx_updtCourseDur;
        private System.Windows.Forms.TextBox tbx_updtCourseName;
        private System.Windows.Forms.NumericUpDown nud_updtCoursePrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_dltCourse;
        private System.Windows.Forms.NumericUpDown nud_crtCoursePrice;
        private System.Windows.Forms.TextBox textBox1;
    }
}