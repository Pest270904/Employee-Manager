using Employee_Manager.Main_forms;
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
    public partial class ListEmployee_ChildForm : Form
    {
        private Userdata currentUser;
        private IFirebaseClient client;

        public ListEmployee_ChildForm(Userdata user)
        {
            InitializeComponent();
            client = FirebaseSetup.InitializeFirebase();

            this.currentUser = user;
            LoadData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Employees_Add frm = new Employees_Add(currentUser);
            frm.ShowDialog();
            LoadData();
        }

        // Functions to retrieve the rooms for each admin user:
        private Dictionary<string, RoomData> RetrieveRoomID()
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

            return result;
        }

        // ----------------------------- Individual functions -----------------------------
        private void LoadData()
        {
            // Truy xuất room ID
            var result = RetrieveRoomID();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Gender");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Birth Day");
            dataTable.Columns.Add("Phone Number");
            dataTable.Columns.Add("Salary");
            dataTable.Columns.Add("Room ID");

            foreach (var roomEntry in result)
            {
                //Truy xuất employees từ firebase
                FirebaseResponse respGet2 = client.Get("users/" + currentUser.username + "/rooms/r" + roomEntry.Value.roomID + "/employees/");
                Dictionary<string, Employees> result2;


                if (respGet2.Body != "null")
                {
                    result2 = respGet2.ResultAs<Dictionary<string, Employees>>();
                }
                else
                {
                    result2 = new Dictionary<string, Employees>();
                }

                foreach (var userInfo in result2)
                {
                    DataRow row = dataTable.NewRow();
                    row["ID"] = userInfo.Value.id;
                    row["Name"] = userInfo.Value.name;
                    row["Gender"] = userInfo.Value.gender;
                    row["Email"] = userInfo.Value.email;
                    row["Birth Day"] = userInfo.Value.birthday;
                    row["Phone Number"] = userInfo.Value.phoneNumber;
                    row["Salary"] = userInfo.Value.salary;
                    row["Room ID"] = userInfo.Value.roomID;
                    dataTable.Rows.Add(row);
                }
            }

            employeeGridView.DataSource = dataTable;
        }

        private void ListEmployee_ChildForm_Load(object sender, EventArgs e)
        {
            client = FirebaseSetup.InitializeFirebase();
        }


        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTB.Text))
            {
                (employeeGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (employeeGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("ID='{0}'", searchTB.Text);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var rooms = RetrieveRoomID();

            foreach (var roomId in rooms)
            {
                try
                {
                    if (employeeGridView.SelectedRows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this record? Delete an employee will delete all information of that employee",
                            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Retrieve data from the selected row
                            DataGridViewRow selectedRow = employeeGridView.SelectedRows[0];
                            string employeeName = selectedRow.Cells["Name"].Value.ToString();

                            // Execute deleting
                            FirebaseResponse responseDel = client.Delete("users/" + currentUser.username + "/rooms/r" + roomId + "/employees/" + employeeName);

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
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeGridView.SelectedRows.Count > 0)
                {
                    // Retrieve data from the selected row
                    DataGridViewRow selectedRow = employeeGridView.SelectedRows[0];

                    //Đoạn này lấy dữ liệu từ gridview
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    string roomId = selectedRow.Cells["Room ID"].Value.ToString();
                    string name = selectedRow.Cells["Name"].Value.ToString();
                    string gender = selectedRow.Cells["Gender"].Value.ToString();
                    string email = selectedRow.Cells["Email"].Value.ToString();
                    DateTime birthday = Convert.ToDateTime(selectedRow.Cells["Birth Day"].Value);
                    string phoneNumber = selectedRow.Cells["Phone Number"].Value.ToString();
                    double salery = Convert.ToDouble(selectedRow.Cells["Salary"].Value);


                    Employees_Update frm = new Employees_Update(id, roomId, name, email, phoneNumber, gender, birthday, salery, currentUser);
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

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            searchTB.Clear();
            LoadData();
        }
    }
}