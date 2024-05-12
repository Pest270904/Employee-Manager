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
    public partial class ListEmployee_ChildForm : Form
    {
        private Userdata currentUser;

        public ListEmployee_ChildForm(Userdata user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {   
        }
    }
}
