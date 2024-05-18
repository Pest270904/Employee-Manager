namespace Employee_Manager.Child_Forms
{
    partial class Client
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
            this.lvMess = new System.Windows.Forms.ListView();
            this.tboxMess = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernamlable = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lvMess
            // 
            this.lvMess.HideSelection = false;
            this.lvMess.Location = new System.Drawing.Point(42, 44);
            this.lvMess.Name = "lvMess";
            this.lvMess.Size = new System.Drawing.Size(479, 221);
            this.lvMess.TabIndex = 74;
            this.lvMess.UseCompatibleStateImageBehavior = false;
            // 
            // tboxMess
            // 
            this.tboxMess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxMess.DefaultText = "";
            this.tboxMess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxMess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxMess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxMess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxMess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxMess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxMess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxMess.Location = new System.Drawing.Point(51, 361);
            this.tboxMess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxMess.Name = "tboxMess";
            this.tboxMess.PasswordChar = '\0';
            this.tboxMess.PlaceholderText = "Type here";
            this.tboxMess.SelectedText = "";
            this.tboxMess.Size = new System.Drawing.Size(470, 45);
            this.tboxMess.TabIndex = 73;
            // 
            // usernamlable
            // 
            this.usernamlable.AutoSize = true;
            this.usernamlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.usernamlable.Location = new System.Drawing.Point(551, 44);
            this.usernamlable.Name = "usernamlable";
            this.usernamlable.Size = new System.Drawing.Size(86, 29);
            this.usernamlable.TabIndex = 72;
            this.usernamlable.Text = "Admin";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(556, 361);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 71;
            this.guna2Button1.Text = "Send";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvMess);
            this.Controls.Add(this.tboxMess);
            this.Controls.Add(this.usernamlable);
            this.Controls.Add(this.guna2Button1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMess;
        private Guna.UI2.WinForms.Guna2TextBox tboxMess;
        private System.Windows.Forms.Label usernamlable;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}