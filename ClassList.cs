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
    public partial class ClassList : Form
    {
        public ClassList()
        {
            InitializeComponent();
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void ClassList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierFitnessDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.premierFitnessDataSet.Classes);

        }

        private void btndeleterecord_Click(object sender, EventArgs e)
        {
            classesBindingSource.RemoveCurrent();
        }
    }
}
