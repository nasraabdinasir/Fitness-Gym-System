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
    public partial class AssignedTutos : Form
    {
        public AssignedTutos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assignTutorsBindingSource.AddNew();
            this.Validate();
            this.assignTutorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);
        }

        private void assignTutorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            assignTutorsBindingSource.AddNew();
            this.Validate();
            this.assignTutorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void AssignedTutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.GymTutors' table. You can move, or remove it, as needed.
            this.gymTutorsTableAdapter.Fill(this.premierFitnessDataSet.GymTutors);
            // TODO: This line of code loads data into the 'premierFitnessDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.premierFitnessDataSet.Classes);
            // TODO: This line of code loads data into the 'premierFitnessDataSet.AssignTutors' table. You can move, or remove it, as needed.
            this.assignTutorsTableAdapter.Fill(this.premierFitnessDataSet.AssignTutors);

        }
    }
}
