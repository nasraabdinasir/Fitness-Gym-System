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
    public partial class StaffRegistration : Form
    {
        public StaffRegistration()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewRegisteredStaff_Click(object sender, EventArgs e)
        {
            StaffRegisteredList srl = new StaffRegisteredList();
            srl.ShowDialog();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.Staff' table. You can move, or remove it, as needed.
            staffBindingSource.AddNew();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.staffBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);
                MessageBox.Show("Saving.....", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
            catch ( Exception ex)
            {
                    MessageBox.Show(ex.Message);
                }
            }
    }
    
}
