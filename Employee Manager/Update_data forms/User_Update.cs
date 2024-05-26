using Employee_Manager.Others;
using FireSharp.Extensions;
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

namespace Employee_Manager.Update_data_forms
{
    public partial class User_Update : Form
    {
        private string username;

        private IFirebaseClient client;

        Userdata result;

        private bool email = false;

        public User_Update(string username)
        {
            client = FirebaseSetup.InitializeFirebase();
            this.username = username;

            FirebaseResponse resp = client.Get("users/" + username + "/");
            result = resp.ResultAs<Userdata>();

            InitializeComponent();
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (email)
                {
                    FirebaseResponse resp = client.Get("users/");
                    Dictionary<string, Data> result = resp.ResultAs<Dictionary<string, Data>>();

                    foreach (var get in result)
                    {
                        //Check nếu username tồn tại
                        if (username == get.Value.username)
                        {
                            SetResponse nameRes = client.Set("users/" + username + "/name", fullnameTB.Text);
                            SetResponse emailRes = client.Set("users/" + username + "/email", emailTB.Text);
                            SetResponse pwdRes = client.Set("users/" + username + "/password", pwdTB.Text);
                            MessageBox.Show("Change information sucessfully.");

                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void User_Update_Load(object sender, EventArgs e)
        {
            usernameTB.Text = result.username;
            emailTB.Text = result.email;
            pwdTB.Text = result.password;
            fullnameTB.Text = result.name;
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
    }
}
