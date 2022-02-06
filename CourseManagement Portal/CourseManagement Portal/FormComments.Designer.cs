namespace CourseManagement_Portal
{
    partial class FormComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComments));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RC = new System.Windows.Forms.Button();
            this.dgw_Comments = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_AC = new System.Windows.Forms.TextBox();
            this.btn_AC = new System.Windows.Forms.Button();
            this.rtb_C = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Comments)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btn_RC);
            this.groupBox1.Controls.Add(this.dgw_Comments);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments";
            // 
            // btn_RC
            // 
            this.btn_RC.BackColor = System.Drawing.Color.Lime;
            this.btn_RC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_RC.ForeColor = System.Drawing.Color.White;
            this.btn_RC.Location = new System.Drawing.Point(619, 183);
            this.btn_RC.Name = "btn_RC";
            this.btn_RC.Size = new System.Drawing.Size(151, 28);
            this.btn_RC.TabIndex = 1;
            this.btn_RC.Text = "Read Comments";
            this.btn_RC.UseVisualStyleBackColor = false;
            this.btn_RC.Click += new System.EventHandler(this.btn_RC_Click);
            // 
            // dgw_Comments
            // 
            this.dgw_Comments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Comments.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgw_Comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Comments.Location = new System.Drawing.Point(6, 25);
            this.dgw_Comments.Name = "dgw_Comments";
            this.dgw_Comments.RowTemplate.Height = 25;
            this.dgw_Comments.Size = new System.Drawing.Size(764, 152);
            this.dgw_Comments.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbx_AC);
            this.groupBox2.Controls.Add(this.btn_AC);
            this.groupBox2.Controls.Add(this.rtb_C);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Comment";
            // 
            // tbx_AC
            // 
            this.tbx_AC.Location = new System.Drawing.Point(120, 23);
            this.tbx_AC.Name = "tbx_AC";
            this.tbx_AC.Size = new System.Drawing.Size(499, 26);
            this.tbx_AC.TabIndex = 6;
            // 
            // btn_AC
            // 
            this.btn_AC.BackColor = System.Drawing.Color.Lime;
            this.btn_AC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AC.ForeColor = System.Drawing.Color.White;
            this.btn_AC.Location = new System.Drawing.Point(625, 20);
            this.btn_AC.Name = "btn_AC";
            this.btn_AC.Size = new System.Drawing.Size(151, 31);
            this.btn_AC.TabIndex = 5;
            this.btn_AC.Text = "Add Comment";
            this.btn_AC.UseVisualStyleBackColor = false;
            this.btn_AC.Click += new System.EventHandler(this.btn_AC_Click);
            // 
            // rtb_C
            // 
            this.rtb_C.Location = new System.Drawing.Point(120, 87);
            this.rtb_C.Name = "rtb_C";
            this.rtb_C.Size = new System.Drawing.Size(650, 96);
            this.rtb_C.TabIndex = 4;
            this.rtb_C.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // FormComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComments";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Comments)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_RC;
        private System.Windows.Forms.DataGridView dgw_Comments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AC;
        private System.Windows.Forms.RichTextBox rtb_C;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_AC;
        private System.Windows.Forms.Label label1;
    }
}