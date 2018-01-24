using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademyInfoSystem
{
    public partial class AddStudent : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        OpenFileDialog img = new OpenFileDialog();

        private Student selectedStudent;
        public AddStudent()
        {
            InitializeComponent();

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Groups.ToList())
            {
                s_group_id.Items.Add(item.group_name);
            }
            foreach (var item in db.Genders.ToList())
            {
                s_gender_id.Items.Add(item.gender_name);
            }
            fillDataStudents();
        }
        private void browse_std_Click(object sender, EventArgs e)
        {
            img.ShowDialog();
            this.pictureBoxStudent.Image = Image.FromFile(img.FileName);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string imageName = DateTime.Now.ToString("yyyyMMddssHHmm") + img.SafeFileName;
            WebClient webclient = new WebClient();
            string path = @"C:\Users\Dr.Rashad\Desktop\Forza_N_R\CodeAcademyInfoSystem\CodeAcademyInfoSystem\Upload\" + imageName;
            webclient.DownloadFile(img.FileName, path);
            int group_id = db.Groups.Where(g => g.group_name == s_group_id.Text).First().id;
            int gender_id = db.Genders.Where(g => g.gender_name == s_gender_id.Text).First().id;
            Student std = new Student();
            std.student_surname = s_surname.Text;
            std.student_name = s_name.Text;
            std.student_email = s_email.Text;
            std.student_phone = s_phone.Text;
            std.student_github_account = s_github_account.Text;
            std.student_info = s_info.Text;
            std.student_photo = pictureBoxStudent.Text;
            std.student_cap_point = Convert.ToDouble((s_cap_point).Text);
            std.student_group_id = group_id;
            std.student_gender_id = gender_id;
            std.student_password = s_password.Text;
            std.student_photo = imageName;
            db.Students.Add(std);
            db.SaveChanges();
            fillDataStudents();

        }
        private void fillDataStudents()
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            List<Student> std_list = db.Students.ToList();
            foreach (Student item in std_list)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = item.id;
                dataGridView1.Rows[i].Cells[1].Value = item.student_surname;
                dataGridView1.Rows[i].Cells[2].Value = item.student_name;
                dataGridView1.Rows[i].Cells[3].Value = item.Gender.gender_name;
                dataGridView1.Rows[i].Cells[4].Value = item.Group.group_name;
                dataGridView1.Rows[i].Cells[5].Value = item.student_phone;
                dataGridView1.Rows[i].Cells[6].Value = item.student_email;
                dataGridView1.Rows[i].Cells[7].Value = item.student_github_account;
                dataGridView1.Rows[i].Cells[8].Value = item.student_cap_point;
                dataGridView1.Rows[i].Cells[9].Value = item.student_info;
                i++;
            }
        }

        private void s_student(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            selectedStudent = db.Students.Find(id);
            s_surname.Text = selectedStudent.student_surname;
            s_name.Text = selectedStudent.student_name;
            s_email.Text = selectedStudent.student_email;
            s_phone.Text = selectedStudent.student_phone;
            s_github_account.Text = selectedStudent.student_github_account;
            s_info.Text = selectedStudent.student_info;
            pictureBoxStudent.Text = selectedStudent.student_photo;
            s_cap_point.Text = selectedStudent.student_cap_point.ToString();
            s_group_id.Text = selectedStudent.Group.group_name;
            s_gender_id.Text = selectedStudent.Gender.gender_name;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int group_id = db.Groups.Where(g => g.group_name == s_group_id.Text).First().id;
            int gender_id = db.Genders.Where(g => g.gender_name == s_gender_id.Text).First().id;

            selectedStudent.student_surname = s_surname.Text;
            selectedStudent.student_name = s_name.Text;
            selectedStudent.student_email = s_email.Text;
            selectedStudent.student_phone = s_phone.Text;
            selectedStudent.student_github_account = s_github_account.Text;
            selectedStudent.student_info = s_info.Text;
            selectedStudent.student_photo = pictureBoxStudent.Text;
            selectedStudent.student_cap_point =Convert.ToDouble(s_cap_point.Text);
            selectedStudent.student_group_id = group_id;
            selectedStudent.student_gender_id = gender_id;
            selectedStudent.student_password = s_password.Text;

            db.SaveChanges();
            fillDataStudents();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            db.Students.Remove(selectedStudent);
            db.SaveChanges();
            fillDataStudents();
        }

        private void std_profile_Click(object sender, EventArgs e)
        {
            StudentInfoForm stdInfo = new StudentInfoForm();
            stdInfo.label_s_name.Text = selectedStudent.student_name;
            stdInfo.label_s_surname.Text = selectedStudent.student_surname;
            stdInfo.label_s_gender.Text = selectedStudent.Gender.gender_name;
            stdInfo.label_s_phone.Text = selectedStudent.student_phone;
            stdInfo.label_s_email.Text = selectedStudent.student_email;
            stdInfo.label_s_info.Text = selectedStudent.student_info;
            stdInfo.label_s_github.Text = selectedStudent.student_github_account;
            stdInfo.label_s_group.Text = selectedStudent.Group.group_name;
            stdInfo.label_s_point.Text = selectedStudent.student_cap_point.ToString();
            Image image = Image.FromFile(@"C:\Users\Dr.Rashad\Desktop\Forza_N_R\CodeAcademyInfoSystem\CodeAcademyInfoSystem\Upload\" + selectedStudent.student_photo);
            stdInfo.pictureBoxStd.Image = image;
            stdInfo.ShowDialog();
        }
    }
}
