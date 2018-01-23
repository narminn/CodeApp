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

    public partial class AddGroupForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        public AddGroupForm()
        {
            InitializeComponent();
        }

        

        private void AddGroupForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
