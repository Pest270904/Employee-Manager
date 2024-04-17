using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void forgotPwdBtn_Click(object sender, EventArgs e)
        {
            Forgot_Pwd_Form form = new Forgot_Pwd_Form();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            Signup_Form form = new Signup_Form();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
