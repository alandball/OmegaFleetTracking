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
    public partial class frmTripManagerMenu : UserControl
    {
        public frmTripManagerMenu()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

            FleetTracking._frmTripManagerHS.Show();
            FleetTracking._frmTripManagerHS.BringToFront();
        }

        private void buttonScheduleTrip_Click(object sender, EventArgs e)
        {
            FleetTracking._frmTripManagerSchT.Show();
            FleetTracking._frmTripManagerSchT.BringToFront();
        }

        private void buttonIncidence_Click(object sender, EventArgs e)
        {
            FleetTracking._frmTripManagerTripIncidents.Show();
            FleetTracking._frmTripManagerTripIncidents.BringToFront();
        }

        private void buttonTripCompleted_Click(object sender, EventArgs e)
        {
            FleetTracking._frmTripManagerTripComp.Show();
            FleetTracking._frmTripManagerTripComp.BringToFront();
        }

    }
}
