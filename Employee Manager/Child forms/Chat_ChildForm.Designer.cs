namespace Employee_Manager.Child_Forms
{
    partial class Chat_ChildForm
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
            this.chat_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.message_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // chat_box
            // 
            this.chat_box.BorderColor = System.Drawing.Color.Black;
            this.chat_box.BorderThickness = 2;
            this.chat_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chat_box.DefaultText = "";
            this.chat_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chat_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chat_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chat_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chat_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chat_box.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.chat_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chat_box.Location = new System.Drawing.Point(64, 54);
            this.chat_box.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chat_box.Multiline = true;
            this.chat_box.Name = "chat_box";
            this.chat_box.PasswordChar = '\0';
            this.chat_box.PlaceholderText = "";
            this.chat_box.ReadOnly = true;
            this.chat_box.SelectedText = "";
            this.chat_box.Size = new System.Drawing.Size(942, 414);
            this.chat_box.TabIndex = 0;
            // 
            // sendBtn
            // 
            this.sendBtn.BorderThickness = 2;
            this.sendBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(155)))));
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(873, 506);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(133, 100);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "SEND";
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // message_box
            // 
            this.message_box.BorderColor = System.Drawing.Color.Black;
            this.message_box.BorderThickness = 2;
            this.message_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.message_box.DefaultText = "";
            this.message_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.message_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.message_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.message_box.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.message_box.Location = new System.Drawing.Point(64, 506);
            this.message_box.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.message_box.Name = "message_box";
            this.message_box.PasswordChar = '\0';
            this.message_box.PlaceholderText = "...";
            this.message_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.message_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.message_box.SelectedText = "";
            this.message_box.Size = new System.Drawing.Size(783, 99);
            this.message_box.TabIndex = 2;
            // 
            // Chat_ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.chat_box);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Chat_ChildForm";
            this.Text = "Chat_ChildForm";
            this.Load += new System.EventHandler(this.Chat_ChildForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox chat_box;
        private Guna.UI2.WinForms.Guna2Button sendBtn;
        private Guna.UI2.WinForms.Guna2TextBox message_box;
    }
}