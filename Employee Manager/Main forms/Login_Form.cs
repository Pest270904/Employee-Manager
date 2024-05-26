using Employee_Manager.Admin;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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

        // client for firebase - config from FirebaseSetup.cs
        private IFirebaseClient client;

        private Userdata currentUser = new Userdata();

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Check xem có điền username password
            if (string.IsNullOrEmpty(usernameTB.Text) || string.IsNullOrEmpty(passwordTB.Text))
            {
                MessageBox.Show("Please fill all fields!!");
            }
            else
            {
                //Biến để check xem người dùng có tồn tại
                bool found = false;

                //Truy xuất database
                FirebaseResponse resp = client.Get("users/");
                Dictionary<string, Data> result = resp.ResultAs<Dictionary<string, Data>>();

                //Truy xuất thông tin
                foreach (var get in result)
                {
                    string usernameRes = get.Value.username;
                    string passwordRes = get.Value.password;

                    //Check nếu username và pass tồn tại
                    if (usernameTB.Text == usernameRes && passwordTB.Text == passwordRes)
                    {
                        currentUser.username = usernameRes;
                        currentUser.email = get.Value.email;
                        currentUser.name = get.Value.name;
                        found = true;
                        break; 
                    }
                }

                //Nếu tồn tại thì đưa về home
                if (found)
                {
                    if (currentUser.username == "admin")
                    {
                        Admin_Main form = new Admin_Main(currentUser);
                        Hide();
                        form.ShowDialog();
                        Close();
                    }
                    else
                    {
                        Main_Form form = new Main_Form(currentUser);
                        Hide();
                        form.ShowDialog();
                        Close();
                    }
                }
                //Không thì hiện message box cảnh báo
                else
                {
                    MessageBox.Show("Username or Password might be wrong!!");
                }
            }
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

        private void Login_Form_Load(object sender, EventArgs e)
        {
            client = FirebaseSetup.InitializeFirebase();
        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
