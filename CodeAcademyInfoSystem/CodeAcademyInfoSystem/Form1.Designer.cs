namespace CodeAcademyInfoSystem
{
    partial class Form1
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
            this.email = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wrong = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pswrd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.email.Location = new System.Drawing.Point(75, 21);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(324, 37);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Gold;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_btn.Location = new System.Drawing.Point(75, 139);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(324, 35);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CodeAcademyInfoSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // wrong
            // 
            this.wrong.AutoSize = true;
            this.wrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.wrong.ForeColor = System.Drawing.Color.Red;
            this.wrong.Location = new System.Drawing.Point(102, 179);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(322, 17);
            this.wrong.TabIndex = 3;
            this.wrong.Text = "Your email or password is wrong, Please try again";
            this.wrong.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CodeAcademyInfoSystem.Properties.Resources.if_87_111095;
            this.pictureBox2.Location = new System.Drawing.Point(362, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CodeAcademyInfoSystem.Properties.Resources.if_icons_password_1564520;
            this.pictureBox3.Location = new System.Drawing.Point(362, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pswrd
            // 
            this.pswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.pswrd.Location = new System.Drawing.Point(75, 73);
            this.pswrd.Multiline = true;
            this.pswrd.Name = "pswrd";
            this.pswrd.Size = new System.Drawing.Size(324, 37);
            this.pswrd.TabIndex = 2;
            this.pswrd.Text = "Password";
            this.pswrd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.password);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.pswrd);
            this.panel1.Controls.Add(this.email);
            this.panel1.Location = new System.Drawing.Point(105, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 211);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::CodeAcademyInfoSystem.Properties.Resources.gradient_24;
            this.ClientSize = new System.Drawing.Size(665, 480);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "wa2q";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label wrong;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox pswrd;
        private System.Windows.Forms.Panel panel1;
    }
}

