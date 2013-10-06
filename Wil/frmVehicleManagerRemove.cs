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
    public partial class frmVehicleManagerRemove : UserControl
    {
        public frmVehicleManagerRemove()
        {
            InitializeComponent();
        }

        static DBAccess _DBAccess = new DBAccess();

        public void fillComboBox()
        {
            string sGetVehicles = @"
                        SELECT VehicleID, LTrim(RTrim(VehicleReg))[VehicleReg], VehicleVinNumber, VehicleDesc, VehicleKm, VehicleTypeName, LTrim(RTrim(CatDesc))[CatDesc]
                        FROM tblVehicle, tblCategory, tblVehicleType
                        WHERE tblVehicle.CatID = tblCategory.CatID AND tblVehicleType.VehicleTypeID = tblVehicle.VehicleTypeID
                        ";

            _DBAccess.Do_SQLQuery(sGetVehicles);

            comboBoxSearchReg.DataSource = _DBAccess.bndSrc;
            comboBoxSearchReg.DisplayMember = "VehicleReg"; //column you want to show in comboBox
            comboBoxSearchReg.ValueMember = "VehicleID"; //column you want to use in the background (not necessary)!
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string sDeleteVehicle = String.Format(@"
                        DELETE FROM tblVehicle
                        WHERE tblVehicle.VehicleID = {0}
                        ", comboBoxSearchReg.SelectedValue);

            _DBAccess.Do_SQLQueryAlt(sDeleteVehicle);
        }
    }
}
