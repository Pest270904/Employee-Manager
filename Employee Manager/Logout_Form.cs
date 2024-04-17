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
        public Logout_Form()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form frm = new Login_Form();
            frm.ShowDialog();
        }
    }
}
