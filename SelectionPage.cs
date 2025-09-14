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
    public partial class SelectionPage : Form
    {
        public SelectionPage()
        {
            InitializeComponent();
        }

        private void btnAddGymMembers_Click(object sender, EventArgs e)
        {
            GymMembersRegistration gr = new GymMembersRegistration();
            gr.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddGymTutors_Click(object sender, EventArgs e)
        {
            TutorsRegistration tr = new TutorsRegistration();
            tr.ShowDialog();
        }

        private void btnAddGymClasses_Click(object sender, EventArgs e)
        {
            Classes cs = new Classes();
            cs.ShowDialog();
        }

        private void btnAssignMembers_Click(object sender, EventArgs e)
        {
            AssignMembers am = new AssignMembers();
            am.ShowDialog();
        }

        private void btnAssignTutors_Click(object sender, EventArgs e)
        {
            AssignTutors at = new AssignTutors();
            at.ShowDialog();
        }

        private void SelectionPage_Load(object sender, EventArgs e)
        {

        }
    }
}
