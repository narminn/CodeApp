using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademyInfoSystem
{
    public partial class Form1 : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Mentor selectedMntr;
        private Teacher selectedTchr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var tech = db.Teachers.FirstOrDefault(t => t.teacher_email == email.Text && t.teacher_password == pswrd.Text);
            var mntr = db.Mentors.FirstOrDefault(m => m.mentor_email == email.Text && m.mentor_password == pswrd.Text);
            if (email.Text == "admin" && pswrd.Text == "admin")
            {
                AdminForm admfrm = new AdminForm();
                admfrm.ShowDialog();
            }
            else if (tech != null)
            {
                int tchId = db.Teachers.Where(c => c.teacher_email == email.Text).First().id;
                selectedTchr = db.Teachers.Find(tchId);
                TeacherInfoForm tchInfo = new TeacherInfoForm();
                tchInfo.label_t_name.Text = selectedTchr.teacher_name;
                tchInfo.label_t_surname.Text = selectedTchr.teacher_surname;
                tchInfo.label_t_gender.Text = selectedTchr.Gender.gender_name;
                tchInfo.label_t_phone.Text = selectedTchr.teacher_phone;
                tchInfo.label_t_email.Text = selectedTchr.teacher_email;
                tchInfo.label_t_info.Text = selectedTchr.teacher_info;
                Image image = Image.FromFile(@"C:\Users\Dr.Rashad\Desktop\Forza_N_R\CodeAcademyInfoSystem\CodeAcademyInfoSystem\Upload\" + selectedTchr.teacher_photo);
                tchInfo.pictureBoxTeacher.Image = image;
                tchInfo.add_task.Visible = true;
                tchInfo.ShowDialog();
                //TaskForm tskfrm = new TaskForm();
                //tskfrm.ShowDialog();
            }
            else if (mntr != null)
            {
                int mntId = db.Mentors.Where(n => n.mentor_email == email.Text).First().id;
                selectedMntr = db.Mentors.Find(mntId);
                MentorInfoform mntInfo = new MentorInfoform();
                mntInfo.label_m_name.Text = selectedMntr.mentor_name;
                mntInfo.label_m_surname.Text = selectedMntr.mentor_surname;
                mntInfo.label_m_gender.Text = selectedMntr.Gender.gender_name;
                mntInfo.label_m_phone.Text = selectedMntr.mentor_phone;
                mntInfo.label_m_email.Text = selectedMntr.mentor_email;
                mntInfo.label_m_info.Text = selectedMntr.mentor_info;
                Image image = Image.FromFile(@"C:\Users\Dr.Rashad\Desktop\Forza_N_R\CodeAcademyInfoSystem\CodeAcademyInfoSystem\Upload\" + selectedMntr.mentor_photo);
                mntInfo.pictureBoxMentor.Image = image;
                mntInfo.ShowDialog();
            }
            else
            {
                wrong.Visible = true;
            }




            //if (email.Text == item.mentor_email && pswrd.Text == item.mentor_password)
            //{
            //    MessageBox.Show("hi");
            //}



        }



        private void password(object sender, KeyEventArgs e)
        {
            pswrd.PasswordChar = '*';
        }
    }
}
