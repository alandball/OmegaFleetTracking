using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wil
{
    public partial class frmOfficeManagerMenu : UserControl
    {
        public frmOfficeManagerMenu()
        {
            InitializeComponent();
        }
        
        private void buttonHome_Click(object sender, EventArgs e)
        {
            FleetTracking._frmOfficeManager.Hide();
            FleetTracking._frmOfficeManagerHS.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FleetTracking._frmOfficeManagerHS.Hide();
            FleetTracking._frmOfficeManager.Show();
            FleetTracking._frmOfficeManager.buttonSubmit.Text = "Add User";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
