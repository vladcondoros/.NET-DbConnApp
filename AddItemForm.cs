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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        public void RefreshUserTextValues()
        {
            usernameTextBox.Clear();
            roleTextBox.Clear();
            locationTextBox.Clear();
        }

        public void RefreshDeviceTextValues()
        {
            deviceNameTextBox.Clear();
            manufTextBox.Clear();
            typeTextBox.Clear();
            osTextBox.Clear();
            osvTextBox.Clear();
            cpuTextBox.Clear();
            ramTextBox.Clear();
        }
        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            DataAccess adduser = new DataAccess();

            adduser.AddUser(usernameTextBox.Text, roleTextBox.Text, locationTextBox.Text);

            RefreshUserTextValues();
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            DataAccess addDevice = new DataAccess();

            addDevice.AddDevice(deviceNameTextBox.Text, manufTextBox.Text, typeTextBox.Text, osTextBox.Text, osvTextBox.Text, cpuTextBox.Text, ramTextBox.Text);

            RefreshDeviceTextValues();
        }
    }
}
