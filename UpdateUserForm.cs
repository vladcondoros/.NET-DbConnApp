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
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void RefreshTextBoxes()
        {
            updateUserNameTxt.Clear();
            updateUserRoleTxt.Clear();
            updateUserLocTxt.Clear();
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            DataAccess updateUser = new DataAccess();

            updateUser.UpdateUser(updateUserNameTxt.Text, updateUserRoleTxt.Text, updateUserLocTxt.Text);

            RefreshTextBoxes();
        }
    }
}
