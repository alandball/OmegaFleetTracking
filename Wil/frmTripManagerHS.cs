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
    public partial class frmTripManagerHS : UserControl
    {
        public frmTripManagerHS()
        {
            InitializeComponent();
        }

        DBAccess _DBAccess = new DBAccess();
        DBAccess _aDBAccess = new DBAccess();
        DBAccess _bDBAccess = new DBAccess();

        private void frmTripManagerHS_Load(object sender, EventArgs e)
        {
            fillDataGrids();
        }

        public void fillDataGrids()
        {
            
            string sSchedule = @"
                        SELECT tblScheduleTrip.Destination, tblScheduleTrip.DOD[Date Of Departure], tblScheduleTrip.DOA[Date Of Arrival], tblScheduleTrip.Notes[Notes], tblUser.UserFirstName[Employee Name] 
                        FROM tblScheduleTrip, tblUser
                        WHERE tblScheduleTrip.UserID = tblUser.UserID";

            _DBAccess.Do_SQLQuery(sSchedule);

            gridViewSchedule.DataSource = _DBAccess.bndSrc;
           
            string sIncidence = @"
                        SELECT tblIncident.Notes, tblVehicle.VehicleReg[Vehicle Registration Number], tblScheduleTrip.DOD[Date Of Departure]
                        FROM tblIncident, tblVehicle, tblScheduleTrip, tblScheduleLine
                        WHERE tblIncident.ScheduleLineID = tblScheduleLine.ScheduleLineID
                        AND tblVehicle.VehicleID = tblScheduleLine.VehicleID
                        AND tblScheduleTrip.TripID = tblScheduleLine.TripID";

            _aDBAccess.Do_SQLQuery(sIncidence);

            gridViewIncidence.DataSource = _aDBAccess.bndSrc;
            
            string sTripCompleted = @"SELECT tblScheduleTrip.Destination, tblScheduleTrip.DOD[Date Of Departure], tblScheduleTrip.DOA[Date Of Arrival], tblPostTrip.FuelUsage[Fuel Usage]
                        FROM tblScheduleTrip, tblPostTrip
                        WHERE tblPostTrip.TripID = tblScheduleTrip.TripID
						and tblScheduleTrip.DOA < DATEADD(day, DATEDIFF(day,0,GETDATE()),0)";

            _bDBAccess.Do_SQLQuery(sTripCompleted);

            gridViewTripCompleted.DataSource = _bDBAccess.bndSrc;
        }
    }
}
