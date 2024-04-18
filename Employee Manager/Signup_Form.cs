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


namespace Employee_Manager
{
    public partial class Signup_Form : Form
    {
        public Signup_Form()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "i1jWD1zLnzcJlgIHpv9RzPlOARWduP997qTV8rIM",
            BasePath = "https://employee-management-f8bdf-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;




        private async void signupBtn_ClickAsync(object sender, EventArgs e)
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
            MessageBox.Show("User" + usernameTB.Text + " is registered");

            this.Close();
        }


        private void usernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) {
                lblConnectionStatusTest.Text = "Connected";
            }
        }
    }
}
