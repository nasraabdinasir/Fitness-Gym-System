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
    public partial class TutorList : Form
    {
        public TutorList()
        {
            InitializeComponent();
        }

        private void TutorList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.GymTutors' table. You can move, or remove it, as needed.
            this.gymTutorsTableAdapter.Fill(this.premierFitnessDataSet.GymTutors);

        }

        private void gymTutorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gymTutorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void btndeleterecord_Click(object sender, EventArgs e)
        {
            this.gymTutorsBindingSource.RemoveCurrent();
        }
    }
}
