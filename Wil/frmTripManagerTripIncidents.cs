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
    public partial class frmTripManagerTripIncidents : UserControl
    {
        public frmTripManagerTripIncidents()
        {
            InitializeComponent();
        }

        private void frmTripManagerTripIncidents_Load(object sender, EventArgs e)
        {
            DBAccess _DBAccess = new DBAccess();

            string sQuery = @"
                        SELECT RTRIM(VehicleReg)[VehicleReg], VehicleID
                        FROM tblVehicle";

            _DBAccess.Do_SQLQuery(sQuery);

            comboBoxVehicleRegistrationNum.DataSource = _DBAccess.bndSrc;
            comboBoxVehicleRegistrationNum.DisplayMember = "VehicleReg"; //colum you want to show in comboBox
            comboBoxVehicleRegistrationNum.ValueMember = "VehicleID"; //column you want to use in the background (not necessary)!
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
          

        }
    }
}
