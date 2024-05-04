using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Text.RegularExpressions;


namespace Employee_Manager
{
    public partial class Signup_Form : Form
    {
        private bool username = false;
        private bool email = false;
        private bool pwd = false;
        private bool pwd2 = false;

        public Signup_Form()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Za2NHhoGe0Af8NERiHM1lRVyonuESkRsuypN1WS2",
            BasePath = "https://test-59665-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private async void signupBtn_ClickAsync(object sender, EventArgs e)
        {
            if(username && email && pwd && pwd2)
            {
                if (string.IsNullOrEmpty(usernameTB.Text) || string.IsNullOrEmpty(emailTB.Text) || string.IsNullOrEmpty(nameTB.Text) || string.IsNullOrEmpty(passwordTB.Text))
                    MessageBox.Show("Please fill all fields!");
                else
                {
                    var dataLayer = new Data
                    {
                        username = usernameTB.Text,
                        email = emailTB.Text,
                        name = nameTB.Text,
                        password = passwordTB.Text,
                    };

                    SetResponse resp = await client.SetTaskAsync("users/" + usernameTB.Text, dataLayer);
                    Data result = resp.ResultAs<Data>();
                    MessageBox.Show("Signup completed!");

                    this.Close();
                }
            }
        }


        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(usernameTB.Text, "^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$").Success)
            {
                username = true;
                username_notify.Visible = false;
            }
            else
            {
                username = false;
                username_notify.Visible = true;
            }

        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(emailTB.Text, "^[\\w\\.-]+@[a-zA-Z\\d\\.-]+\\.[a-zA-Z]{2,}$").Success)
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

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(passwordTB.Text, "^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d).{8,}$").Success)
            {
                pwd = true;
                pwd_notify.Visible = false;
            }
            else
            {
                pwd = false;
                pwd_notify.Visible = true;
            }
        }

        private void password2TB_TextChanged(object sender, EventArgs e)
        {
            if (passwordTB.Text != password2TB.Text)
            {
                pwd2 = false;
                pwd2_notify.Visible = true;
            }
            else
            {
                pwd2 = true;
                pwd2_notify.Visible = false;
            }
        }

        private void Signup_Form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
