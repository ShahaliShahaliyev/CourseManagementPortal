namespace CourseManagement_Portal
{
    partial class CommentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentForm));
            this.cb_ACS = new System.Windows.Forms.ComboBox();
            this.cb_ACC = new System.Windows.Forms.ComboBox();
            this.dtp_ACD = new System.Windows.Forms.DateTimePicker();
            this.rtb_ACComment = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_CommentGroup = new System.Windows.Forms.ComboBox();
            this.rb_Ietmb = new System.Windows.Forms.RadioButton();
            this.rb_Iedb = new System.Windows.Forms.RadioButton();
            this.tbx_LessonComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddComment = new System.Windows.Forms.Button();
            this.dgw_Comments = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Comments)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ACS
            // 
            this.cb_ACS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ACS.FormattingEnabled = true;
            this.cb_ACS.Location = new System.Drawing.Point(513, 34);
            this.cb_ACS.MaxDropDownItems = 80;
            this.cb_ACS.Name = "cb_ACS";
            this.cb_ACS.Size = new System.Drawing.Size(206, 27);
            this.cb_ACS.TabIndex = 2;
            this.cb_ACS.Click += new System.EventHandler(this.cb_ACS_Click);
            // 
            // cb_ACC
            // 
            this.cb_ACC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ACC.FormattingEnabled = true;
            this.cb_ACC.Location = new System.Drawing.Point(17, 37);
            this.cb_ACC.MaxDropDownItems = 80;
            this.cb_ACC.Name = "cb_ACC";
            this.cb_ACC.Size = new System.Drawing.Size(206, 27);
            this.cb_ACC.TabIndex = 0;
            // 
            // dtp_ACD
            // 
            this.dtp_ACD.Location = new System.Drawing.Point(18, 91);
            this.dtp_ACD.Name = "dtp_ACD";
            this.dtp_ACD.Size = new System.Drawing.Size(305, 26);
            this.dtp_ACD.TabIndex = 4;
            // 
            // rtb_ACComment
            // 
            this.rtb_ACComment.Location = new System.Drawing.Point(531, 91);
            this.rtb_ACComment.Name = "rtb_ACComment";
            this.rtb_ACComment.Size = new System.Drawing.Size(570, 55);
            this.rtb_ACComment.TabIndex = 7;
            this.rtb_ACComment.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_CommentGroup);
            this.groupBox1.Controls.Add(this.rb_Ietmb);
            this.groupBox1.Controls.Add(this.rb_Iedb);
            this.groupBox1.Controls.Add(this.tbx_LessonComment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_AddComment);
            this.groupBox1.Controls.Add(this.cb_ACS);
            this.groupBox1.Controls.Add(this.rtb_ACComment);
            this.groupBox1.Controls.Add(this.dtp_ACD);
            this.groupBox1.Controls.Add(this.cb_ACC);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Comment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Group";
            // 
            // cb_CommentGroup
            // 
            this.cb_CommentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CommentGroup.FormattingEnabled = true;
            this.cb_CommentGroup.Location = new System.Drawing.Point(270, 35);
            this.cb_CommentGroup.MaxDropDownItems = 80;
            this.cb_CommentGroup.Name = "cb_CommentGroup";
            this.cb_CommentGroup.Size = new System.Drawing.Size(206, 27);
            this.cb_CommentGroup.TabIndex = 1;
            this.cb_CommentGroup.Click += new System.EventHandler(this.cb_CommentGroup_Click);
            // 
            // rb_Ietmb
            // 
            this.rb_Ietmb.AutoSize = true;
            this.rb_Ietmb.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rb_Ietmb.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_Ietmb.Location = new System.Drawing.Point(342, 117);
            this.rb_Ietmb.Name = "rb_Ietmb";
            this.rb_Ietmb.Size = new System.Drawing.Size(157, 27);
            this.rb_Ietmb.TabIndex = 6;
            this.rb_Ietmb.TabStop = true;
            this.rb_Ietmb.Text = "Not In Lesson";
            this.rb_Ietmb.UseVisualStyleBackColor = false;
            this.rb_Ietmb.CheckedChanged += new System.EventHandler(this.rb_Ietmb_CheckedChanged);
            // 
            // rb_Iedb
            // 
            this.rb_Iedb.AutoSize = true;
            this.rb_Iedb.BackColor = System.Drawing.Color.Turquoise;
            this.rb_Iedb.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_Iedb.Location = new System.Drawing.Point(342, 91);
            this.rb_Iedb.Name = "rb_Iedb";
            this.rb_Iedb.Size = new System.Drawing.Size(119, 27);
            this.rb_Iedb.TabIndex = 5;
            this.rb_Iedb.TabStop = true;
            this.rb_Iedb.Text = "In Lesson";
            this.rb_Iedb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Iedb.UseVisualStyleBackColor = false;
            this.rb_Iedb.CheckedChanged += new System.EventHandler(this.rb_Iedb_CheckedChanged);
            // 
            // tbx_LessonComment
            // 
            this.tbx_LessonComment.Location = new System.Drawing.Point(745, 35);
            this.tbx_LessonComment.Name = "tbx_LessonComment";
            this.tbx_LessonComment.Size = new System.Drawing.Size(356, 26);
            this.tbx_LessonComment.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lesson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Attendance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Comment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student";
            // 
            // btn_AddComment
            // 
            this.btn_AddComment.BackColor = System.Drawing.Color.Yellow;
            this.btn_AddComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddComment.Location = new System.Drawing.Point(1107, 82);
            this.btn_AddComment.Name = "btn_AddComment";
            this.btn_AddComment.Size = new System.Drawing.Size(117, 64);
            this.btn_AddComment.TabIndex = 8;
            this.btn_AddComment.Text = "ADD";
            this.btn_AddComment.UseVisualStyleBackColor = false;
            this.btn_AddComment.Click += new System.EventHandler(this.btn_AddComment_Click);
            // 
            // dgw_Comments
            // 
            this.dgw_Comments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Comments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Comments.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgw_Comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Comments.Location = new System.Drawing.Point(12, 168);
            this.dgw_Comments.Name = "dgw_Comments";
            this.dgw_Comments.RowTemplate.Height = 25;
            this.dgw_Comments.Size = new System.Drawing.Size(1230, 470);
            this.dgw_Comments.TabIndex = 6;
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1254, 640);
            this.Controls.Add(this.dgw_Comments);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CommentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommentForm";
            this.Load += new System.EventHandler(this.CommentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Comments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ACS;
        private System.Windows.Forms.ComboBox cb_ACC;
        private System.Windows.Forms.DateTimePicker dtp_ACD;
        private System.Windows.Forms.RichTextBox rtb_ACComment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddComment;
        private System.Windows.Forms.DataGridView dgw_Comments;
        private System.Windows.Forms.TextBox tbx_LessonComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_Ietmb;
        private System.Windows.Forms.RadioButton rb_Iedb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_CommentGroup;
    }
}