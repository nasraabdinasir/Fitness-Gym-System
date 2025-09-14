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
    public partial class AssignTutors : Form
    {
        public AssignTutors()
        {
            InitializeComponent();
        }

        private void btnviewlist_Click(object sender, EventArgs e)
        {
            AssignedTutos adt = new AssignedTutos();
            adt.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngobacktopreviouspage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void assignTutorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assignTutorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void AssignTutors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.premierFitnessDataSet.Classes);
            // TODO: This line of code loads data into the 'premierFitnessDataSet.GymTutors' table. You can move, or remove it, as needed.
            this.gymTutorsTableAdapter.Fill(this.premierFitnessDataSet.GymTutors);
            assignTutorsBindingSource.AddNew();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.Validate();
                this.assignTutorsBindingSource.EndEdit();
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
