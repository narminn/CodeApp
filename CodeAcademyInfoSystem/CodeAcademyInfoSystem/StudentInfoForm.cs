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
    public partial class StudentInfoForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Task selectedTask;
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void tasks_Click(object sender, EventArgs e)
        {
            TaskPointsForm tskpnt = new TaskPointsForm();

            int tId = db.Tasks.Where(t =>t.Student.student_name==label_s_name.Text).First().id;
            selectedTask = db.Tasks.Find(tId);
            tskpnt.dataGridTaskPnt.Rows.Clear();
            int i = 0;
            List<Task> tsk_list = db.Tasks.ToList();
            foreach (Task selectedTask in tsk_list)
            {
                tskpnt.dataGridTaskPnt.Rows.Add();
                tskpnt.dataGridTaskPnt.Rows[i].Cells[0].Value = selectedTask.id;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[1].Value = selectedTask.Task_types.task_type_name;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[2].Value = selectedTask.task_start_date;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[3].Value = selectedTask.task_end_date;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[4].Value = selectedTask.task_source;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[5].Value = selectedTask.task_point;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[6].Value = selectedTask.task_note;
            }
                tskpnt.ShowDialog();
            
        }
        

    }
}
