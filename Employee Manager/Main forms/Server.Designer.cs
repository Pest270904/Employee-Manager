namespace Employee_Manager.Main_forms
{
    partial class Server
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
            this.message_box = new System.Windows.Forms.RichTextBox();
            this.listen_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_box
            // 
            this.message_box.Location = new System.Drawing.Point(51, 82);
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(811, 408);
            this.message_box.TabIndex = 11;
            this.message_box.Text = "";
            this.message_box.TextChanged += new System.EventHandler(this.message_box_TextChanged);
            // 
            // listen_btn
            // 
            this.listen_btn.Location = new System.Drawing.Point(754, 28);
            this.listen_btn.Name = "listen_btn";
            this.listen_btn.Size = new System.Drawing.Size(108, 29);
            this.listen_btn.TabIndex = 10;
            this.listen_btn.Text = "Listen";
            this.listen_btn.UseVisualStyleBackColor = true;
            this.listen_btn.Click += new System.EventHandler(this.listen_btn_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 570);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.listen_btn);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox message_box;
        private System.Windows.Forms.Button listen_btn;
    }
}