using Employee_Manager.Main_forms;
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

namespace Employee_Manager.Child_Forms
{
    public partial class ListRoom_ChildForm : Form
    {
        private Userdata currentUser;
        private IFirebaseClient client;

        public ListRoom_ChildForm(Userdata user)
        {
            InitializeComponent();
            client = FirebaseSetup.InitializeFirebase();

            this.currentUser = user;
            LoadData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Room_Add frm = new Room_Add(currentUser);
            frm.ShowDialog();
            LoadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoomGridView.SelectedRows.Count > 0)
                {
                    // Retrieve data from the selected row
                    DataGridViewRow selectedRow = RoomGridView.SelectedRows[0];
                    string roomId = selectedRow.Cells["roomID"].Value.ToString();
                    string roomName = selectedRow.Cells["roomName"].Value.ToString();
                    int employeeCount = Convert.ToInt32(selectedRow.Cells["count"].Value);

                    Room_Update frm = new Room_Update(roomId, roomName, employeeCount, currentUser);
                    frm.ShowDialog();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please select a row to update data");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoomGridView.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record? Delete a room will delete all information of employees working in that room",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Retrieve data from the selected row
                        DataGridViewRow selectedRow = RoomGridView.SelectedRows[0];
                        string roomId = selectedRow.Cells["roomID"].Value.ToString();

                        // Execute deleting
                        FirebaseResponse responseDel = client.Delete("users/" + currentUser.username + "/rooms/r" + roomId);

                        // Show a message or perform any other action after deletion
                        MessageBox.Show("Record deleted successfully.");
                    }

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please select a row to update data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTB.Text))
            {
                (RoomGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (RoomGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("roomID='{0}'", searchTB.Text);
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            searchTB.Clear();
            LoadData();
        }

        private void ListRoom_ChildForm_Load(object sender, EventArgs e)
        {
            client = FirebaseSetup.InitializeFirebase();
        }

        // ----------------------------- Individual functions -----------------------------
        private void LoadData()
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

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("roomID");
            dataTable.Columns.Add("roomName");
            dataTable.Columns.Add("count");

            foreach (var roomEntry in result)
            {
                DataRow row = dataTable.NewRow();
                row["roomID"] = roomEntry.Value.roomID;
                row["roomName"] = roomEntry.Value.roomName;
                row["count"] = roomEntry.Value.countEmployee;
                dataTable.Rows.Add(row);
            }     

            RoomGridView.DataSource = dataTable;
        }
    }
}
