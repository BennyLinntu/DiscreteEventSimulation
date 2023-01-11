using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R10546039YDLINAss05
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(tbname.Text == "r10546039" && tbpassword.Text == "r10546039")
            {
                MainForm m = new MainForm();
                m.Show();
                this.Hide();
            }
            else if (tbname.Text == "R10546039" && tbpassword.Text == "r10546039")
            {
                MainForm m = new MainForm();
                m.Show();
                this.Hide();
            }
            else if (tbname.Text == "r10546039" && tbpassword.Text == "R10546039")
            {
                MainForm m = new MainForm();
                m.Show();
                this.Hide();
            }
            else if (tbname.Text == "R10546039" && tbpassword.Text == "R10546039")
            {
                MainForm m = new MainForm();
                m.Show();
                this.Hide();
            }
            else if (tbname.Text == "" && tbpassword.Text == "")
            {
                MainForm m = new MainForm();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username: r10546039 and password: r10546039, Case sensitive!");
            }
            
        }


    }
}
