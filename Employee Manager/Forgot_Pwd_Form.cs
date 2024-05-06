using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Employee_Manager
{
    public partial class Forgot_Pwd_Form : Form
    {
        private int code;
        private const string p = "whbvvszmdfkqxrce";
        private bool pwd = false;

        private string sentEmail;
        private string username;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Za2NHhoGe0Af8NERiHM1lRVyonuESkRsuypN1WS2",
            BasePath = "https://test-59665-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public Forgot_Pwd_Form()
        {
            Random rnd = new Random();
            code = rnd.Next(100000, 999999);
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(newPwdTB.Text))
                MessageBox.Show("Please fill all fields");
            else if (pwd)
            {
                int input_code = int.Parse(codeTB.Text);
                if (input_code == code)
                {
                    SetResponse response = client.Set("users/" + username + "/password", newPwdTB.Text);

                    MessageBox.Show("Password changed succesfully!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid confirmation code!");
                }
            }
        }

        private void sendCode_Btn_Click(object sender, EventArgs e)
        {
            sentEmail = emailTB.Text;

            bool found = false;
            FirebaseResponse resp = client.Get("users/");
            Dictionary<string, Data> result = resp.ResultAs<Dictionary<string, Data>>();

            foreach (var user in result)
            {
                if(sentEmail == user.Value.email)
                {
                    username = user.Value.username;
                    found = true;
                    break; 
                }
            }

            if (found)
            {
                MailMessage message = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();

                message.From = new MailAddress("ntpllc2k4@gmail.com");
                message.To.Add(new MailAddress(emailTB.Text));
                message.Subject = "Change password";
                message.Body = "Your code " + code;

                smtpClient.Port = 587;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("ntpllc2k4@gmail.com", p);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(message);

                MessageBox.Show("Email sent, please check your email");
            }
            else
            {
                MessageBox.Show("Invalid email, please try again");
            }

        }

        private void newPwdTB_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(newPwdTB.Text, "^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d).{8,}$").Success)
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

        private void Forgot_Pwd_Form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
