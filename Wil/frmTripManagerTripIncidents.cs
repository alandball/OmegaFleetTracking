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
        DBAccess _DBAccess = new DBAccess();

        public frmTripManagerTripIncidents()
        {
            InitializeComponent();
        }

        private void frmTripManagerTripIncidents_Load(object sender, EventArgs e)
        {
            
            string sQuery = @"
                        SELECT RTRIM(VehicleReg)[VehicleReg], tblScheduleLine.ScheduleLineID
                        FROM tblVehicle, tblScheduleLine";

            _DBAccess.Do_SQLQuery(sQuery);

            comboBoxVehicleRegistrationNum.DataSource = _DBAccess.bndSrc;
            comboBoxVehicleRegistrationNum.DisplayMember = "VehicleReg"; //colum you want to show in comboBox
            comboBoxVehicleRegistrationNum.ValueMember = "ScheduleLineID"; //column you want to use in the background (not necessary)!
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
             string sQuery = @"
                        INSERT tblIncident VALUES('" + textBoxNote.Text + "','" + comboBoxVehicleRegistrationNum.ValueMember + "')";

            _DBAccess.Do_SQLQuery(sQuery);

        }
    }
}
