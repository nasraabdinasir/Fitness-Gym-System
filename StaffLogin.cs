using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Premier_FitnessGym_System
{
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(staffTableAdapter.GetUsernameandPassword(premierFitnessDataSet.Staff, usernameTextBox.Text, passwordTextBox.Text) == 1)
            {
                this.Hide();
                SelectionPage mgp = new SelectionPage();
                mgp.ShowDialog();
            }
            else
            {
                MessageBox.Show("incorrect Username or Password...if you're not registered kindly register to log in", "Authentication Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffBindingSource.AddNew();

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            StaffRegistration sr = new StaffRegistration();
            sr.ShowDialog();
        }
    }
}
