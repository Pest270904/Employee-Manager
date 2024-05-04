﻿using Employee_Manager.Child_Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager
{
    public partial class Main_Form : Form
    {
        private Guna2Button currentButton;
        private Form activeForm;

        private string username;

        public Main_Form(string username)
        {
            InitializeComponent();
            this.username = username;
            username_main.Text = username;
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Forms.ListRoom_ChildForm(), sender);
        }
        private void employeeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Forms.ListEmployee_ChildForm(), sender);
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Forms.Profile_ChildForm(), sender);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout_Form frm = new Logout_Form(username);
            frm.ShowDialog();
            this.Close();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Guna2Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Guna2Button)btnSender;
                    currentButton.FillColor = Color.FromArgb(102, 144, 226);
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
                }
                else currentButton = null;
            }
        }
        private void DisableButton()
        {
            Guna2Button[] btnArr = { roomBtn, logoutBtn, profileBtn, employeeBtn };

            foreach (Guna2Button btn in btnArr)
            {
                    btn.FillColor = Color.FromArgb(5, 77, 17);
                    btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            }
        }
    }
}
