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
    public partial class AddStudent : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
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
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            int group_id = db.Groups.Where(g => g.group_name == s_group_id.Text).First().id;
            int gender_id = db.Genders.Where(g => g.gender_name == s_gender_id.Text).First().id;
            Student std = new Student();
            std.student_surname = s_surname.Text;
            std.student_name = s_name.Text;
            std.student_email = s_email.Text;
            std.student_phone = s_phone.Text;
            std.student_github_account = s_github_account.Text;
            std.student_info = s_info.Text;
            std.student_photo = pictureBox1.Text;
            std.student_cap_point = Convert.ToDouble((s_cap_point).Text);
            std.student_group_id = group_id;
            std.student_gender_id = gender_id;
            std.student_password = s_password.Text;
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
                dataGridView1.Rows[i].Cells[3].Value = item.student_phone;
                dataGridView1.Rows[i].Cells[4].Value = item.student_github_account;
                dataGridView1.Rows[i].Cells[5].Value = item.student_info;
                dataGridView1.Rows[i].Cells[5].Value = item.student_photo;
                dataGridView1.Rows[i].Cells[5].Value = item.student_cap_point;
                dataGridView1.Rows[i].Cells[5].Value = item.student_group_id;
                dataGridView1.Rows[i].Cells[5].Value = item.student_gender_id;
                dataGridView1.Rows[i].Cells[5].Value = item.student_password;
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
            pictureBox1.Text = selectedStudent.student_photo;
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
            selectedStudent.student_photo = pictureBox1.Text;
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

        
    }
}
