using Employee_Manager.Child_Forms;
using Employee_Manager.Others;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager.Update_data_forms
{
    public partial class Employees_Add : Form
    {

        private IFirebaseClient client;
        private Userdata currentUser;
        public Employees_Add(Userdata user)
        {
            InitializeComponent();
            client = FirebaseSetup.InitializeFirebase();


            this.currentUser = user;
        }


        private async void add_Btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTxtBox.Text) || String.IsNullOrEmpty(emailTxtBox.Text) || String.IsNullOrEmpty(phoneTxtBox.Text) || String.IsNullOrEmpty(roomIDComboBox.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    string roomData = roomIDComboBox.SelectedItem.ToString();
                    if (roomData != null)
                    {
                        FirebaseResponse respGet = client.Get("users/" + currentUser.username + "/rooms/r" + roomData + "/employees/");
                        Dictionary<string, Employees> result;

                        if (respGet.Body != "null")
                        {
                            result = respGet.ResultAs<Dictionary<string, Employees>>();
                        }
                        else
                        {
                            result = new Dictionary<string, Employees>();
                        }

                        bool ifExist = false;

                        foreach (var get in result)
                        {
                            if (emailTxtBox.Text == get.Value.email)
                            {
                                ifExist = true;
                                break;
                            }
                        }

                        if (!ifExist)
                        {
                            var dataLayer = new Employees
                            {
                                email = emailTxtBox.Text,
                                name = nameTxtBox.Text,
                                birthday = birthdayPicker.Value,  
                                phoneNumber = phoneTxtBox.Text,  
                                gender = genderComboBx.SelectedItem.ToString(),
                                salary = 0 //Default
                            };

                            // Add new employee
                            SetResponse resp = await client.SetTaskAsync("users/" + currentUser.username + "/rooms/r" + roomData + "/employees/e", dataLayer);
                            MessageBox.Show("New employee added");

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Employee with this email already exists");
                        }
                    }
                    // Nếu room không phù hợp
                    else
                    {
                        MessageBox.Show("Invalid Room ID");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Employees_Add_Load(object sender, EventArgs e)
        {
            FirebaseResponse respGet = client.Get("users/" + currentUser.username + "/rooms/");
            Dictionary<string, RoomData> result;

            if (respGet.Body != "null")
            {
                result = respGet.ResultAs<Dictionary<string, RoomData>>();
            }
            else
            {
                result = new Dictionary<string, RoomData>();
            }

            foreach (var roomEntry in result)
            {
                roomIDComboBox.Items.Add(roomEntry.Value.roomID);
            }

        }


    }
}
