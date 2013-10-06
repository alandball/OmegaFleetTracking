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
    public partial class frmOfficeManager : UserControl
    {
        public frmOfficeManager()
        {
            InitializeComponent();
        }
        DBAccess doSQL = new DBAccess();
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string doSqlQ;

            if (buttonSubmit.Text.CompareTo("Add User") == 0)
            {
                bool input = checkInput();

                if (input)
                {
                    doSqlQ = String.Format(@"insert into tblUser values('{0}', '{1}', '{2}', '{3}', {4});", textBoxName.Text, textBoxSurname.Text, textBoxCellNumber.Text, textBoxEmail.Text, (comboBoxUserType.SelectedIndex + 1));
                    doSQL.Do_SQLQuery(doSqlQ);


                    MessageBox.Show( String.Format("User {0} was added successfully", textBoxName.Text));
                }
                else
                {
                    MessageBox.Show("Please fill in all details");
                }
            }
        }

        private bool checkInput()
        {
            if (textBoxName.Text.Equals(null) || textBoxName.Text.Length > 35)
            {
                return false;
            }
            else if (textBoxSurname.Text.Equals(null) || textBoxSurname.Text.Length > 35)
            {
                return false;
            }
            else if (textBoxEmail.Text.Equals(null) || textBoxEmail.Text.Length > 35)
            {
                return false;
            }
            else if (textBoxCellNumber.Text.Equals(null) || textBoxCellNumber.Text.Length > 10)
            {
                return false;
            }
            else if (comboBoxUserType.SelectedIndex == -1)
            {
                return false;
            }
            else
                return true;
        }

    }
}
