namespace CourseManagement_Portal
{
    partial class Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groups));
            this.dgw_GroupsNameInfo = new System.Windows.Forms.DataGridView();
            this.dgw_StudentAndGroups = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ASG = new System.Windows.Forms.Button();
            this.btn_CNG = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_GroupsNameInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_StudentAndGroups)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_GroupsNameInfo
            // 
            this.dgw_GroupsNameInfo.AllowUserToOrderColumns = true;
            this.dgw_GroupsNameInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_GroupsNameInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgw_GroupsNameInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_GroupsNameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_GroupsNameInfo.Location = new System.Drawing.Point(3, 19);
            this.dgw_GroupsNameInfo.Name = "dgw_GroupsNameInfo";
            this.dgw_GroupsNameInfo.RowTemplate.Height = 25;
            this.dgw_GroupsNameInfo.Size = new System.Drawing.Size(787, 168);
            this.dgw_GroupsNameInfo.TabIndex = 0;
            // 
            // dgw_StudentAndGroups
            // 
            this.dgw_StudentAndGroups.AllowUserToOrderColumns = true;
            this.dgw_StudentAndGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_StudentAndGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgw_StudentAndGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_StudentAndGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_StudentAndGroups.Location = new System.Drawing.Point(3, 19);
            this.dgw_StudentAndGroups.Name = "dgw_StudentAndGroups";
            this.dgw_StudentAndGroups.RowTemplate.Height = 25;
            this.dgw_StudentAndGroups.Size = new System.Drawing.Size(787, 158);
            this.dgw_StudentAndGroups.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_ASG);
            this.groupBox1.Controls.Add(this.btn_CNG);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(683, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "REFRESH";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ASG
            // 
            this.btn_ASG.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ASG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ASG.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ASG.ForeColor = System.Drawing.Color.Lime;
            this.btn_ASG.Location = new System.Drawing.Point(358, 9);
            this.btn_ASG.Name = "btn_ASG";
            this.btn_ASG.Size = new System.Drawing.Size(319, 46);
            this.btn_ASG.TabIndex = 1;
            this.btn_ASG.Text = "ADD STUDENTS TO GROUPS";
            this.btn_ASG.UseVisualStyleBackColor = false;
            this.btn_ASG.Click += new System.EventHandler(this.btn_ASG_Click);
            // 
            // btn_CNG
            // 
            this.btn_CNG.BackColor = System.Drawing.Color.Firebrick;
            this.btn_CNG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CNG.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CNG.ForeColor = System.Drawing.Color.Lime;
            this.btn_CNG.Location = new System.Drawing.Point(9, 9);
            this.btn_CNG.Name = "btn_CNG";
            this.btn_CNG.Size = new System.Drawing.Size(343, 46);
            this.btn_CNG.TabIndex = 0;
            this.btn_CNG.Text = "CREATE NEW GROUP";
            this.btn_CNG.UseVisualStyleBackColor = false;
            this.btn_CNG.Click += new System.EventHandler(this.btn_CNG_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.dgw_GroupsNameInfo);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(3, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Courses And Groups";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.dgw_StudentAndGroups);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.Sienna;
            this.groupBox3.Location = new System.Drawing.Point(3, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(793, 180);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Groups And Students";
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_GroupsNameInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_StudentAndGroups)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_GroupsNameInfo;
        private System.Windows.Forms.DataGridView dgw_StudentAndGroups;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ASG;
        private System.Windows.Forms.Button btn_CNG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}