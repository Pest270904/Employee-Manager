using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager.Child_Forms
{
    public partial class Logout_Form : Form
    {
        private string username;

        public Logout_Form(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Main_Form frm = new Main_Form(username);
            frm.ShowDialog();
            this.Close();
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            Login_Form frm = new Login_Form();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
