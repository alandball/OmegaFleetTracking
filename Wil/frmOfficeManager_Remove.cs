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
    public partial class frmOfficeManager_Remove : UserControl
    {
        public frmOfficeManager_Remove()
        {
            InitializeComponent();
        }

        DBAccess _DBAccess = new DBAccess();

        private void frmOfficeManagerHS_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            string userID = gridViewAllUsers.Rows[gridViewAllUsers.CurrentCell.RowIndex].Cells["UserID"].Value.ToString();
            string sQuery = @"DELETE FROM tblAuth
                            WHERE tblAuth.UserID =" + userID + ";";
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
