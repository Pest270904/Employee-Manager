namespace Employee_Manager.Child_Forms
{
    partial class Profile_ChildForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.confirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.username_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.email_notify = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changePwdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(86, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 73;
            this.label14.Text = "Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(86, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 25);
            this.label12.TabIndex = 71;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(368, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 69;
            this.label11.Text = "Username:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BorderRadius = 19;
            this.confirmBtn.BorderThickness = 1;
            this.confirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(231, 420);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(146, 47);
            this.confirmBtn.TabIndex = 61;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.username_label.Location = new System.Drawing.Point(494, 80);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(172, 25);
            this.username_label.TabIndex = 67;
            this.username_label.Text = "username_Label";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(86, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 65;
            this.label8.Text = "Name: ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(49, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(850, 2);
            this.label6.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(49, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(850, 2);
            this.label5.TabIndex = 62;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(160, 160);
            this.guna2ImageButton2.Image = global::Employee_Manager.Properties.Resources.user_profile1;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(160, 160);
            this.guna2ImageButton2.Location = new System.Drawing.Point(119, 12);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(160, 160);
            this.guna2ImageButton2.Size = new System.Drawing.Size(167, 149);
            this.guna2ImageButton2.TabIndex = 64;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(217, 281);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(280, 30);
            this.nameTB.TabIndex = 75;
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(217, 209);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(280, 30);
            this.emailTB.TabIndex = 76;
            this.emailTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            // 
            // passwordTB
            // 
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultText = "";
            this.passwordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTB.ForeColor = System.Drawing.Color.Gray;
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Location = new System.Drawing.Point(217, 361);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.passwordTB.PlaceholderText = "****************";
            this.passwordTB.SelectedText = "";
            this.passwordTB.Size = new System.Drawing.Size(280, 30);
            this.passwordTB.TabIndex = 77;
            // 
            // email_notify
            // 
            this.email_notify.AutoSize = true;
            this.email_notify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_notify.ForeColor = System.Drawing.Color.IndianRed;
            this.email_notify.Location = new System.Drawing.Point(525, 216);
            this.email_notify.Name = "email_notify";
            this.email_notify.Size = new System.Drawing.Size(250, 16);
            this.email_notify.TabIndex = 78;
            this.email_notify.Text = "! Your email should be a legit email";
            this.email_notify.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "(Enter your password to change your infomation)";
            // 
            // changePwdBtn
            // 
            this.changePwdBtn.BorderRadius = 19;
            this.changePwdBtn.BorderThickness = 1;
            this.changePwdBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePwdBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePwdBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePwdBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePwdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.changePwdBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.changePwdBtn.ForeColor = System.Drawing.Color.White;
            this.changePwdBtn.Location = new System.Drawing.Point(499, 420);
            this.changePwdBtn.Name = "changePwdBtn";
            this.changePwdBtn.Size = new System.Drawing.Size(189, 47);
            this.changePwdBtn.TabIndex = 80;
            this.changePwdBtn.Text = "Change password";
            this.changePwdBtn.Click += new System.EventHandler(this.changePwdBtn_Click);
            // 
            // Profile_ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 553);
            this.Controls.Add(this.changePwdBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_notify);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Profile_ChildForm";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.Profile_ChildForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button confirmBtn;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox emailTB;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private System.Windows.Forms.Label email_notify;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button changePwdBtn;
    }
}