using Club_Representative;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Dashboard : Form
    {
        Register_Club frmChildAdminRegister;
        Search frmChildAdminSearch;
        Update_Club frmChildAdminUpdate;
        Deregister_Club frmChildAdminDeregister;
        report_activities frmChildAdminReprtactivities;
        report_on_clubs frmChildAdminReportclub;
        public Dashboard()
        {
            
            InitializeComponent();
        }

        private void registerClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChildAdminRegister = new Register_Club();
            frmChildAdminRegister.MdiParent = this; //the frmchild is refering to the Register_Club and MdiParent is holding the frmChild to (this) Dashboard
            frmChildAdminRegister.Show();
        }

        private void searchClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChildAdminSearch = new Search();
            frmChildAdminSearch.MdiParent = this;
            frmChildAdminSearch.Show();
        }

        private void updateClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChildAdminUpdate = new Update_Club();
            frmChildAdminUpdate.MdiParent = this;
            frmChildAdminUpdate.Show();
        }

        private void deregisterClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChildAdminDeregister = new Deregister_Club();
            frmChildAdminDeregister.MdiParent = this;
            frmChildAdminDeregister.Show();
        }

        private void reportActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChildAdminReprtactivities = new report_activities();
            frmChildAdminReprtactivities.MdiParent = this;
            frmChildAdminReprtactivities.Show();
        }

        private void reportOnClubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChildAdminReportclub = new report_on_clubs();
            frmChildAdminReportclub.MdiParent = this;
            frmChildAdminReportclub.Show();
        }  /* Test */
    }
}
