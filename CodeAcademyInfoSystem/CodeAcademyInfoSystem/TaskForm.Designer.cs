namespace CodeAcademyInfoSystem
{
    partial class TaskForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.task_note = new System.Windows.Forms.TextBox();
            this.task_src = new System.Windows.Forms.TextBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.task_group = new System.Windows.Forms.ComboBox();
            this.task_stdt = new System.Windows.Forms.ComboBox();
            this.task_pnt = new System.Windows.Forms.TextBox();
            this.add_task_btn = new System.Windows.Forms.Button();
            this.dataGridTask = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_delete = new System.Windows.Forms.Button();
            this.task_update = new System.Windows.Forms.Button();
            this.task_type = new System.Windows.Forms.ComboBox();
            this.about_mentor = new System.Windows.Forms.Label();
            this.about_student = new System.Windows.Forms.Label();
            this.about_group = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTask)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start  Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(712, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Point";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(712, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Note";
            // 
            // task_note
            // 
            this.task_note.Location = new System.Drawing.Point(611, 129);
            this.task_note.Multiline = true;
            this.task_note.Name = "task_note";
            this.task_note.Size = new System.Drawing.Size(257, 133);
            this.task_note.TabIndex = 33;
            // 
            // task_src
            // 
            this.task_src.Location = new System.Drawing.Point(462, 43);
            this.task_src.Multiline = true;
            this.task_src.Name = "task_src";
            this.task_src.Size = new System.Drawing.Size(213, 27);
            this.task_src.TabIndex = 34;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(123, 97);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(213, 20);
            this.dateTimeStart.TabIndex = 35;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(123, 165);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(213, 20);
            this.dateTimeEnd.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Task Source";
            // 
            // task_group
            // 
            this.task_group.FormattingEnabled = true;
            this.task_group.Location = new System.Drawing.Point(462, 100);
            this.task_group.Name = "task_group";
            this.task_group.Size = new System.Drawing.Size(121, 21);
            this.task_group.TabIndex = 38;
            // 
            // task_stdt
            // 
            this.task_stdt.FormattingEnabled = true;
            this.task_stdt.Location = new System.Drawing.Point(462, 163);
            this.task_stdt.Name = "task_stdt";
            this.task_stdt.Size = new System.Drawing.Size(121, 21);
            this.task_stdt.TabIndex = 39;
            // 
            // task_pnt
            // 
            this.task_pnt.Location = new System.Drawing.Point(768, 32);
            this.task_pnt.Multiline = true;
            this.task_pnt.Name = "task_pnt";
            this.task_pnt.Size = new System.Drawing.Size(100, 47);
            this.task_pnt.TabIndex = 40;
            // 
            // add_task_btn
            // 
            this.add_task_btn.Location = new System.Drawing.Point(344, 235);
            this.add_task_btn.Name = "add_task_btn";
            this.add_task_btn.Size = new System.Drawing.Size(150, 47);
            this.add_task_btn.TabIndex = 41;
            this.add_task_btn.Text = "Add";
            this.add_task_btn.UseVisualStyleBackColor = true;
            this.add_task_btn.Click += new System.EventHandler(this.add_task_btn_Click);
            // 
            // dataGridTask
            // 
            this.dataGridTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridTask.Location = new System.Drawing.Point(24, 288);
            this.dataGridTask.Name = "dataGridTask";
            this.dataGridTask.Size = new System.Drawing.Size(844, 221);
            this.dataGridTask.TabIndex = 42;
            this.dataGridTask.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_task);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Task Type";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Start Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "End Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Task Source";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Group";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Student";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Point";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Note";
            this.Column9.Name = "Column9";
            // 
            // task_delete
            // 
            this.task_delete.Location = new System.Drawing.Point(752, 522);
            this.task_delete.Name = "task_delete";
            this.task_delete.Size = new System.Drawing.Size(116, 27);
            this.task_delete.TabIndex = 47;
            this.task_delete.Text = "Delete";
            this.task_delete.UseVisualStyleBackColor = true;
            this.task_delete.Click += new System.EventHandler(this.task_delete_Click);
            // 
            // task_update
            // 
            this.task_update.Location = new System.Drawing.Point(26, 522);
            this.task_update.Name = "task_update";
            this.task_update.Size = new System.Drawing.Size(116, 27);
            this.task_update.TabIndex = 48;
            this.task_update.Text = "Update";
            this.task_update.UseVisualStyleBackColor = true;
            this.task_update.Click += new System.EventHandler(this.task_update_Click);
            // 
            // task_type
            // 
            this.task_type.FormattingEnabled = true;
            this.task_type.Location = new System.Drawing.Point(123, 45);
            this.task_type.Name = "task_type";
            this.task_type.Size = new System.Drawing.Size(213, 21);
            this.task_type.TabIndex = 49;
            // 
            // about_mentor
            // 
            this.about_mentor.AutoSize = true;
            this.about_mentor.Location = new System.Drawing.Point(23, 9);
            this.about_mentor.Name = "about_mentor";
            this.about_mentor.Size = new System.Drawing.Size(79, 13);
            this.about_mentor.TabIndex = 51;
            this.about_mentor.Text = "About Mentors ";
            this.about_mentor.Click += new System.EventHandler(this.about_mentor_Click);
            // 
            // about_student
            // 
            this.about_student.AutoSize = true;
            this.about_student.Location = new System.Drawing.Point(371, 9);
            this.about_student.Name = "about_student";
            this.about_student.Size = new System.Drawing.Size(80, 13);
            this.about_student.TabIndex = 52;
            this.about_student.Text = "About Students";
            this.about_student.Click += new System.EventHandler(this.about_student_Click);
            // 
            // about_group
            // 
            this.about_group.AutoSize = true;
            this.about_group.Location = new System.Drawing.Point(765, 9);
            this.about_group.Name = "about_group";
            this.about_group.Size = new System.Drawing.Size(72, 13);
            this.about_group.TabIndex = 53;
            this.about_group.Text = "About Groups";
            this.about_group.Click += new System.EventHandler(this.about_group_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.about_group);
            this.Controls.Add(this.about_student);
            this.Controls.Add(this.about_mentor);
            this.Controls.Add(this.task_type);
            this.Controls.Add(this.task_update);
            this.Controls.Add(this.task_delete);
            this.Controls.Add(this.dataGridTask);
            this.Controls.Add(this.add_task_btn);
            this.Controls.Add(this.task_pnt);
            this.Controls.Add(this.task_stdt);
            this.Controls.Add(this.task_group);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.task_src);
            this.Controls.Add(this.task_note);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox task_note;
        private System.Windows.Forms.TextBox task_src;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox task_group;
        private System.Windows.Forms.ComboBox task_stdt;
        private System.Windows.Forms.TextBox task_pnt;
        private System.Windows.Forms.Button add_task_btn;
        private System.Windows.Forms.DataGridView dataGridTask;
        private System.Windows.Forms.Button task_delete;
        private System.Windows.Forms.Button task_update;
        private System.Windows.Forms.ComboBox task_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label about_mentor;
        private System.Windows.Forms.Label about_student;
        private System.Windows.Forms.Label about_group;
    }
}