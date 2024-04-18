namespace Employee_Manager
{
    partial class Signup_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.signupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.password2TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblConnectionStatusTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(231, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 2);
            this.label2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 40);
            this.label1.TabIndex = 24;
            this.label1.Text = "E.M.S";
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.Color.White;
            this.usernameTB.BorderColor = System.Drawing.Color.DimGray;
            this.usernameTB.BorderRadius = 8;
            this.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTB.DefaultText = "";
            this.usernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.usernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.Location = new System.Drawing.Point(231, 147);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.PasswordChar = '\0';
            this.usernameTB.PlaceholderText = "Username";
            this.usernameTB.SelectedText = "";
            this.usernameTB.Size = new System.Drawing.Size(336, 46);
            this.usernameTB.TabIndex = 22;
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            // 
            // signupBtn
            // 
            this.signupBtn.BorderRadius = 19;
            this.signupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signupBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(17)))));
            this.signupBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(231, 529);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(336, 41);
            this.signupBtn.TabIndex = 20;
            this.signupBtn.Text = "Sign up";
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_ClickAsync);
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.White;
            this.nameTB.BorderColor = System.Drawing.Color.DimGray;
            this.nameTB.BorderRadius = 8;
            this.nameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTB.DefaultText = "";
            this.nameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.nameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.Location = new System.Drawing.Point(231, 285);
            this.nameTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nameTB.Name = "nameTB";
            this.nameTB.PasswordChar = '\0';
            this.nameTB.PlaceholderText = "Name";
            this.nameTB.SelectedText = "";
            this.nameTB.Size = new System.Drawing.Size(336, 46);
            this.nameTB.TabIndex = 27;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.BorderColor = System.Drawing.Color.DimGray;
            this.passwordTB.BorderRadius = 8;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultText = "";
            this.passwordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Location = new System.Drawing.Point(231, 356);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '\0';
            this.passwordTB.PlaceholderText = "Password";
            this.passwordTB.SelectedText = "";
            this.passwordTB.Size = new System.Drawing.Size(336, 46);
            this.passwordTB.TabIndex = 28;
            // 
            // password2TB
            // 
            this.password2TB.BackColor = System.Drawing.Color.White;
            this.password2TB.BorderColor = System.Drawing.Color.DimGray;
            this.password2TB.BorderRadius = 8;
            this.password2TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password2TB.DefaultText = "";
            this.password2TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password2TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password2TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password2TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password2TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password2TB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.password2TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password2TB.Location = new System.Drawing.Point(231, 426);
            this.password2TB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.password2TB.Name = "password2TB";
            this.password2TB.PasswordChar = '\0';
            this.password2TB.PlaceholderText = "Enter password again";
            this.password2TB.SelectedText = "";
            this.password2TB.Size = new System.Drawing.Size(336, 46);
            this.password2TB.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 40);
            this.label3.TabIndex = 30;
            this.label3.Text = "Create your account";
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.Color.White;
            this.emailTB.BorderColor = System.Drawing.Color.DimGray;
            this.emailTB.BorderRadius = 8;
            this.emailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTB.DefaultText = "";
            this.emailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.emailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTB.Location = new System.Drawing.Point(231, 213);
            this.emailTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.emailTB.Name = "emailTB";
            this.emailTB.PasswordChar = '\0';
            this.emailTB.PlaceholderText = "Email";
            this.emailTB.SelectedText = "";
            this.emailTB.Size = new System.Drawing.Size(336, 46);
            this.emailTB.TabIndex = 31;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(162, 22);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(485, 586);
            this.guna2Panel1.TabIndex = 32;
            // 
            // lblConnectionStatusTest
            // 
            this.lblConnectionStatusTest.AutoSize = true;
            this.lblConnectionStatusTest.Location = new System.Drawing.Point(691, 47);
            this.lblConnectionStatusTest.Name = "lblConnectionStatusTest";
            this.lblConnectionStatusTest.Size = new System.Drawing.Size(92, 16);
            this.lblConnectionStatusTest.TabIndex = 33;
            this.lblConnectionStatusTest.Text = "connect status";
            // 
            // Signup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(824, 632);
            this.Controls.Add(this.lblConnectionStatusTest);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password2TB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Signup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox usernameTB;
        private Guna.UI2.WinForms.Guna2Button signupBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameTB;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Guna.UI2.WinForms.Guna2TextBox password2TB;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox emailTB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblConnectionStatusTest;
    }
}