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

        private void button3_Click(object sender, EventArgs e)
        {
            AddGroupForm add_group = new AddGroupForm();
            add_group.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStudent add_student = new AddStudent();
            add_student.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacherForm t = new AddTeacherForm();
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMentorForm m = new AddMentorForm();
            m.ShowDialog();
        }
    }
}
