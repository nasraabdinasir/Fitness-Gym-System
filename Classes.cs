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
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnviewlist_Click(object sender, EventArgs e)
        {
            ClassList cl = new ClassList();
            cl.ShowDialog();
        }

        private void btngobacktopreviouspage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Classes_Load(object sender, EventArgs e)
        {
            classesBindingSource.AddNew();
        }

       

        private void classesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try {
                this.Validate();
                this.classesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.premierFitnessDataSet);
                MessageBox.Show("Saving.....", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
