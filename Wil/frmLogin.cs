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
            if (true)
            {
                this.Hide();
                FleetTracking._frmVehicleManagerHS.Show();
                FleetTracking._frmVehicleManagerMenu.Show();
            }
            else
            {
                _DBAccess.Do_SQLQuery("SELECT UserTypeID, AuthUserName, AuthPassword FROM tblAuth WHERE AuthUserName ='" + textBoxUserName.Text + "'");

                if (_DBAccess.dataTbl.Rows.Count > 0)
                {
                    if (textBoxPassword.Text.Equals(_DBAccess.dataTbl.Rows[0]["AuthPassword"].ToString().Trim()))
                    {
                        //MessageBox.Show("Login");
                        this.Hide();
                        switch (int.Parse(_DBAccess.dataTbl.Rows[0]["UserTypeID"].ToString().Trim()))
                        {
                            // Check to see which user group you are in and then open the right controls.
                            case 1:
                                FleetTracking._frmOfficeManagerHS.Show();
                                FleetTracking._frmOfficeManagerMenu.Show();
                                break;
                            case 2:
                                FleetTracking._frmOfficeManagerHS.Show();
                                FleetTracking._frmOfficeManagerMenu.Show();
                                break;
                            case 3:
                                FleetTracking._frmOfficeManagerHS.Show();
                                FleetTracking._frmOfficeManagerMenu.Show();
                                break;
                            case 4:
                                FleetTracking._frmOfficeManagerHS.Show();
                                FleetTracking._frmOfficeManagerMenu.Show();
                                break;
                            case 5:
                                FleetTracking._frmOfficeManagerHS.Show();
                                FleetTracking._frmOfficeManagerMenu.Show();
                                break;
                        }

                        _DBAccess.dataTbl.Clear();
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

        }
    }
}
