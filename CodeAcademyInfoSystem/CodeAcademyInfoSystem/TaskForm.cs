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
    public partial class TaskForm : Form
       
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Task selectedTask;
        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Task_types)
            {
                task_type.Items.Add(item.task_type_name);
            }
            foreach (var item in db.Groups)
            {
                task_group.Items.Add(item.group_name);
            }
            foreach (var item in db.Students)

            {
                task_stdt.Items.Add(item.student_name);
            }
            fillDataTasks();
        }

        private void add_task_btn_Click(object sender, EventArgs e)
        {
            int tsk_type_id = db.Task_types.Where(t => t.task_type_name == task_type.Text).First().id;
            int tsk_group_id = db.Groups.Where(g => g.group_name == task_group.Text).First().id;
            int tsk_student_id = db.Students.Where(s => s.student_name == task_stdt.Text).First().id;
            Task tsk = new Task();
            tsk.task_type_id = tsk_type_id;
            tsk.task_start_date = dateTimeStart.Value;
            tsk.task_end_date = dateTimeEnd.Value;
            tsk.task_group_id = tsk_group_id;
            tsk.task_student_id = tsk_student_id;
            tsk.task_source = task_src.Text;
            tsk.task_point=Convert.ToDouble(task_pnt.Text);
            tsk.task_note = task_note.Text;
            db.Tasks.Add(tsk);
            db.SaveChanges();
            fillDataTasks();

        }
        private void fillDataTasks()
        {
            dataGridTask.Rows.Clear();
            int i = 0;
            List<Task> tsk_list = db.Tasks.ToList();
            foreach (Task item in tsk_list)
            {
                dataGridTask.Rows.Add();
                dataGridTask.Rows[i].Cells[0].Value = item.id;
                dataGridTask.Rows[i].Cells[1].Value = item.Task_types.task_type_name;
                dataGridTask.Rows[i].Cells[2].Value = item.task_start_date;
                dataGridTask.Rows[i].Cells[3].Value = item.task_end_date;
                dataGridTask.Rows[i].Cells[4].Value = item.task_source;
                dataGridTask.Rows[i].Cells[5].Value = item.Group.group_name;
                dataGridTask.Rows[i].Cells[6].Value = item.Student.student_name;
                dataGridTask.Rows[i].Cells[7].Value = item.task_point;
                dataGridTask.Rows[i].Cells[8].Value = item.task_note;
                i++;
            }
        }

        private void select_task(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridTask.Rows[e.RowIndex].Cells[0].Value);
            selectedTask = db.Tasks.Find(id);
            task_type.Text = selectedTask.Task_types.task_type_name;
            dateTimeStart.Value = selectedTask.task_start_date;
            dateTimeEnd.Value = selectedTask.task_end_date;
            task_group.Text = selectedTask.Group.group_name;
            task_stdt.Text = selectedTask.Student.student_name;
            task_src.Text = selectedTask.task_source;
            task_pnt.Text = selectedTask.task_point.ToString();
            task_note.Text = selectedTask.task_note;

        }

      

        private void task_update_Click(object sender, EventArgs e)
        {
            int tsk_type_id = db.Task_types.Where(t => t.task_type_name == task_type.Text).First().id;
            int tsk_group_id = db.Groups.Where(g => g.group_name == task_group.Text).First().id;
            int tsk_student_id = db.Students.Where(s => s.student_name == task_stdt.Text).First().id;
            
            selectedTask.task_type_id = tsk_type_id;
            selectedTask.task_start_date = dateTimeStart.Value;
            selectedTask.task_end_date = dateTimeEnd.Value;
            selectedTask.task_group_id = tsk_group_id;
            selectedTask.task_student_id = tsk_student_id;
            selectedTask.task_source = task_src.Text;
            selectedTask.task_point = Convert.ToDouble(task_pnt.Text);
            selectedTask.task_note = task_note.Text;
            
            db.SaveChanges();
            fillDataTasks();
        }

        private void task_delete_Click(object sender, EventArgs e)
        {
            db.Tasks.Remove(selectedTask);
            db.SaveChanges();
            fillDataTasks();
        }

       

        private void about_mentor_Click(object sender, EventArgs e)
        {
            AboutMentorForm abtmntfrm = new AboutMentorForm();
            abtmntfrm.ShowDialog();
        }

        private void about_student_Click(object sender, EventArgs e)
        {
            AboutStudentsForm abtstdfrm = new AboutStudentsForm();
            abtstdfrm.ShowDialog();
        }

        private void about_group_Click(object sender, EventArgs e)
        {
            AboutGroupsForm abtgrpfrm = new AboutGroupsForm();
            abtgrpfrm.ShowDialog();
        }
    }
}
