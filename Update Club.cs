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
    public partial class Update_Club : Form
    {
        public Update_Club()
        {
            InitializeComponent();
        }

        private void txtUDNameClub_Enter(object sender, EventArgs e)
        {
            if(txtUDNameClub.Text == "Enter Club Name")
            {
                txtUDNameClub.Text = "";
                txtUDNameClub.ForeColor = Color.Black;
            }
        }

        private void txtUDNameClub_Leave(object sender, EventArgs e)
        {
            if (txtUDNameClub.Text == "")
            {
                txtUDNameClub.Text = "Enter Club Name";
                txtUDNameClub.ForeColor = Color.Silver;
            }
        }
    }
}
