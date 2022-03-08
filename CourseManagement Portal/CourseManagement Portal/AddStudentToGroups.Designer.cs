namespace CourseManagement_Portal
{
    partial class AddStudentToGroups
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
            this.cb_ASCourseName = new System.Windows.Forms.ComboBox();
            this.cb_ASGroupName = new System.Windows.Forms.ComboBox();
            this.cb_ASStudentName = new System.Windows.Forms.ComboBox();
            this.btn_SaveStudentInGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student";
            // 
            // cb_ASCourseName
            // 
            this.cb_ASCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ASCourseName.FormattingEnabled = true;
            this.cb_ASCourseName.Location = new System.Drawing.Point(156, 15);
            this.cb_ASCourseName.MaxDropDownItems = 80;
            this.cb_ASCourseName.Name = "cb_ASCourseName";
            this.cb_ASCourseName.Size = new System.Drawing.Size(194, 23);
            this.cb_ASCourseName.TabIndex = 0;
            // 
            // cb_ASGroupName
            // 
            this.cb_ASGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ASGroupName.FormattingEnabled = true;
            this.cb_ASGroupName.Location = new System.Drawing.Point(156, 44);
            this.cb_ASGroupName.MaxDropDownItems = 80;
            this.cb_ASGroupName.Name = "cb_ASGroupName";
            this.cb_ASGroupName.Size = new System.Drawing.Size(194, 23);
            this.cb_ASGroupName.TabIndex = 1;
            this.cb_ASGroupName.Click += new System.EventHandler(this.cb_ASGroupName_Click);
            // 
            // cb_ASStudentName
            // 
            this.cb_ASStudentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ASStudentName.FormattingEnabled = true;
            this.cb_ASStudentName.Location = new System.Drawing.Point(156, 75);
            this.cb_ASStudentName.MaxDropDownItems = 80;
            this.cb_ASStudentName.Name = "cb_ASStudentName";
            this.cb_ASStudentName.Size = new System.Drawing.Size(194, 23);
            this.cb_ASStudentName.TabIndex = 2;
            // 
            // btn_SaveStudentInGroup
            // 
            this.btn_SaveStudentInGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SaveStudentInGroup.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SaveStudentInGroup.ForeColor = System.Drawing.Color.Lime;
            this.btn_SaveStudentInGroup.Location = new System.Drawing.Point(214, 104);
            this.btn_SaveStudentInGroup.Name = "btn_SaveStudentInGroup";
            this.btn_SaveStudentInGroup.Size = new System.Drawing.Size(136, 35);
            this.btn_SaveStudentInGroup.TabIndex = 3;
            this.btn_SaveStudentInGroup.Text = "Save";
            this.btn_SaveStudentInGroup.UseVisualStyleBackColor = false;
            this.btn_SaveStudentInGroup.Click += new System.EventHandler(this.btn_SaveStudentInGroup_Click);
            // 
            // AddStudentToGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 145);
            this.Controls.Add(this.btn_SaveStudentInGroup);
            this.Controls.Add(this.cb_ASStudentName);
            this.Controls.Add(this.cb_ASGroupName);
            this.Controls.Add(this.cb_ASCourseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentToGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentToGroups";
            this.Load += new System.EventHandler(this.AddStudentToGroups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ASCourseName;
        private System.Windows.Forms.ComboBox cb_ASGroupName;
        private System.Windows.Forms.ComboBox cb_ASStudentName;
        private System.Windows.Forms.Button btn_SaveStudentInGroup;
    }
}