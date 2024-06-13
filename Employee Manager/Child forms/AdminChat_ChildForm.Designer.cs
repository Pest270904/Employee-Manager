using System.Windows.Forms;

namespace Employee_Manager.Child_Forms
{
    partial class AdminChat_ChildForm
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
            this.message_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chat_box = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
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
            this.message_box.Location = new System.Drawing.Point(59, 405);
            this.message_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.message_box.Name = "message_box";
            this.message_box.PasswordChar = '\0';
            this.message_box.PlaceholderText = "...";
            this.message_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.message_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.message_box.SelectedText = "";
            this.message_box.Size = new System.Drawing.Size(696, 79);
            this.message_box.TabIndex = 5;
            this.message_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_box_KeyDown);
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
            this.sendBtn.Location = new System.Drawing.Point(778, 405);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(118, 80);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "SEND";
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // userList
            // 
            this.userList.AutoRoundedCorners = true;
            this.userList.BackColor = System.Drawing.Color.Transparent;
            this.userList.BorderColor = System.Drawing.Color.Black;
            this.userList.BorderRadius = 17;
            this.userList.BorderThickness = 2;
            this.userList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.userList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userList.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.userList.ItemHeight = 30;
            this.userList.Location = new System.Drawing.Point(59, 34);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(638, 36);
            this.userList.TabIndex = 7;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_TextChanged);
            this.userList.TextChanged += new System.EventHandler(this.userList_TextChanged);
            // 
            // chat_box
            // 
            this.chat_box.AutoScroll = true;
            this.chat_box.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chat_box.Location = new System.Drawing.Point(59, 96);
            this.chat_box.Name = "chat_box";
            this.chat_box.Size = new System.Drawing.Size(837, 282);
            this.chat_box.TabIndex = 8;
            this.chat_box.WrapContents = false;
            // 
            // AdminChat_ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 529);
            this.Controls.Add(this.chat_box);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.sendBtn);
            this.Name = "AdminChat_ChildForm";
            this.Text = "AdminChat_ChildForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox message_box;
        private Guna.UI2.WinForms.Guna2Button sendBtn;
        private Guna.UI2.WinForms.Guna2ComboBox userList;
        private System.Windows.Forms.FlowLayoutPanel chat_box;
    }
}