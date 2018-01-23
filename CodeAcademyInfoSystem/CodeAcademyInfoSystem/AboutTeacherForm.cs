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
    public partial class AboutTeacherForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Teacher selectedAboutTeacher;
        public AboutTeacherForm()
        {
            InitializeComponent();
        }

        private void AboutTeacherForm_Load(object sender, EventArgs e)
        {
            fillDataAboutTeacher();
        }
        private void fillDataAboutTeacher()
        {
            dataGridAboutTeacher.Rows.Clear();
            int i = 0;
            List<Teacher> tchr_list = db.Teachers.ToList();
            foreach (Teacher item in tchr_list)
            {
                dataGridAboutTeacher.Rows.Add();
                dataGridAboutTeacher.Rows[i].Cells[0].Value = item.id;
                dataGridAboutTeacher.Rows[i].Cells[1].Value = item.teacher_name;
                dataGridAboutTeacher.Rows[i].Cells[2].Value = item.teacher_surname;
                dataGridAboutTeacher.Rows[i].Cells[3].Value = item.Gender.gender_name;
                dataGridAboutTeacher.Rows[i].Cells[4].Value = item.teacher_phone;
                dataGridAboutTeacher.Rows[i].Cells[5].Value = item.teacher_email;
                dataGridAboutTeacher.Rows[i].Cells[6].Value = item.teacher_info;
                i++;
            }
        }
       

        private void select_about_teacher(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridAboutTeacher.Rows[e.RowIndex].Cells[0].Value);
            selectedAboutTeacher = db.Teachers.Find(id);
        }

        private void profile_teacher_Click(object sender, EventArgs e)
        {
            TeacherInfoForm tchInfo = new TeacherInfoForm();
            tchInfo.label_t_name.Text = selectedAboutTeacher.teacher_name;
            tchInfo.label_t_surname.Text = selectedAboutTeacher.teacher_surname;
            tchInfo.label_t_gender.Text = selectedAboutTeacher.Gender.gender_name;
            tchInfo.label_t_phone.Text = selectedAboutTeacher.teacher_phone;
            tchInfo.label_t_email.Text = selectedAboutTeacher.teacher_email;
            tchInfo.label_t_info.Text = selectedAboutTeacher.teacher_info;
            Image image = Image.FromFile(@"C:\Users\Dr.Rashad\Desktop\Forza_N_R\CodeAcademyInfoSystem\CodeAcademyInfoSystem\Upload\" + selectedAboutTeacher.teacher_photo);
            tchInfo.pictureBoxTeacher.Image = image;
            tchInfo.ShowDialog();
        }
    }
}
