using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Manager.Child_Forms
{
    public partial class Profile_ChildForm : Form
    {
        // client for firebase - config from FirebaseSetup.cs
        private IFirebaseClient client;

        private Userdata currentUser;

        private bool email = false;

        public Profile_ChildForm(Userdata user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(email)
                {
                    FirebaseResponse resp = client.Get("users/");
                    Dictionary<string, Data> result = resp.ResultAs<Dictionary<string, Data>>();

                    foreach (var get in result)
                    {
                        //Check nếu username và pass tồn tại
                        if (currentUser.username == get.Value.username)
                        {
                            if(passwordTB.Text == get.Value.password)
                            {
                                SetResponse nameRes = client.Set("users/" + currentUser.username + "/name", nameTB.Text);
                                SetResponse emailRes = client.Set("users/" + currentUser.username + "/email", emailTB.Text);
                                MessageBox.Show("Change information sucessfully.");
                            }
                            else
                            {
                                MessageBox.Show("Wrong password, please enter correct password!");
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }

        }

        private void Profile_ChildForm_Load(object sender, EventArgs e)
        {
            username_label.Text = currentUser.username;

            client = FirebaseSetup.InitializeFirebase();

            FirebaseResponse resp = client.Get("users/" + currentUser.username + "/");
            Userdata res = resp.ResultAs<Userdata>();

            nameTB.Text = res.name;
            emailTB.Text = res.email;
        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(emailTB.Text, "^[\\w\\.-]+@[a-zA-Z\\d\\.-]+\\.[a-zA-Z]{2,}$").Success && !String.IsNullOrEmpty(emailTB.Text))
            {
                email = true;
                email_notify.Visible = false;
            }
            else
            {
                email = false;
                email_notify.Visible = true;
            }
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            Forgot_Pwd_Form form = new Forgot_Pwd_Form();
            form.ShowDialog();
        }
    }
}
