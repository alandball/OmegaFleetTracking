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
    public partial class frmTimeSheetManagerHS : UserControl
    {
        public frmTimeSheetManagerHS()
        {
            InitializeComponent();
        }

        DBAccess _DBAccess = new DBAccess();

        private void frmTimeSheetManagerHS_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        public void fillGridView()
        {
            string sGetDrivers = @"
                        SELECT UserFirstName[First Name], UserLastName[Last Name], UserCell[Cell], UserEmail[Email], tblHours.EmployeeHours[Hours], tblUser.UserID, tblUser.UserTypeID
                        FROM tblUser, tblUserType, tblHours
                        WHERE tblUser.UserTypeID = tblUserType.UserTypeID AND tblUser.UserID = tblHours.UserID And tblUser.UserTypeID = 6
                        ";

            string sGetMechanics = @"
                        SELECT UserFirstName[First Name], UserLastName[Last Name], UserCell[Cell], UserEmail[Email], tblHours.EmployeeHours[Hours], tblUser.UserID, tblUser.UserTypeID
                        FROM tblUser, tblUserType, tblHours
                        WHERE tblUser.UserTypeID = tblUserType.UserTypeID AND tblUser.UserID = tblHours.UserID And tblUser.UserTypeID = 7
                        ";

            _DBAccess.Do_SQLQuery(sGetDrivers);
            _DBAccess.Do_SQLQueryAlt(sGetMechanics);

            gridViewDriverTotals.DataSource = _DBAccess.bndSrc;
            gridViewMechanicsTotals.DataSource = _DBAccess.bndSrcAlt;

        }
    }
}
