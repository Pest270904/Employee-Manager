﻿namespace Employee_Manager
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
            this.signup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forgotPwdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.BackColor = System.Drawing.Color.White;
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(437, 425);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(64, 18);
            this.signup.TabIndex = 28;
            this.signup.Text = "Sign up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Don\'t have an account?\r\n";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(236, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 2);
            this.label2.TabIndex = 26;
            // 
            // forgotPwdBtn
            // 
            this.forgotPwdBtn.BackColor = System.Drawing.Color.White;
            this.forgotPwdBtn.BorderRadius = 19;
            this.forgotPwdBtn.BorderThickness = 1;
            this.forgotPwdBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.forgotPwdBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.forgotPwdBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.forgotPwdBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.forgotPwdBtn.FillColor = System.Drawing.Color.Transparent;
            this.forgotPwdBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.forgotPwdBtn.ForeColor = System.Drawing.Color.Black;
            this.forgotPwdBtn.Location = new System.Drawing.Point(398, 330);
            this.forgotPwdBtn.Name = "forgotPwdBtn";
            this.forgotPwdBtn.Size = new System.Drawing.Size(175, 41);
            this.forgotPwdBtn.TabIndex = 25;
            this.forgotPwdBtn.Text = "Forgot password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Login to E.M.S";
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.BorderColor = System.Drawing.Color.DimGray;
            this.passwordTB.BorderRadius = 19;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultText = "";
            this.passwordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Location = new System.Drawing.Point(236, 259);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '\0';
            this.passwordTB.PlaceholderText = "**********";
            this.passwordTB.SelectedText = "";
            this.passwordTB.Size = new System.Drawing.Size(336, 46);
            this.passwordTB.TabIndex = 23;
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.Color.White;
            this.usernameTB.BorderColor = System.Drawing.Color.DimGray;
            this.usernameTB.BorderRadius = 19;
            this.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTB.DefaultText = "";
            this.usernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.usernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.Location = new System.Drawing.Point(236, 191);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.PasswordChar = '\0';
            this.usernameTB.PlaceholderText = "username";
            this.usernameTB.SelectedText = "";
            this.usernameTB.Size = new System.Drawing.Size(336, 46);
            this.usernameTB.TabIndex = 22;
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 19;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(17)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(236, 330);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(156, 41);
            this.loginBtn.TabIndex = 20;
            this.loginBtn.Text = "Login";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(162, 29);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(485, 462);
            this.guna2TextBox1.TabIndex = 21;
            this.guna2TextBox1.WordWrap = false;
            // 
            // Signup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(824, 547);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.forgotPwdBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.guna2TextBox1);
            this.Name = "Signup_Form";
            this.Text = "Signup_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button forgotPwdBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Guna.UI2.WinForms.Guna2TextBox usernameTB;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}