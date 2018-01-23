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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void add_teacher_btn_Click(object sender, EventArgs e)
        {
            AddTeacherForm add_teacher = new AddTeacherForm();
            add_teacher.ShowDialog();
        }

        private void add_mentor_btn_Click(object sender, EventArgs e)
        {
            AddMentorForm add_mentor = new AddMentorForm();
            add_mentor.ShowDialog();
        }
    }
}
