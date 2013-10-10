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
    public partial class frmOfficeManager_AddUser : UserControl
    {
        public frmOfficeManager_AddUser()
        {
            InitializeComponent();
        }

        DBAccess doSQL = new DBAccess();

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string doSqlQ;

            if (buttonAddUser.Text.CompareTo("Add User") == 0)
            {
                bool input = checkInput();

                if (input)
                {
                    try
                    {
                        doSqlQ = String.Format(@"insert into tblUser values('{0}', '{1}', '{2}', '{3}', {4});", textBoxName.Text, textBoxLastName.Text, textBoxCellNumber.Text, textBoxEmail.Text, (comboBoxUserType.SelectedIndex + 1));
                        doSQL.Do_SQLQuery(doSqlQ);
                        MessageBox.Show( String.Format("User {0} was added successfully", textBoxName.Text));
                    }
                    catch(Exception eX)
                    {
                        MessageBox.Show("An error has occured: " + eX);
                    }
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
            else if (textBoxLastName.Text.Equals(null) || textBoxLastName.Text.Length > 35)
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxLastName.Text = "";
            textBoxCellNumber.Text = "";
            textBoxEmail.Text = "";
        }
    }
}
