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
    public partial class frmVehicleManagerMenu : UserControl
    {
        public frmVehicleManagerMenu()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FleetTracking._frmVehicleManager.Show();
            FleetTracking._frmVehicleManager.BringToFront();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FleetTracking._frmVehicleManagerHS.Show();
            FleetTracking._frmVehicleManagerHS.BringToFront();
            
        }

        private void frmVehicleManagerMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
