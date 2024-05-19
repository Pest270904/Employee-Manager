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
    public partial class Chat_ChildForm : Form
    {
        private Userdata currentUser;

        public Chat_ChildForm(Userdata user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void Chat_ChildForm_Load(object sender, EventArgs e)
        {

        }
    }
}
