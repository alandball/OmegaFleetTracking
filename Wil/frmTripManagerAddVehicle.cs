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

            gridViewAllTrailers.DataSource = _DBAccess.bndSrcAlt;
            gridViewAllTrailers.Columns["VehicleID"].Visible = false;

        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {

            int rowindex = gridViewAllVehicles.CurrentCell.RowIndex; // gets the row
            int columnindex = gridViewAllVehicles.CurrentCell.ColumnIndex; // gets the column

            MessageBox.Show(gridViewAllVehicles.Rows[rowindex].Cells[0].Value.ToString()); // gets the value in that row and column. So 1 - 1 or vehicle registration
        }

        private void buttonAddTrailer_Click(object sender, EventArgs e)
        {

        }
    }
}
