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
    public partial class frmServiceManagerMenu : UserControl
    {
        public frmServiceManagerMenu()
        {
            InitializeComponent();
        }

        private void buttonSchVM_Click(object sender, EventArgs e)
        {
            FleetTracking._frmServiceManagerSS.Show();
            FleetTracking._frmServiceManagerSS.BringToFront();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FleetTracking._frmServiceManagerHS.BringToFront();
        }
    }
}
