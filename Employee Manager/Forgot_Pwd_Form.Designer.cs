namespace Employee_Manager
{
    partial class Forgot_Pwd_Form
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
            this.emailTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.newPwdTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.sendCode_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.codeTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.pwd_notify = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.emailTB.Location = new System.Drawing.Point(61, 128);
            this.emailTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.emailTB.Name = "emailTB";
            this.emailTB.PasswordChar = '\0';
            this.emailTB.PlaceholderText = "Email";
            this.emailTB.SelectedText = "";
            this.emailTB.Size = new System.Drawing.Size(336, 46);
            this.emailTB.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 40);
            this.label3.TabIndex = 40;
            this.label3.Text = "Change account password";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(237, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 2);
            this.label2.TabIndex = 36;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BorderRadius = 19;
            this.confirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(17)))));
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(59, 455);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(336, 41);
            this.confirmBtn.TabIndex = 32;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // newPwdTB
            // 
            this.newPwdTB.BackColor = System.Drawing.Color.White;
            this.newPwdTB.BorderColor = System.Drawing.Color.DimGray;
            this.newPwdTB.BorderRadius = 8;
            this.newPwdTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPwdTB.DefaultText = "";
            this.newPwdTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPwdTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPwdTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPwdTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPwdTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPwdTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.newPwdTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPwdTB.Location = new System.Drawing.Point(61, 334);
            this.newPwdTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.newPwdTB.Name = "newPwdTB";
            this.newPwdTB.PasswordChar = '\0';
            this.newPwdTB.PlaceholderText = "New password";
            this.newPwdTB.SelectedText = "";
            this.newPwdTB.Size = new System.Drawing.Size(336, 46);
            this.newPwdTB.TabIndex = 42;
            this.newPwdTB.TextChanged += new System.EventHandler(this.newPwdTB_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.pwd_notify);
            this.guna2Panel1.Controls.Add(this.sendCode_Btn);
            this.guna2Panel1.Controls.Add(this.codeTB);
            this.guna2Panel1.Controls.Add(this.newPwdTB);
            this.guna2Panel1.Controls.Add(this.confirmBtn);
            this.guna2Panel1.Controls.Add(this.emailTB);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(176, 22);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(476, 555);
            this.guna2Panel1.TabIndex = 43;
            // 
            // sendCode_Btn
            // 
            this.sendCode_Btn.BorderRadius = 19;
            this.sendCode_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendCode_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendCode_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendCode_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendCode_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(17)))));
            this.sendCode_Btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.sendCode_Btn.ForeColor = System.Drawing.Color.White;
            this.sendCode_Btn.Location = new System.Drawing.Point(59, 197);
            this.sendCode_Btn.Name = "sendCode_Btn";
            this.sendCode_Btn.Size = new System.Drawing.Size(336, 41);
            this.sendCode_Btn.TabIndex = 44;
            this.sendCode_Btn.Text = "Send confirmation code";
            this.sendCode_Btn.Click += new System.EventHandler(this.sendCode_Btn_Click);
            // 
            // codeTB
            // 
            this.codeTB.BackColor = System.Drawing.Color.White;
            this.codeTB.BorderColor = System.Drawing.Color.DimGray;
            this.codeTB.BorderRadius = 8;
            this.codeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTB.DefaultText = "";
            this.codeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.codeTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeTB.Location = new System.Drawing.Point(59, 274);
            this.codeTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.codeTB.Name = "codeTB";
            this.codeTB.PasswordChar = '\0';
            this.codeTB.PlaceholderText = "Confirmation code";
            this.codeTB.SelectedText = "";
            this.codeTB.Size = new System.Drawing.Size(336, 46);
            this.codeTB.TabIndex = 43;
            // 
            // pwd_notify
            // 
            this.pwd_notify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_notify.ForeColor = System.Drawing.Color.IndianRed;
            this.pwd_notify.Location = new System.Drawing.Point(27, 385);
            this.pwd_notify.Name = "pwd_notify";
            this.pwd_notify.Size = new System.Drawing.Size(403, 32);
            this.pwd_notify.TabIndex = 45;
            this.pwd_notify.Text = "! Your password should have at least 8 characters, \r\ncontain at least 1 uppercase" +
    " and 1 number";
            this.pwd_notify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pwd_notify.Visible = false;
            // 
            // Forgot_Pwd_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(836, 629);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Forgot_Pwd_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change password";
            this.Load += new System.EventHandler(this.Forgot_Pwd_Form_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox emailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button confirmBtn;
        private Guna.UI2.WinForms.Guna2TextBox newPwdTB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button sendCode_Btn;
        private Guna.UI2.WinForms.Guna2TextBox codeTB;
        private System.Windows.Forms.Label pwd_notify;
    }
}