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

            string sQuery = @"select tblScheduleLine.ScheduleLineID, ('Delivery date: ' + rtrim(tblScheduleTrip.DOD) + ', Vehicle Desc: ' + rtrim(tblVehicle.VehicleDesc) + ', Cargo: ' + rtrim( convert( char(100), tblScheduleTrip.Notes) ) )[Info]
                            from tblScheduleLine, tblScheduleTrip, tblVehicle
                            where tblScheduleLine.TripID  = tblScheduleTrip.TripID
                            and tblScheduleLine.VehicleID = tblVehicle.VehicleID";

            _DBAccess.Do_SQLQuery(sQuery);

            comboBoxTripLineNum.DataSource = _DBAccess.bndSrc;
            comboBoxTripLineNum.DisplayMember = "Info"; //colum you want to show in comboBox
            comboBoxTripLineNum.ValueMember = "ScheduleLineID"; //column you want to use in the background (not necessary)!
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxTripLineNum.ValueMember);
             //string sQuery = @"INSERT tblIncident VALUES('" + textBoxNote.Text + "','" + comboBoxTripLineNum.ValueMember + "')";

            //_DBAccess.Do_SQLQuery(sQuery);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxTripLineNum.SelectedIndex = 0;
            textBoxNote.Text = "";
        }
    }
}
