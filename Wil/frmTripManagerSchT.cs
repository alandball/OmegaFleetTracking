using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Wil
{
    public partial class frmTripManagerSchT : UserControl
    {
        DBAccess _DBAccess = new DBAccess();

        public ArrayList storeVehicle = new ArrayList();

        public ArrayList vehicleID = new ArrayList();
        public int TripID = 0;

        public frmTripManagerSchT()
        {
            InitializeComponent();
        }

        private void frmTripManagerSchT_Load(object sender, EventArgs e)
        {
            string sQuery = @"
                        SELECT RTRIM(UserID)[UserID], UserFirstName
                        FROM tblUser
                        WHERE UserTypeID = 6";

            _DBAccess.Do_SQLQuery(sQuery);

            comboBoxChooseDriver.DataSource = _DBAccess.bndSrc;
            comboBoxChooseDriver.DisplayMember = "UserFirstName"; //colum you want to show in comboBox
            comboBoxChooseDriver.ValueMember = "UserID";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (vehicleID != null)
            {
                
                int UserID = Convert.ToInt32(comboBoxChooseDriver.SelectedValue);

                string sQuery = @"
                        INSERT tblScheduleTrip VALUES('" + datePickerDateOfDeparture.Text + "','" + datePickerDateOfArrival.Text + "'," + UserID +
                            ",'" + textBoxDestination.Text + "','" + textBoxNotes.Text + "')";

                _DBAccess.Do_SQLQuery(sQuery);

                sQuery = @"SELECT TOP 1 TripID FROM tblScheduleTrip ORDER BY TripID DESC;";

                _DBAccess.Do_SQLQuery(sQuery);

                int lastTripID = Convert.ToInt16(_DBAccess.dataTbl.Rows[0]["TripID"].ToString());
                
                sQuery = @"
                        INSERT tblScheduleLine VALUES(" + Convert.ToInt32(vehicleID[0]) + "," + lastTripID + ")";

                _DBAccess.Do_SQLQuery(sQuery);

                if (vehicleID.Count > 1)
                {
                    for (int indexVehicleID = 1; indexVehicleID < vehicleID.Count; indexVehicleID++)
                    {
                        sQuery = @"
                        INSERT tblScheduleLine VALUES(" + Convert.ToInt32(vehicleID[indexVehicleID]) + "," + lastTripID + ")";
                        _DBAccess.Do_SQLQuery(sQuery);
                    }
                }

                buttonClear_Click((object)sender, (EventArgs)e);
            }
            else
            {
                MessageBox.Show("Please add at least one vehicle");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            datePickerDateOfDeparture.Value = DateTime.Today;
            datePickerDateOfArrival.Value = DateTime.Today;

            textBoxDestination.Text = "";
            textBoxNotes.Text = "";
            comboBoxChooseDriver.SelectedIndex = -1;
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            FleetTracking._frmTripManagerAddVehicle.Show();
            FleetTracking._frmTripManagerAddVehicle.BringToFront();
        }
    }
}
