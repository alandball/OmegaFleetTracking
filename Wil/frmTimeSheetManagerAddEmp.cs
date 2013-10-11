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
    public partial class frmTimeSheetManagerAddEmp : UserControl
    {
        public frmTimeSheetManagerAddEmp()
        {
            InitializeComponent();
        }

        DBAccess _DBAccess = new DBAccess();


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            string sInsertUser = String.Format(@"
                                    INSERT tblUser VALUES 
                                    ('{0}', '{1}', '{2}', '{3}', {4})
                                               ", textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxEmail.Text, comboBoxType.SelectedValue);

            _DBAccess.Do_SQLQuery(sInsertUser);

            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxEmail.Clear();
        }

        private void frmTimeSheetManagerAddEmp_Load(object sender, EventArgs e)
        {
            fillComboBox();
            comboBoxType.SelectedIndex = -1;
        }

        public void fillComboBox()
        {
            

            string sGetType = @"
                        SELECT LTrim(RTrim(UserTypeID))[UserTypeID], LTrim(RTrim(UserTypeName))[UserTypeName]
                        FROM tblUserType
                        ";

            _DBAccess.Do_SQLQuery(sGetType);

            comboBoxType.DataSource = _DBAccess.bndSrc;
            comboBoxType.DisplayMember = "UserTypeName"; //column you want to show in comboBox
            comboBoxType.ValueMember = "UserTypeID"; //column you want to use in the background (not necessary)!

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxEmail.Clear();
            comboBoxType.SelectedIndex = -1;
        }
    }
}
