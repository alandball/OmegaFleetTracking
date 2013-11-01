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
    public partial class frmTripManagerAddVehicle : UserControl
    {
        public frmTripManagerAddVehicle()
        {
            InitializeComponent();
        }

        static DBAccess _DBAccess = new DBAccess();

        private void frmTripManagerAddVehicle_Load(object sender, EventArgs e)
        {
            fillGridView();
            buttonAddTrailer.Hide();
        }

        public void fillGridView()
        {
            string sGetVehicles = @"
                        SELECT VehicleID, VehicleReg[Registration], VehicleDesc[Description], VehicleTypeName[VehicleType], CatDesc[Category]
                        FROM tblVehicle, tblCategory, tblVehicleType
                        WHERE tblVehicle.CatID = tblCategory.CatID AND tblVehicle.VehicleTypeID = tblVehicleType.VehicleTypeID 
                        AND tblVehicleType.VehicleTypeID = 1
                        ";

            _DBAccess.Do_SQLQuery(sGetVehicles);

            gridViewAllVehicles.DataSource = _DBAccess.bndSrc;
            gridViewAllVehicles.Columns["VehicleID"].Visible = false;

            sGetVehicles = @"
                        SELECT VehicleID, VehicleReg[Registration], VehicleDesc[Description], VehicleTypeName[VehicleType], CatDesc[Category]
                        FROM tblVehicle, tblCategory, tblVehicleType
                        WHERE tblVehicle.CatID = tblCategory.CatID AND tblVehicle.VehicleTypeID = tblVehicleType.VehicleTypeID 
                        AND tblVehicleType.VehicleTypeID = 2
                        ";

            _DBAccess.Do_SQLQueryAlt(sGetVehicles);
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            if (FleetTracking._frmTripManagerSchT.vehicleID.Count == 0)
            {
                int rowindex = gridViewAllVehicles.CurrentCell.RowIndex; // gets the row
                FleetTracking._frmTripManagerSchT.vehicleID.Add(gridViewAllVehicles.Rows[rowindex].Cells[0].Value.ToString());

                gridViewAllTrailers.DataSource = _DBAccess.bndSrcAlt;
                gridViewAllTrailers.Columns["VehicleID"].Visible = false;


                buttonAddTrailer.Show();
            }
            else
            {
                MessageBox.Show("You have already added a truck");
            }
        }

        private void buttonAddTrailer_Click(object sender, EventArgs e)
        {
            if (FleetTracking._frmTripManagerSchT.vehicleID.Count > 0)
            {
                int rowindex = gridViewAllTrailers.CurrentCell.RowIndex; // gets the row
                FleetTracking._frmTripManagerSchT.vehicleID.Add(gridViewAllTrailers.Rows[rowindex].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Please add a truck first");
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
