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
using FireSharp.Response;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Manager.Main_forms
{
    public partial class Signup_Confirm_Form : Form
    {
        public bool ConfirmationAccepted { get; private set; }

        private string email;
        private int code;
        private const string p = "whbvvszmdfkqxrce";

        public Signup_Confirm_Form(string email)
        {
            InitializeComponent();
            this.email = email;

            emailLabel.Text = MaskEmail(email);

            Random rnd = new Random();
            code = rnd.Next(100000, 999999);
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            // Set confirmation result to false and close the form
            ConfirmationAccepted = false;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int input_code = int.Parse(confirmTB.Text);
            
            if (input_code == code)
            {
                ConfirmationAccepted = true;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid confirmation code!");
            }
        }

        private void Signup_Confirm_Form_Load(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();

            message.From = new MailAddress("ntpllc2k4@gmail.com");
            message.To.Add(new MailAddress(email));
            message.Subject = "Signup confirmation";
            message.Body = "Here is your confirmation code to finish signup: " + code;

            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("ntpllc2k4@gmail.com", p);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(message);
        }

        // Individual functions
        static string MaskEmail(string email)
        {
            // Split the email address into username and domain parts
            string[] parts = email.Split('@');
            string username = parts[0];
            string domain = parts[1];

            // Mask the username
            string maskedUsername = MaskString(username);

            // Reconstruct the masked email address
            return maskedUsername + "@" + domain;
        }

        static string MaskString(string input)
        {
            int lengthToKeepVisible = 2;
            string maskedString = input.Substring(0, lengthToKeepVisible);
            for (int i = lengthToKeepVisible; i < input.Length; i++)
            {
                maskedString += "*";
            }
            return maskedString;
        }
    }
}
