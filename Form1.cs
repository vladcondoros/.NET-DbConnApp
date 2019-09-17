using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnTest
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Device> devices = new List<Device>();
        public static User ID = new User();
        public Form1()
        {
            InitializeComponent();
        }


        private void RefreshListBox()
        {
            SearchResults.DataSource = users;
            SearchResults.DisplayMember = "FullUserInfo";
            SearchDeviceResults.DataSource = devices;
            SearchDeviceResults.DisplayMember = "FullDeviceInfo";
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int searchedID = Int32.Parse(SearchTextBox.Text);
            users = db.GetUsers(SearchTextBox.Text);
            devices = db.GetDevices(SearchTextBox.Text);

            ID.UserId = searchedID;
            RefreshListBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formPopUpBtn_Click(object sender, EventArgs e)
        {
            AddItemForm addUserDevice = new AddItemForm();
            addUserDevice.ShowDialog();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUser = new UpdateUserForm();
            updateUser.ShowDialog();
        }

        private void updateDeviceButton_Click(object sender, EventArgs e)
        {
            UpdateDeviceForm updateDevice = new UpdateDeviceForm();
            updateDevice.ShowDialog();
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteUser();
        }
    }
}
