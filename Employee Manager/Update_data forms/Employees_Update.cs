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
    public partial class Employees_Update : Form
    {
        private int id;
        private string roomID;
        private string name;
        private string emailAddr;
        private string gender;
        private string phoneNumber;
        private DateTime birthday;
        private double salery;

        private Userdata currentUser;
        private IFirebaseClient client;

        public Employees_Update(int id, string roomID, string name, string emailAddr, string phoneNumber, string gender, DateTime birthday, double salery, Userdata user)
        {
            InitializeComponent();
            client = FirebaseSetup.InitializeFirebase();

            this.id = id;
            this.roomID = roomID;
            this.name = name;
            this.emailAddr = emailAddr;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.birthday = birthday;
            this.salery = salery;

            nameTxtBox.Text = name;
            emailTxtBox.Text = emailAddr;
            genderComboBx.SelectedItem = gender.ToString();
            phoneTxtBox.Text = phoneNumber;
            birthdayPicker.Value = birthday;
            saleryTxtBox.Text = salery.ToString();
            roomidCombobox.Text = roomID.ToString();

            currentUser = user;

            // Populate the roomID combo box
            PopulateRoomIDComboBox();
            roomidCombobox.SelectedItem = roomID;
        }

        private async void PopulateRoomIDComboBox()
        {
            FirebaseResponse respGet = await client.GetTaskAsync("users/" + currentUser.username + "/rooms/");
            Dictionary<string, RoomData> rooms = respGet.ResultAs<Dictionary<string, RoomData>>();

            if (rooms != null)
            {
                foreach (var room in rooms)
                {
                    roomidCombobox.Items.Add(room.Key.Substring(1)); // Assuming roomID is prefixed with 'r'
                }
            }
        }

        private async void update_Btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTxtBox.Text) ||
                String.IsNullOrEmpty(emailTxtBox.Text) ||
                String.IsNullOrEmpty(phoneTxtBox.Text) ||
                genderComboBx.SelectedIndex == -1 ||
                roomidCombobox.SelectedIndex == -1 ||
                String.IsNullOrEmpty(saleryTxtBox.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                FirebaseResponse respGet = await client.GetTaskAsync("users/" + currentUser.username + "/rooms/r" + roomidCombobox.SelectedItem.ToString() + "/employees/");
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
                    if (emailTxtBox.Text == get.Value.email && emailTxtBox.Text != emailAddr)
                    {
                        ifExist = true;
                        break;
                    }
                }

                if (!ifExist)
                {
                    FirebaseResponse respDelOldRoom = await client.DeleteTaskAsync("users/" + currentUser.username + "/rooms/r" + roomID + "/employees/employee" + id);

                    var employeeData = new Employees
                    {
                        id = id,
                        name = nameTxtBox.Text,
                        email = emailTxtBox.Text,
                        phoneNumber = phoneTxtBox.Text,
                        gender = genderComboBx.Text,
                        roomID = roomidCombobox.SelectedItem.ToString(),
                        salary = Convert.ToDouble(saleryTxtBox.Text),
                        birthday = birthdayPicker.Value
                    };

                    SetResponse resp = await client.SetTaskAsync("users/" + currentUser.username + "/rooms/r" + roomidCombobox.SelectedItem.ToString() + "/employees/employee" + id, employeeData);
                    MessageBox.Show("Update successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Employee already exists");
                }
            }
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employees_Update_Load(object sender, EventArgs e)
        {

        }
    }
}
