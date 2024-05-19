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
            this.send_btn = new System.Windows.Forms.Button();
            this.message_box = new System.Windows.Forms.TextBox();
            this.chat_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(746, 470);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(120, 34);
            this.send_btn.TabIndex = 11;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // message_box
            // 
            this.message_box.Location = new System.Drawing.Point(62, 475);
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(622, 26);
            this.message_box.TabIndex = 10;
            // 
            // chat_box
            // 
            this.chat_box.Location = new System.Drawing.Point(62, 79);
            this.chat_box.Multiline = true;
            this.chat_box.Name = "chat_box";
            this.chat_box.Size = new System.Drawing.Size(804, 309);
            this.chat_box.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message";
            // 
            // Chat_ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 599);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.chat_box);
            this.Controls.Add(this.label2);
            this.Name = "Chat_ChildForm";
            this.Text = "Chat_ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox message_box;
        private System.Windows.Forms.TextBox chat_box;
        private System.Windows.Forms.Label label2;
    }
}