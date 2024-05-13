namespace Employee_Manager.Main_forms
{
    partial class Signup_Confirm_Form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.confirmTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.back_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "We have sent confirmation code to your email:                                    " +
    "            \r\nplease check your email.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // confirmTB
            // 
            this.confirmTB.BackColor = System.Drawing.Color.White;
            this.confirmTB.BorderColor = System.Drawing.Color.DimGray;
            this.confirmTB.BorderRadius = 19;
            this.confirmTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmTB.DefaultText = "";
            this.confirmTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.confirmTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmTB.Location = new System.Drawing.Point(146, 86);
            this.confirmTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.confirmTB.Name = "confirmTB";
            this.confirmTB.PasswordChar = '\0';
            this.confirmTB.PlaceholderText = "confirmation code";
            this.confirmTB.SelectedText = "";
            this.confirmTB.Size = new System.Drawing.Size(336, 46);
            this.confirmTB.TabIndex = 14;
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
            this.confirmBtn.Location = new System.Drawing.Point(305, 167);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(156, 41);
            this.confirmBtn.TabIndex = 15;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // back_Btn
            // 
            this.back_Btn.BorderRadius = 19;
            this.back_Btn.BorderThickness = 1;
            this.back_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.back_Btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.back_Btn.ForeColor = System.Drawing.Color.White;
            this.back_Btn.Location = new System.Drawing.Point(151, 167);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(119, 39);
            this.back_Btn.TabIndex = 19;
            this.back_Btn.Text = "Go Back";
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.emailLabel);
            this.guna2Panel1.Controls.Add(this.confirmTB);
            this.guna2Panel1.Controls.Add(this.back_Btn);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.confirmBtn);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(92, 54);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(600, 241);
            this.guna2Panel1.TabIndex = 21;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(371, 22);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(182, 18);
            this.emailLabel.TabIndex = 20;
            this.emailLabel.Text = "ex*********@gmail.com";
            // 
            // Signup_Confirm_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Signup_Confirm_Form";
            this.Text = "Login_Confirm_Form";
            this.Load += new System.EventHandler(this.Signup_Confirm_Form_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox confirmTB;
        private Guna.UI2.WinForms.Guna2Button confirmBtn;
        private Guna.UI2.WinForms.Guna2Button back_Btn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label emailLabel;
    }
}