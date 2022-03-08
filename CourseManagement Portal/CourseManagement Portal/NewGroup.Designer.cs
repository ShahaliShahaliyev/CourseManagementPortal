namespace CourseManagement_Portal
{
    partial class NewGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_NewGroupCourse = new System.Windows.Forms.ComboBox();
            this.tbx_NewGroupGN = new System.Windows.Forms.TextBox();
            this.dtp_PSNG = new System.Windows.Forms.DateTimePicker();
            this.dtp_PENG = new System.Windows.Forms.DateTimePicker();
            this.btn_CreateGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Planned Startdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Planned Enddate";
            // 
            // cb_NewGroupCourse
            // 
            this.cb_NewGroupCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NewGroupCourse.FormattingEnabled = true;
            this.cb_NewGroupCourse.Location = new System.Drawing.Point(165, 9);
            this.cb_NewGroupCourse.MaxDropDownItems = 80;
            this.cb_NewGroupCourse.Name = "cb_NewGroupCourse";
            this.cb_NewGroupCourse.Size = new System.Drawing.Size(218, 23);
            this.cb_NewGroupCourse.TabIndex = 0;
            // 
            // tbx_NewGroupGN
            // 
            this.tbx_NewGroupGN.Location = new System.Drawing.Point(165, 41);
            this.tbx_NewGroupGN.Name = "tbx_NewGroupGN";
            this.tbx_NewGroupGN.Size = new System.Drawing.Size(218, 23);
            this.tbx_NewGroupGN.TabIndex = 1;
            // 
            // dtp_PSNG
            // 
            this.dtp_PSNG.Location = new System.Drawing.Point(165, 72);
            this.dtp_PSNG.Name = "dtp_PSNG";
            this.dtp_PSNG.Size = new System.Drawing.Size(218, 23);
            this.dtp_PSNG.TabIndex = 2;
            // 
            // dtp_PENG
            // 
            this.dtp_PENG.Location = new System.Drawing.Point(165, 106);
            this.dtp_PENG.Name = "dtp_PENG";
            this.dtp_PENG.Size = new System.Drawing.Size(218, 23);
            this.dtp_PENG.TabIndex = 3;
            // 
            // btn_CreateGroup
            // 
            this.btn_CreateGroup.BackColor = System.Drawing.Color.Brown;
            this.btn_CreateGroup.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateGroup.ForeColor = System.Drawing.Color.Lime;
            this.btn_CreateGroup.Location = new System.Drawing.Point(218, 130);
            this.btn_CreateGroup.Name = "btn_CreateGroup";
            this.btn_CreateGroup.Size = new System.Drawing.Size(165, 34);
            this.btn_CreateGroup.TabIndex = 4;
            this.btn_CreateGroup.Text = "Create";
            this.btn_CreateGroup.UseVisualStyleBackColor = false;
            this.btn_CreateGroup.Click += new System.EventHandler(this.btn_CreateGroup_Click);
            // 
            // NewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 175);
            this.Controls.Add(this.btn_CreateGroup);
            this.Controls.Add(this.dtp_PENG);
            this.Controls.Add(this.dtp_PSNG);
            this.Controls.Add(this.tbx_NewGroupGN);
            this.Controls.Add(this.cb_NewGroupCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGroup";
            this.Load += new System.EventHandler(this.NewGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_NewGroupCourse;
        private System.Windows.Forms.TextBox tbx_NewGroupGN;
        private System.Windows.Forms.DateTimePicker dtp_PSNG;
        private System.Windows.Forms.DateTimePicker dtp_PENG;
        private System.Windows.Forms.Button btn_CreateGroup;
    }
}