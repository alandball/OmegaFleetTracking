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

            string sGetUsers = @"
                        SELECT UserFirstName, UserLastName, UserCell, UserEmail, UserTypeName 
                        FROM tblUser, tblUserType, tblAuth
                        WHERE tblUser.UserID = tblAuth.UserID AND tblUserType.UserTypeID = tblUser.UserTypeID";

            _DBAccess.Do_SQLQuery(sGetUsers);

            gridViewAllUsers.DataSource = _DBAccess.bndSrc;
            
                
        }

    }
}
