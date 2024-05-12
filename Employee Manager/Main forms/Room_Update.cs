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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Manager.Main_forms
{
    public partial class Room_Update : Form
    {
        private string roomID;
        private string roomName;
        private int count;
        private Userdata currentUser;

        private IFirebaseClient client;

        public Room_Update(string roomID, string roomName, int count, Userdata user)
        {
            InitializeComponent();
            client = FirebaseSetup.InitializeFirebase();

            this.roomID = roomID;
            this.roomName = roomName;
            this.count = count;

            roomID_TB.Text = roomID;
            roomName_TB.Text = roomName;
            currentUser = user;
        }

        private async void update_Btn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(roomID_TB.Text) || String.IsNullOrEmpty(roomName_TB.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
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

                bool ifExist = false;

                // check if roomId is already exists for current user
                foreach (var get in result)
                {
                    if (roomID_TB.Text == get.Value.roomID && roomID_TB.Text != roomID)
                    {
                        ifExist = true;
                        break;
                    }
                }

                if(!ifExist)
                {
                    // Delete old room
                    FirebaseResponse responseDel = client.Delete("users/" + currentUser.username + "/rooms/r" + roomID);

                    var dataLayer = new RoomData
                    {
                        roomID = roomID_TB.Text,
                        roomName = roomName_TB.Text,
                        countEmployee = count
                    };

                    // Add new updated room
                    SetResponse resp = await client.SetTaskAsync("users/" + currentUser.username + "/rooms/r" + roomID_TB.Text, dataLayer);
                    MessageBox.Show("Update successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Room ID is already exists");
                }
            }
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
