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
            FleetTracking._frmOfficeManagerAddUser.Hide();
            FleetTracking._frmOfficeManager_Remove.Hide();
            //FleetTracking._frmOfficeManager_Edit.Hide();
            FleetTracking._frmOfficeManagerHS.Show();
            FleetTracking._frmOfficeManagerHS.reload();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FleetTracking._frmOfficeManagerHS.Hide();
            FleetTracking._frmOfficeManager_Remove.Hide();
            //FleetTracking._frmOfficeManager_Edit.Hide();
            FleetTracking._frmOfficeManagerAddUser.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FleetTracking._frmOfficeManagerHS.Hide();
            FleetTracking._frmOfficeManagerAddUser.Hide();
            //FleetTracking._frmOfficeManager_Edit.Hide();
            FleetTracking._frmOfficeManager_Remove.Show();
            FleetTracking._frmOfficeManager_Remove.reload();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
