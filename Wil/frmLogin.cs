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
    public partial class frmLogin : UserControl
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        DBAccess _DBAccess = new DBAccess();

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _DBAccess.Do_SQLQuery("SELECT AuthID, AuthUserName, AuthPassword FROM tblAuth WHERE AuthUserName ='" + textBoxUserName.Text + "'");

            if (_DBAccess.dataTbl.Rows.Count > 0)
            {
                if (textBoxPassword.Text.Equals(_DBAccess.dataTbl.Rows[0]["AuthPassword"].ToString().Trim()))
                {
                    this.Hide();
                    switch (int.Parse(_DBAccess.dataTbl.Rows[0]["AuthID"].ToString().Trim()))
                    {
                        // Check to see which user group you are in and then open the right controls.
                        case 1:
                            FleetTracking._frmOfficeManagerHS.Show();
                            FleetTracking._frmOfficeManagerMenu.Show();
                            break;
                        case 2:
                            FleetTracking._frmVehicleManagerHS.Show();
                            FleetTracking._frmVehicleManagerMenu.Show();
                            break;
                        case 3:
                            FleetTracking._frmTripManagerHS.Show();
                            FleetTracking._frmTripManagerMenu.Show();
                            break;
                        case 4:
                            FleetTracking._frmServiceManagerHS.Show();
                            FleetTracking._frmServiceManagerMenu.Show();
                            break;
                        case 5:
                            FleetTracking._frmTimeSheetManagerHS.Show();
                            FleetTracking._frmTimeSheetManagerMenu.Show();
                            break;
                    }
                    _DBAccess.dataTbl.Clear();
                    textBoxPassword.Clear();// unnecessary
                    textBoxUserName.Clear();// unnecessary as login gets hidden, move this to if login failed? not really wanted either, perhaps just clear the password textbox
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username");
            }
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
