using Employee_Manager.Main_forms;
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
    public partial class AdminChat_ChildForm : Form
    {
        private Userdata currentUser;

        public AdminChat_ChildForm(Userdata user)
        {
            InitializeComponent();
            this.currentUser = user;
        }
        private void AdminChat_ChildForm_Load(object sender, EventArgs e)
        {

        }
    }
}
