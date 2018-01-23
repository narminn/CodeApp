namespace CodeAcademyInfoSystem
{
    partial class AddTeacherForm
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
            this.t_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_info = new System.Windows.Forms.TextBox();
            this.t_surname = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_phone = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.dataGridTeacher = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_show_btn = new System.Windows.Forms.Button();
            this.t_add_btn = new System.Windows.Forms.Button();
            this.t_delete_btn = new System.Windows.Forms.Button();
            this.t_update_btn = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(94, 25);
            this.t_name.Multiline = true;
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(213, 27);
            this.t_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // t_gender
            // 
            this.t_gender.FormattingEnabled = true;
            this.t_gender.Location = new System.Drawing.Point(94, 137);
            this.t_gender.Name = "t_gender";
            this.t_gender.Size = new System.Drawing.Size(176, 21);
            this.t_gender.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(381, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(381, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(381, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Info";
            // 
            // t_info
            // 
            this.t_info.Location = new System.Drawing.Point(94, 189);
            this.t_info.Multiline = true;
            this.t_info.Name = "t_info";
            this.t_info.Size = new System.Drawing.Size(366, 66);
            this.t_info.TabIndex = 13;
            // 
            // t_surname
            // 
            this.t_surname.Location = new System.Drawing.Point(94, 76);
            this.t_surname.Multiline = true;
            this.t_surname.Name = "t_surname";
            this.t_surname.Size = new System.Drawing.Size(211, 27);
            this.t_surname.TabIndex = 19;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(459, 76);
            this.t_email.Multiline = true;
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(213, 27);
            this.t_email.TabIndex = 20;
            // 
            // t_phone
            // 
            this.t_phone.Location = new System.Drawing.Point(459, 25);
            this.t_phone.Multiline = true;
            this.t_phone.Name = "t_phone";
            this.t_phone.Size = new System.Drawing.Size(213, 27);
            this.t_phone.TabIndex = 21;
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(459, 137);
            this.t_password.Multiline = true;
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(213, 27);
            this.t_password.TabIndex = 22;
            // 
            // dataGridTeacher
            // 
            this.dataGridTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTeacher.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column6});
            this.dataGridTeacher.Location = new System.Drawing.Point(28, 295);
            this.dataGridTeacher.Name = "dataGridTeacher";
            this.dataGridTeacher.Size = new System.Drawing.Size(844, 221);
            this.dataGridTeacher.TabIndex = 23;
            this.dataGridTeacher.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_teacher);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Gender";
            this.Column7.Name = "Column7";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Info";
            this.Column6.Name = "Column6";
            // 
            // t_show_btn
            // 
            this.t_show_btn.Location = new System.Drawing.Point(24, 522);
            this.t_show_btn.Name = "t_show_btn";
            this.t_show_btn.Size = new System.Drawing.Size(116, 27);
            this.t_show_btn.TabIndex = 24;
            this.t_show_btn.Text = "Profile";
            this.t_show_btn.UseVisualStyleBackColor = true;
            this.t_show_btn.Click += new System.EventHandler(this.t_show_btn_Click);
            // 
            // t_add_btn
            // 
            this.t_add_btn.Location = new System.Drawing.Point(594, 221);
            this.t_add_btn.Name = "t_add_btn";
            this.t_add_btn.Size = new System.Drawing.Size(172, 34);
            this.t_add_btn.TabIndex = 25;
            this.t_add_btn.Text = "Add";
            this.t_add_btn.UseVisualStyleBackColor = true;
            this.t_add_btn.Click += new System.EventHandler(this.t_add_btn_Click);
            // 
            // t_delete_btn
            // 
            this.t_delete_btn.Location = new System.Drawing.Point(749, 522);
            this.t_delete_btn.Name = "t_delete_btn";
            this.t_delete_btn.Size = new System.Drawing.Size(123, 27);
            this.t_delete_btn.TabIndex = 26;
            this.t_delete_btn.Text = "Delete";
            this.t_delete_btn.UseVisualStyleBackColor = true;
            this.t_delete_btn.Click += new System.EventHandler(this.t_delete_btn_Click);
            // 
            // t_update_btn
            // 
            this.t_update_btn.Location = new System.Drawing.Point(394, 522);
            this.t_update_btn.Name = "t_update_btn";
            this.t_update_btn.Size = new System.Drawing.Size(130, 27);
            this.t_update_btn.TabIndex = 27;
            this.t_update_btn.Text = "Update";
            this.t_update_btn.UseVisualStyleBackColor = true;
            this.t_update_btn.Click += new System.EventHandler(this.t_update_btn_Click);
            // 
            // browse
            // 
            this.browse.AutoSize = true;
            this.browse.ForeColor = System.Drawing.SystemColors.Highlight;
            this.browse.Location = new System.Drawing.Point(715, 189);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(51, 13);
            this.browse.TabIndex = 29;
            this.browse.Text = "Browse...";
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(718, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.t_update_btn);
            this.Controls.Add(this.t_delete_btn);
            this.Controls.Add(this.t_add_btn);
            this.Controls.Add(this.t_show_btn);
            this.Controls.Add(this.dataGridTeacher);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_phone);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_surname);
            this.Controls.Add(this.t_info);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.label1);
            this.Name = "AddTeacherForm";
            this.Text = "AddTeacherForm";
            this.Load += new System.EventHandler(this.AddTeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox t_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_info;
        private System.Windows.Forms.TextBox t_surname;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_phone;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.DataGridView dataGridTeacher;
        private System.Windows.Forms.Button t_show_btn;
        private System.Windows.Forms.Button t_add_btn;
        private System.Windows.Forms.Button t_delete_btn;
        private System.Windows.Forms.Button t_update_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label browse;
    }
}