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
    public partial class frmTimeSheetManagerMenu : UserControl
    {
        public frmTimeSheetManagerMenu()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FleetTracking._frmTimeSheetManagerHS.Show();
            FleetTracking._frmTimeSheetManagerHS.BringToFront();
            FleetTracking._frmTimeSheetManagerHS.fillGridView();
        }

        private void buttonEnterHours_Click(object sender, EventArgs e)
        {
            FleetTracking._frmTimeSheetManagerEnterHr.Show();
            FleetTracking._frmTimeSheetManagerEnterHr.BringToFront();
        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            FleetTracking._frmTimeSheetManagerAddEmp.Show();
            FleetTracking._frmTimeSheetManagerAddEmp.BringToFront();
        }
    }
}
