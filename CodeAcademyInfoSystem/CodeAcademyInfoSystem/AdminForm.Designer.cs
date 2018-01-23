namespace CodeAcademyInfoSystem
{
    partial class AdminForm
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
            this.add_teacher_btn = new System.Windows.Forms.Button();
            this.add_mentor_btn = new System.Windows.Forms.Button();
            this.add_group_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_teacher_btn
            // 
            this.add_teacher_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.add_teacher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_teacher_btn.Location = new System.Drawing.Point(78, 163);
            this.add_teacher_btn.Name = "add_teacher_btn";
            this.add_teacher_btn.Size = new System.Drawing.Size(509, 92);
            this.add_teacher_btn.TabIndex = 0;
            this.add_teacher_btn.Text = "Add Teacher";
            this.add_teacher_btn.UseVisualStyleBackColor = false;
            this.add_teacher_btn.Click += new System.EventHandler(this.add_teacher_btn_Click);
            // 
            // add_mentor_btn
            // 
            this.add_mentor_btn.BackColor = System.Drawing.Color.Red;
            this.add_mentor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_mentor_btn.Location = new System.Drawing.Point(78, 274);
            this.add_mentor_btn.Name = "add_mentor_btn";
            this.add_mentor_btn.Size = new System.Drawing.Size(509, 92);
            this.add_mentor_btn.TabIndex = 1;
            this.add_mentor_btn.Text = "Add Mentor";
            this.add_mentor_btn.UseVisualStyleBackColor = false;
            this.add_mentor_btn.Click += new System.EventHandler(this.add_mentor_btn_Click);
            // 
            // add_group_btn
            // 
            this.add_group_btn.BackColor = System.Drawing.Color.Yellow;
            this.add_group_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_group_btn.Location = new System.Drawing.Point(78, 384);
            this.add_group_btn.Name = "add_group_btn";
            this.add_group_btn.Size = new System.Drawing.Size(509, 92);
            this.add_group_btn.TabIndex = 2;
            this.add_group_btn.Text = "Add Group";
            this.add_group_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CodeAcademyInfoSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 145);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add_group_btn);
            this.Controls.Add(this.add_mentor_btn);
            this.Controls.Add(this.add_teacher_btn);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_teacher_btn;
        private System.Windows.Forms.Button add_mentor_btn;
        private System.Windows.Forms.Button add_group_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}