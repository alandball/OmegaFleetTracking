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
    public partial class frmVehicleManagerHS : UserControl
    {
        public frmVehicleManagerHS()
        {
            InitializeComponent();
        }
        static DBAccess _DBAccess = new DBAccess();
        private void frmVehicleManagerHS_Load(object sender, EventArgs e)
        {
            string sGetVehicles = @"
                        SELECT VehicleReg[Registration], VehicleVinNumber[Vin Number], VehicleDesc[Description], VehicleKm[KM], CatDesc[Category]
                        FROM tblVehicle, tblCategory
                        WHERE tblVehicle.CatID = tblCategory.CatID
                        ";

            _DBAccess.Do_SQLQuery(sGetVehicles);

            gridViewAllVehicles.DataSource = _DBAccess.bndSrc;
        }
    }
}
