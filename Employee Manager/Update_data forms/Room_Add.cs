using Employee_Manager.Others;
using FireSharp.Extensions;
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

namespace Employee_Manager.Update_data_forms
{
    public partial class Room_Add : Form
    {
        private IFirebaseClient client;
        private Userdata currentUser;

        public Room_Add(Userdata user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void add_Btn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(roomID_TB.Text) || String.IsNullOrEmpty(roomName_TB.Text) )
            {
                MessageBox.Show("Please fill al the fields");
            } 
            else
            {
                try
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
                        if (roomID_TB.Text == get.Value.roomID)
                        {
                            ifExist = true;
                            break;
                        }
                    }

                    if (!ifExist)
                    {
                        var dataLayer = new RoomData
                        {
                            roomID = roomID_TB.Text,
                            roomName = roomName_TB.Text,
                            countEmployee = 0
                        };

                        // add new room
                        SetResponse resp = await client.SetTaskAsync("users/" + currentUser.username + "/rooms/r" + roomID_TB.Text, dataLayer);
                        MessageBox.Show("New room added");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Room ID is already exists");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Room_Add_Load(object sender, EventArgs e)
        {
            client = FirebaseSetup.InitializeFirebase();
        }
    }
}
