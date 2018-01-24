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
    public partial class AboutStudentsForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Student selectedAboutStd;
        public AboutStudentsForm()
        {
            InitializeComponent();
        }

        private void AboutStudentsForm_Load(object sender, EventArgs e)
        {
            fillDataAboutStudent();
        }
        private void fillDataAboutStudent()
        {
            dataGridAboutStd.Rows.Clear();
            int i = 0;
            List<Student> std_list = db.Students.ToList();
            foreach (Student item in std_list)
            {
                dataGridAboutStd.Rows.Add();
                dataGridAboutStd.Rows[i].Cells[0].Value = item.id;
                dataGridAboutStd.Rows[i].Cells[1].Value = item.student_surname;
                dataGridAboutStd.Rows[i].Cells[2].Value = item.student_name;
                dataGridAboutStd.Rows[i].Cells[3].Value = item.Gender.gender_name;
                dataGridAboutStd.Rows[i].Cells[4].Value = item.Group.group_name;
                dataGridAboutStd.Rows[i].Cells[5].Value = item.student_phone;
                dataGridAboutStd.Rows[i].Cells[6].Value = item.student_email;
                dataGridAboutStd.Rows[i].Cells[7].Value = item.student_github_account;
                dataGridAboutStd.Rows[i].Cells[8].Value = item.student_cap_point;
                dataGridAboutStd.Rows[i].Cells[9].Value = item.student_info;
                i++;
            }
        }

        

        private void select_about_std(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridAboutStd.Rows[e.RowIndex].Cells[0].Value);
            selectedAboutStd = db.Students.Find(id);
        }
        private void about_std_profile_Click(object sender, EventArgs e)
        {
            StudentInfoForm stdInfo = new StudentInfoForm();
            stdInfo.label_s_name.Text = selectedAboutStd.student_name;
            stdInfo.label_s_surname.Text = selectedAboutStd.student_surname;
            stdInfo.label_s_gender.Text = selectedAboutStd.Gender.gender_name;
            stdInfo.label_s_phone.Text = selectedAboutStd.student_phone;
            stdInfo.label_s_email.Text = selectedAboutStd.student_email;
            stdInfo.label_s_info.Text = selectedAboutStd.student_info;
            stdInfo.label_s_github.Text = selectedAboutStd.student_github_account;
            stdInfo.label_s_group.Text = selectedAboutStd.Group.group_name;
            stdInfo.label_s_point.Text = selectedAboutStd.student_cap_point.ToString();
            Image image = Image.FromFile(@"C:\Users\Dr.Rashad\Desktop\Forza_N_R\CodeAcademyInfoSystem\CodeAcademyInfoSystem\Upload\" + selectedAboutStd.student_photo);
            stdInfo.pictureBoxStd.Image = image;
            stdInfo.ShowDialog();
        }
    }
}
