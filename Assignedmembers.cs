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
    public partial class Assignedmembers : Form
    {
        public Assignedmembers()
        {
            InitializeComponent();
        }

        private void assignMembersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assignMembersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void Assignedmembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.AssignMembers' table. You can move, or remove it, as needed.
            this.assignMembersTableAdapter.Fill(this.premierFitnessDataSet.AssignMembers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            assignMembersBindingSource.AddNew();
            this.Validate();
            this.assignMembersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);
        }
    }
}
