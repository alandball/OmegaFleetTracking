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
    public partial class frmTripManagerTripComp : UserControl
    {
        DBAccess _DBAccess = new DBAccess();

        public frmTripManagerTripComp()
        {
            InitializeComponent();
        }

        private void frmTripManagerTripComp_Load(object sender, EventArgs e)
        {
            string sQuery = @"
                        SELECT RTRIM(tblScheduleTrip.DOD)[DOD]
                        FROM tblScheduleTrip";

            _DBAccess.Do_SQLQuery(sQuery);

            //datePickerDateOfDeparture = _DBAccess.bndSrc;
            //datePickerDateOfDeparture.DisplayMember = "DOD"; //colum you want to show in comboBox
            //datePickerDateOfDeparture.ValueMember = "ScheduleLineID"; //column you want to use in the background (not necessary)!

            string sQueryA = @"
                        SELECT RTRIM(Destination)[Destination],  TripID
                        FROM tblScheduleTrip";

            _DBAccess.Do_SQLQuery(sQueryA);

            comboBoxDestination.DataSource = _DBAccess.bndSrc;
            comboBoxDestination.DisplayMember = "Destination"; //colum you want to show in comboBox
            comboBoxDestination.ValueMember = "TripID"; //column you want to use in the background (not necessary)!

            string sQueryB = @"
                        SELECT RTRIM(VehicleReg)[VehicleReg], tblScheduleLine.ScheduleLineID
                        FROM tblVehicle, tblScheduleLine";

            _DBAccess.Do_SQLQuery(sQueryB);

            comboBoxVehicleRegistrationNum.DataSource = _DBAccess.bndSrc;
            comboBoxVehicleRegistrationNum.DisplayMember = "VehicleReg"; //colum you want to show in comboBox
            comboBoxVehicleRegistrationNum.ValueMember = "ScheduleLineID"; //column you want to use in the background (not necessary)!
                        
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //string sQuery = @"
              //          INSERT tblIncident VALUES('" + textBoxNote.Text + "','" + comboBoxVehicleRegistrationNum.ValueMember + "')";

          //  _DBAccess.Do_SQLQuery(sQuery);
        }
    }
}
