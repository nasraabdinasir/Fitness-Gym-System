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
    public partial class TutorsRegistration : Form
    {
        public TutorsRegistration()
        {
            InitializeComponent();
        }

        private void btngobacktopreviouspage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnviewlist_Click(object sender, EventArgs e)
        {
            TutorList tl = new TutorList();
            tl.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void gymTutorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gymTutorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void TutorsRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.GymTutors' table. You can move, or remove it, as needed.
            this.gymTutorsBindingSource.AddNew();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.gymTutorsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);
                MessageBox.Show("Saving.....", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}