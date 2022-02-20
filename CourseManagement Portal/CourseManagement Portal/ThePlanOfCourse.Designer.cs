namespace CourseManagement_Portal
{
    partial class ThePlanOfCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThePlanOfCourse));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_SCD = new System.Windows.Forms.NumericUpDown();
            this.cb_SCC = new System.Windows.Forms.ComboBox();
            this.cb_SCS = new System.Windows.Forms.ComboBox();
            this.btn_SC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgw_OngoingCourse = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_OngoingCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.groupBox1.Controls.Add(this.nud_SCD);
            this.groupBox1.Controls.Add(this.cb_SCC);
            this.groupBox1.Controls.Add(this.cb_SCS);
            this.groupBox1.Controls.Add(this.btn_SC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "START THE COURSE";
            // 
            // nud_SCD
            // 
            this.nud_SCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nud_SCD.Location = new System.Drawing.Point(427, 38);
            this.nud_SCD.Name = "nud_SCD";
            this.nud_SCD.Size = new System.Drawing.Size(202, 26);
            this.nud_SCD.TabIndex = 2;
            // 
            // cb_SCC
            // 
            this.cb_SCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_SCC.FormattingEnabled = true;
            this.cb_SCC.Location = new System.Drawing.Point(219, 37);
            this.cb_SCC.Name = "cb_SCC";
            this.cb_SCC.Size = new System.Drawing.Size(202, 27);
            this.cb_SCC.TabIndex = 1;
            // 
            // cb_SCS
            // 
            this.cb_SCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_SCS.FormattingEnabled = true;
            this.cb_SCS.Location = new System.Drawing.Point(11, 37);
            this.cb_SCS.MaxDropDownItems = 20;
            this.cb_SCS.Name = "cb_SCS";
            this.cb_SCS.Size = new System.Drawing.Size(202, 27);
            this.cb_SCS.TabIndex = 0;
            // 
            // btn_SC
            // 
            this.btn_SC.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_SC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SC.Location = new System.Drawing.Point(651, 36);
            this.btn_SC.Name = "btn_SC";
            this.btn_SC.Size = new System.Drawing.Size(125, 25);
            this.btn_SC.TabIndex = 3;
            this.btn_SC.Text = "START";
            this.btn_SC.UseVisualStyleBackColor = false;
            this.btn_SC.Click += new System.EventHandler(this.btn_SC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(427, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(219, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // dgw_OngoingCourse
            // 
            this.dgw_OngoingCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_OngoingCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_OngoingCourse.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgw_OngoingCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_OngoingCourse.GridColor = System.Drawing.Color.Red;
            this.dgw_OngoingCourse.Location = new System.Drawing.Point(6, 81);
            this.dgw_OngoingCourse.Name = "dgw_OngoingCourse";
            this.dgw_OngoingCourse.RowTemplate.Height = 25;
            this.dgw_OngoingCourse.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgw_OngoingCourse.Size = new System.Drawing.Size(782, 365);
            this.dgw_OngoingCourse.TabIndex = 1;
            // 
            // ThePlanOfCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_OngoingCourse);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ThePlanOfCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThePlanOfCourse";
            this.Load += new System.EventHandler(this.ThePlanOfCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_OngoingCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_SCD;
        private System.Windows.Forms.ComboBox cb_SCC;
        private System.Windows.Forms.ComboBox cb_SCS;
        private System.Windows.Forms.Button btn_SC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw_OngoingCourse;
    }
}