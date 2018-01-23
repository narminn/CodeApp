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
    public partial class TeacherInfoForm : Form
    {
        public TeacherInfoForm()
        {
            InitializeComponent();
        }

        private void add_task_Click(object sender, EventArgs e)
        {
            TaskForm tskfrm = new TaskForm();
            tskfrm.ShowDialog();
        }
    }
}
