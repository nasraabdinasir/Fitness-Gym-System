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
    public partial class GymMembersRegistration : Form
    {
        public GymMembersRegistration()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnviewlist_Click(object sender, EventArgs e)
        {
            GymMembersList gml = new GymMembersList();
            gml.ShowDialog();
        }

        private void btngobacktopreviouspage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gymMembersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gymMembersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void GymMembersRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.GymMembers' table. You can move, or remove it, as needed.
            gymMembersBindingSource.AddNew();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.gymMembersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);
                MessageBox.Show("Saving.....", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void email_AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
