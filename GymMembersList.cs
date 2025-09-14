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
    public partial class GymMembersList : Form
    {
        public GymMembersList()
        {
            InitializeComponent();
        }

        private void gymMembersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gymMembersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void GymMembersList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.GymMembers' table. You can move, or remove it, as needed.
            this.gymMembersTableAdapter.Fill(this.premierFitnessDataSet.GymMembers);

        }

        private void btndeleterecord_Click(object sender, EventArgs e)
        {
            gymMembersBindingSource.RemoveCurrent();
        }
    }
}
