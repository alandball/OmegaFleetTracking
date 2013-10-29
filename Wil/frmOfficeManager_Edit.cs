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
    public partial class frmOfficeManager_Edit : UserControl
    {
        public frmOfficeManager_Edit()
        {
            InitializeComponent();
        }

        DBAccess _DBAccess = new DBAccess();

        private void frmOfficeManagerHS_Load(object sender, EventArgs e)
        {
            
            reload();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            string userID = gridViewAllUsers.Rows[gridViewAllUsers.CurrentCell.RowIndex].Cells["UserID"].Value.ToString();
            string sQuery = string.Format(@"UPDATE tblUser
                                            SET UserFirstName='{0}', UserLastName='{1}', UserCell='{2}', UserEmail='{3}', UserTypeID='{4}'
                                            WHERE tblUser.UserID = {5};", );
            _DBAccess.Do_SQLQueryAlt(sQuery);

            sQuery = @"DELETE FROM tblUser
                    WHERE tblUser.UserID =" + userID + ";";
            _DBAccess.Do_SQLQueryAlt(sQuery);

            MessageBox.Show("User was removed");

            reload();
        }

        public void reload()
        {
            string sGetUsers = @"
                        SELECT tblUser.UserID, UserFirstName, UserLastName, UserCell, UserEmail, UserTypeName 
                        FROM tblUser, tblUserType, tblAuth
                        WHERE tblUser.UserID = tblAuth.UserID AND tblUserType.UserTypeID = tblUser.UserTypeID";

            _DBAccess.Do_SQLQuery(sGetUsers);

            gridViewAllUsers.DataSource = _DBAccess.bndSrc;

            gridViewAllUsers.Columns[0].Visible = false;
        }

    }
}
