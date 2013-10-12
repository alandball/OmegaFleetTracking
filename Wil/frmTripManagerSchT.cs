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
    public partial class frmTripManagerSchT : UserControl
    {
        DBAccess _DBAccess = new DBAccess();

        public frmTripManagerSchT()
        {
            InitializeComponent();
        }

        private void frmTripManagerSchT_Load(object sender, EventArgs e)
        {
            string sQuery = @"
                        SELECT RTRIM(UserID)[UserID], UserFirstName
                        FROM tblUser
                        WHERE UserTypeID = 6";

            _DBAccess.Do_SQLQuery(sQuery);

            comboBoxChooseID.DataSource = _DBAccess.bndSrc;
            comboBoxChooseID.DisplayMember = "UserFirstName"; //colum you want to show in comboBox
            comboBoxChooseID.ValueMember = "UserID";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(comboBoxChooseID.SelectedValue);

            string sQuery = @"
                        INSERT tblScheduleTrip VALUES('" + datePickerDateOfDeparture.Text + "','" + datePickerDateOfArrival.Text + "'," + UserID +
                        ",'" + textBoxDestination.Text + "','" + textBoxNotes.Text + "')";

            _DBAccess.Do_SQLQuery(sQuery);
        }

        

    }
}
