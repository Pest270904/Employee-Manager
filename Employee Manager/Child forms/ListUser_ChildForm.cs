using Employee_Manager.Others;
using Employee_Manager.Update_data_forms;
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
    public partial class ListUser_ChildForm : Form
    {
        private IFirebaseClient client;

        public ListUser_ChildForm()
        {
            InitializeComponent();
            client = FirebaseSetup.InitializeFirebase();

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
                    string username = selectedRow.Cells["Username"].Value.ToString();

                    User_Update frm = new User_Update(username);
                    frm.ShowDialog();
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoomGridView.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record? Delete a user will delete all things that user has!!",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Retrieve data from the selected row
                        DataGridViewRow selectedRow = RoomGridView.SelectedRows[0];
                        string username = selectedRow.Cells["Username"].Value.ToString();

                        // Execute deleting
                        FirebaseResponse responseDel = client.Delete("users/" + username);

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

        private void LoadData()
        {
            FirebaseResponse resp = client.Get("users/");
            Dictionary<string, Data> result = resp.ResultAs<Dictionary<string, Data>>();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Full name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Rooms managed");

            foreach (var user in result)
            {
                DataRow row = dataTable.NewRow();
                row["Username"] = user.Value.username;
                row["Full name"] = user.Value.name;
                row["Email"] = user.Value.email;

                int countRoom = 0;
                FirebaseResponse respRoom = client.Get("users/" + user.Value.username + "/rooms/");
                Dictionary<string, RoomData> resultRoom;

                if (respRoom.Body != "null")
                {
                    resultRoom = respRoom.ResultAs<Dictionary<string, RoomData>>();
                }
                else
                {
                    resultRoom = new Dictionary<string, RoomData>();
                }

                foreach (var room in resultRoom)
                {
                    countRoom++;
                }

                row["Rooms managed"] = countRoom;

                dataTable.Rows.Add(row);
            }

            RoomGridView.DataSource = dataTable;
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTB.Text))
            {
                (RoomGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (RoomGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Username='{0}'", searchTB.Text);
            }
        }
    }
}
