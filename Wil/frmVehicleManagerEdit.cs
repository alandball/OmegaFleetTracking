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
    public partial class frmVehicleManagerEdit : UserControl
    {
        public frmVehicleManagerEdit()
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

            comboBoxSeachReg.DataSource = _DBAccess.bndSrc;
            comboBoxSeachReg.DisplayMember = "VehicleReg"; //column you want to show in comboBox
            comboBoxSeachReg.ValueMember = "VehicleID"; //column you want to use in the background (not necessary)!

        }

        private void frmVehicleManagerEdit_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSeachReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hack to stop combo box method firing when populated.
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;                
            }
            // Here is your Code for selection change


                string sGetVehicle = String.Format(@"
                        SELECT LTrim(RTrim(VehicleID))[VehicleID], LTrim(RTrim(VehicleReg))[VehicleReg], LTrim(RTrim(VehicleVinNumber))[VehicleVinNumber],  LTrim(RTrim(VehicleDesc))[VehicleDesc],LTrim(RTrim(VehicleKm))[VehicleKm] , LTrim(RTrim(VehicleTypeName))[VehicleTypeName], CatDesc, tblVehicle.CatID, tblVehicle.VehicleTypeID
                        FROM tblVehicle, tblCategory, tblVehicleType
                        WHERE tblVehicle.CatID = tblCategory.CatID AND tblVehicleType.VehicleTypeID = tblVehicle.VehicleTypeID AND tblVehicle.VehicleID = {0}
                        ", comboBoxSeachReg.SelectedValue);

                _DBAccess.Do_SQLQueryAlt(sGetVehicle);

                textBoxRegNumber.Text = _DBAccess.dataTblAlt.Rows[0]["VehicleReg"].ToString();
                textBoxVinNumber.Text = _DBAccess.dataTblAlt.Rows[0]["VehicleVinNumber"].ToString();
                textBoxVehDesc.Text = _DBAccess.dataTblAlt.Rows[0]["VehicleDesc"].ToString();
                textBoxVehKM.Text = _DBAccess.dataTblAlt.Rows[0]["VehicleKm"].ToString();
                textBoxVehCat.Text = _DBAccess.dataTblAlt.Rows[0]["CatDesc"].ToString();

                textBoxTruckTrailer.Text = _DBAccess.dataTblAlt.Rows[0]["VehicleTypeName"].ToString(); 
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string sUpdateVehicle = String.Format(
                @"UPDATE tblVehicle
                SET VehicleReg={0}, VehicleVinNumber={1}, VehicleDesc='{2}', VehicleKm={3}, VehicleTypeID={4}, CatID={5}
                      WHERE tblVehicle.VehicleID = {6}
                        ", textBoxRegNumber.Text, textBoxVinNumber.Text, textBoxVehDesc.Text.Trim(), textBoxVehKM.Text, int.Parse(_DBAccess.dataTblAlt.Rows[0]["VehicleTypeID"].ToString()), int.Parse(_DBAccess.dataTblAlt.Rows[0]["CatID"].ToString()), comboBoxSeachReg.SelectedValue);

            _DBAccess.Do_SQLQuery(sUpdateVehicle);

            textBoxRegNumber.Clear();
            textBoxVinNumber.Clear();
            textBoxVehDesc.Clear();
            textBoxVehKM.Clear();
            textBoxVehCat.Clear();

            fillComboBox();
        }

    }
}
