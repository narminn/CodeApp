namespace CodeAcademyInfoSystem
{
    partial class AboutStudentsForm
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
            this.dataGridAboutStd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.about_std_profile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAboutStd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAboutStd
            // 
            this.dataGridAboutStd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAboutStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAboutStd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column9,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6});
            this.dataGridAboutStd.Location = new System.Drawing.Point(25, 21);
            this.dataGridAboutStd.Name = "dataGridAboutStd";
            this.dataGridAboutStd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridAboutStd.Size = new System.Drawing.Size(821, 401);
            this.dataGridAboutStd.TabIndex = 28;
            this.dataGridAboutStd.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_about_std);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Student Surname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Student Name";
            this.Column3.Name = "Column3";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Student Gender ";
            this.Column10.Name = "Column10";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Student Group Name";
            this.Column9.Name = "Column9";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Student Phone";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Student Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Student Github Account";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Student Cap Point";
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Student Info";
            this.Column6.Name = "Column6";
            // 
            // about_std_profile
            // 
            this.about_std_profile.Location = new System.Drawing.Point(379, 471);
            this.about_std_profile.Name = "about_std_profile";
            this.about_std_profile.Size = new System.Drawing.Size(75, 23);
            this.about_std_profile.TabIndex = 30;
            this.about_std_profile.Text = "Profile";
            this.about_std_profile.UseVisualStyleBackColor = true;
            this.about_std_profile.Click += new System.EventHandler(this.about_std_profile_Click);
            // 
            // AboutStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.about_std_profile);
            this.Controls.Add(this.dataGridAboutStd);
            this.Name = "AboutStudentsForm";
            this.Text = "AboutStudentsForm";
            this.Load += new System.EventHandler(this.AboutStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAboutStd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAboutStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button about_std_profile;
    }
}