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
    public partial class AboutMentorForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Mentor selectedMentor;
        public AboutMentorForm()
        {
            InitializeComponent();
        }

        private void AboutMentorForm_Load(object sender, EventArgs e)
        {
            fillDataAboutMentor();
        }
        private void fillDataAboutMentor()
        {
            dataGridAboutMentor.Rows.Clear();
            int i = 0;
            List<Mentor> mnt_list = db.Mentors.ToList();
            foreach (Mentor item in mnt_list)
            {
                dataGridAboutMentor.Rows.Add();
                dataGridAboutMentor.Rows[i].Cells[0].Value = item.id;
                dataGridAboutMentor.Rows[i].Cells[1].Value = item.mentor_name;
                dataGridAboutMentor.Rows[i].Cells[2].Value = item.mentor_surname;
                dataGridAboutMentor.Rows[i].Cells[3].Value = item.Gender.gender_name;
                dataGridAboutMentor.Rows[i].Cells[4].Value = item.mentor_phone;
                dataGridAboutMentor.Rows[i].Cells[5].Value = item.mentor_email;
                dataGridAboutMentor.Rows[i].Cells[6].Value = item.mentor_info;
                i++;
            }
        }

       

        private void select_about_mentor(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridAboutMentor.Rows[e.RowIndex].Cells[0].Value);
            selectedMentor = db.Mentors.Find(id);
        }
        private void profile_mentor_Click(object sender, EventArgs e)
        {
            MentorInfoform mntInfo = new MentorInfoform();
            mntInfo.label_m_name.Text = selectedMentor.mentor_name;
            mntInfo.label_m_surname.Text = selectedMentor.mentor_surname;
            mntInfo.label_m_gender.Text = selectedMentor.Gender.gender_name;
            mntInfo.label_m_phone.Text = selectedMentor.mentor_phone;
            mntInfo.label_m_email.Text = selectedMentor.mentor_email;
            mntInfo.label_m_info.Text = selectedMentor.mentor_info;
            Image image = Image.FromFile(@"C:\Users\Dr.Rashad\Desktop\Forza_N_R\CodeAcademyInfoSystem\CodeAcademyInfoSystem\Upload\" + selectedMentor.mentor_photo);
            mntInfo.pictureBoxMentor.Image = image;
            mntInfo.ShowDialog();
        }
    }
}
