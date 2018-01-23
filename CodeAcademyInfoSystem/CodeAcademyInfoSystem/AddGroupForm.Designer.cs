namespace CodeAcademyInfoSystem
{
    partial class AddGroupForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.g_name = new System.Windows.Forms.TextBox();
            this.g_add_btn = new System.Windows.Forms.Button();
            this.t_update_btn = new System.Windows.Forms.Button();
            this.t_delete_btn = new System.Windows.Forms.Button();
            this.g_type = new System.Windows.Forms.ComboBox();
            this.g_teacher = new System.Windows.Forms.ComboBox();
            this.g_mentor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.g_start_data = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Group Mentor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group Start Date";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // g_name
            // 
            this.g_name.Location = new System.Drawing.Point(145, 27);
            this.g_name.Name = "g_name";
            this.g_name.Size = new System.Drawing.Size(121, 20);
            this.g_name.TabIndex = 8;
            // 
            // g_add_btn
            // 
            this.g_add_btn.Location = new System.Drawing.Point(57, 215);
            this.g_add_btn.Name = "g_add_btn";
            this.g_add_btn.Size = new System.Drawing.Size(75, 23);
            this.g_add_btn.TabIndex = 12;
            this.g_add_btn.Text = "Add";
            this.g_add_btn.UseVisualStyleBackColor = true;
            this.g_add_btn.Click += new System.EventHandler(this.g_add_btn_Click);
            // 
            // t_update_btn
            // 
            this.t_update_btn.Location = new System.Drawing.Point(153, 215);
            this.t_update_btn.Name = "t_update_btn";
            this.t_update_btn.Size = new System.Drawing.Size(75, 23);
            this.t_update_btn.TabIndex = 13;
            this.t_update_btn.Text = "Update";
            this.t_update_btn.UseVisualStyleBackColor = true;
            this.t_update_btn.Click += new System.EventHandler(this.t_update_btn_Click);
            // 
            // t_delete_btn
            // 
            this.t_delete_btn.Location = new System.Drawing.Point(248, 215);
            this.t_delete_btn.Name = "t_delete_btn";
            this.t_delete_btn.Size = new System.Drawing.Size(75, 23);
            this.t_delete_btn.TabIndex = 14;
            this.t_delete_btn.Text = "Delete";
            this.t_delete_btn.UseVisualStyleBackColor = true;
            this.t_delete_btn.Click += new System.EventHandler(this.t_delete_btn_Click);
            // 
            // g_type
            // 
            this.g_type.FormattingEnabled = true;
            this.g_type.Location = new System.Drawing.Point(145, 53);
            this.g_type.Name = "g_type";
            this.g_type.Size = new System.Drawing.Size(121, 21);
            this.g_type.TabIndex = 15;
            // 
            // g_teacher
            // 
            this.g_teacher.FormattingEnabled = true;
            this.g_teacher.Location = new System.Drawing.Point(145, 91);
            this.g_teacher.Name = "g_teacher";
            this.g_teacher.Size = new System.Drawing.Size(121, 21);
            this.g_teacher.TabIndex = 16;
            // 
            // g_mentor
            // 
            this.g_mentor.FormattingEnabled = true;
            this.g_mentor.Location = new System.Drawing.Point(145, 121);
            this.g_mentor.Name = "g_mentor";
            this.g_mentor.Size = new System.Drawing.Size(121, 21);
            this.g_mentor.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_group);
            // 
            // g_start_data
            // 
            this.g_start_data.Location = new System.Drawing.Point(145, 150);
            this.g_start_data.Name = "g_start_data";
            this.g_start_data.Size = new System.Drawing.Size(200, 20);
            this.g_start_data.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Group Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Group Type";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Group Teacher";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Group Mentor";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Group Start Date";
            this.Column6.Name = "Column6";
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.g_start_data);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.g_mentor);
            this.Controls.Add(this.g_teacher);
            this.Controls.Add(this.g_type);
            this.Controls.Add(this.t_delete_btn);
            this.Controls.Add(this.t_update_btn);
            this.Controls.Add(this.g_add_btn);
            this.Controls.Add(this.g_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddGroupForm";
            this.Text = "AddGroupForm";
            this.Load += new System.EventHandler(this.AddGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox g_name;
        private System.Windows.Forms.Button g_add_btn;
        private System.Windows.Forms.Button t_update_btn;
        private System.Windows.Forms.Button t_delete_btn;
        private System.Windows.Forms.ComboBox g_type;
        private System.Windows.Forms.ComboBox g_teacher;
        private System.Windows.Forms.ComboBox g_mentor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker g_start_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}