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
    public partial class UpdateDeviceForm : Form
    {
        public UpdateDeviceForm()
        {
            InitializeComponent();
        }

        private void RefreshTextBoxes()
        {
            updateDevNameTxtBox.Clear();
            updateManufTextBox.Clear();
            updateTypeTextBox.Clear();
            updateOSTextBox.Clear();
            updateOSvTextBox.Clear();
            updateCPUTextBox.Clear();
            updateRAMTextBox.Clear();
        }
        private void updateDeviceButton_Click(object sender, EventArgs e)
        {
            DataAccess updateDevice = new DataAccess();

            updateDevice.UpdateDevice(updateDevNameTxtBox.Text, updateManufTextBox.Text, updateTypeTextBox.Text, updateOSTextBox.Text, updateOSvTextBox.Text, updateCPUTextBox.Text, updateRAMTextBox.Text);

            RefreshTextBoxes();
        }
    }
}
