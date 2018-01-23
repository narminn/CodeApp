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
    public partial class Form1 : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            
            if (email.Text == "admin" && pswrd.Text == "admin")
            {
               
                AdminForm admfrm = new AdminForm();
                admfrm.ShowDialog();
                
            }
            else
            {
                wrong.Visible = true;
            }
        }

       

        private void password(object sender, KeyEventArgs e)
        {
            pswrd.PasswordChar = '*';
        }
    }
}
