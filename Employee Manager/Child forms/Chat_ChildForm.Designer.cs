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
            this.chatBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sendBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.BorderColor = System.Drawing.Color.Black;
            this.chatBox.BorderThickness = 2;
            this.chatBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatBox.DefaultText = "";
            this.chatBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chatBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chatBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatBox.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.chatBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatBox.Location = new System.Drawing.Point(57, 43);
            this.chatBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.PasswordChar = '\0';
            this.chatBox.PlaceholderText = "";
            this.chatBox.ReadOnly = true;
            this.chatBox.SelectedText = "";
            this.chatBox.Size = new System.Drawing.Size(837, 331);
            this.chatBox.TabIndex = 0;
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
            this.sendBtn.Location = new System.Drawing.Point(776, 405);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(118, 80);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "SEND";
            // 
            // sendBox
            // 
            this.sendBox.BorderColor = System.Drawing.Color.Black;
            this.sendBox.BorderThickness = 2;
            this.sendBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sendBox.DefaultText = "";
            this.sendBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sendBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sendBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sendBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sendBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sendBox.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sendBox.Location = new System.Drawing.Point(57, 405);
            this.sendBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBox.Name = "sendBox";
            this.sendBox.PasswordChar = '\0';
            this.sendBox.PlaceholderText = "...";
            this.sendBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sendBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sendBox.SelectedText = "";
            this.sendBox.Size = new System.Drawing.Size(696, 79);
            this.sendBox.TabIndex = 2;
            // 
            // Chat_ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 529);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.chatBox);
            this.Name = "Chat_ChildForm";
            this.Text = "Chat_ChildForm";
            this.Load += new System.EventHandler(this.Chat_ChildForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox chatBox;
        private Guna.UI2.WinForms.Guna2Button sendBtn;
        private Guna.UI2.WinForms.Guna2TextBox sendBox;
    }
}