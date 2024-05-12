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
        private Userdata currentUser;

        public Logout_Form(Userdata user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Main_Form frm = new Main_Form(currentUser);
            frm.ShowDialog();
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
