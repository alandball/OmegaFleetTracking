using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Wil
{
    public partial class FleetTracking : Form
    {
        public static frmLogin _frmLogin = new frmLogin();
        public static frmOfficeManagerHS _frmOfficeManagerHS = new frmOfficeManagerHS();
        public static frmOfficeManager_AddUser _frmOfficeManagerAddUser = new frmOfficeManager_AddUser();
        public static frmOfficeManager_Remove _frmOfficeManager_Remove = new frmOfficeManager_Remove();
        public static frmOfficeManager_Edit _frmOfficeManager_Edit = new frmOfficeManager_Edit();
        public static frmOfficeManagerMenu _frmOfficeManagerMenu = new frmOfficeManagerMenu();
        public static frmServiceManagerHS _frmServiceManagerHS = new frmServiceManagerHS();
        public static frmServiceManagerMenu _frmServiceManagerMenu = new frmServiceManagerMenu();
        public static frmServiceManagerSS _frmServiceManagerSS = new frmServiceManagerSS();
        public static frmTimeSheetManagerAddEmp _frmTimeSheetManagerAddEmp = new frmTimeSheetManagerAddEmp();
        public static frmTimeSheetManagerEnterHr _frmTimeSheetManagerEnterHr = new frmTimeSheetManagerEnterHr();
        public static frmTimeSheetManagerHS _frmTimeSheetManagerHS = new frmTimeSheetManagerHS();
        public static frmTimeSheetManagerMenu _frmTimeSheetManagerMenu = new frmTimeSheetManagerMenu();
        public static frmTripManagerHS _frmTripManagerHS = new frmTripManagerHS();
        public static frmTripManagerMenu _frmTripManagerMenu = new frmTripManagerMenu();
        public static frmTripManagerSchT _frmTripManagerSchT = new frmTripManagerSchT();
        public static frmTripManagerTripComp _frmTripManagerTripComp = new frmTripManagerTripComp();
        public static frmTripManagerTripIncidents _frmTripManagerTripIncidents = new frmTripManagerTripIncidents();
        public static frmTripManagerAddVehicle _frmTripManagerAddVehicle = new frmTripManagerAddVehicle();
        public static frmVehicleManager _frmVehicleManager = new frmVehicleManager();
        public static frmVehicleManagerHS _frmVehicleManagerHS = new frmVehicleManagerHS();
        public static frmVehicleManagerMenu _frmVehicleManagerMenu = new frmVehicleManagerMenu();
        public static frmVehicleManagerEdit _frmVehicleManagerEdit = new frmVehicleManagerEdit();
        public static frmVehicleManagerRemove _frmVehicleManagerRemove = new frmVehicleManagerRemove();

        public FleetTracking()
        {
            InitializeComponent();            
        }

        private void FleetTracking_Load(object sender, EventArgs e)
        {
            //this is rediculous, change to addrange by creating an array of the panels. in properties set all controls to show false
            panelMain.Controls.Add(_frmLogin);
            _frmLogin.Show();
            panelMain.Controls.Add(_frmOfficeManagerHS);
            _frmOfficeManagerHS.Hide();
            panelMain.Controls.Add(_frmOfficeManagerAddUser);
            _frmOfficeManagerAddUser.Hide();
            panelMain.Controls.Add(_frmOfficeManager_Remove);
            _frmOfficeManager_Remove.Hide();
            panelMain.Controls.Add(_frmOfficeManager_Edit);
            _frmOfficeManager_Edit.Hide();
            panelMenu.Controls.Add(_frmOfficeManagerMenu);
            _frmOfficeManagerMenu.Hide();
            panelMain.Controls.Add(_frmServiceManagerHS);
            _frmServiceManagerHS.Hide();
            panelMenu.Controls.Add(_frmServiceManagerMenu);
            _frmServiceManagerMenu.Hide();
            panelMain.Controls.Add(_frmServiceManagerSS);
            _frmServiceManagerSS.Hide();
            panelMain.Controls.Add(_frmTimeSheetManagerAddEmp);
            _frmTimeSheetManagerAddEmp.Hide();
            panelMain.Controls.Add(_frmTimeSheetManagerEnterHr);
            _frmTimeSheetManagerEnterHr.Hide();
            panelMain.Controls.Add(_frmTimeSheetManagerHS);
            _frmTimeSheetManagerHS.Hide();
            panelMenu.Controls.Add(_frmTimeSheetManagerMenu);
            _frmTimeSheetManagerMenu.Hide();
            panelMain.Controls.Add(_frmTripManagerHS);
            _frmTripManagerHS.Hide();
            panelMenu.Controls.Add(_frmTripManagerMenu);
            _frmTripManagerMenu.Hide();
            panelMain.Controls.Add(_frmTripManagerSchT);
            _frmTripManagerSchT.Hide();
            panelMain.Controls.Add(_frmTripManagerTripComp);
            _frmTripManagerTripComp.Hide();
            panelMain.Controls.Add(_frmTripManagerTripIncidents);
            _frmTripManagerTripIncidents.Hide();
            panelMain.Controls.Add(_frmTripManagerAddVehicle);
            _frmTripManagerAddVehicle.Hide();
            panelMain.Controls.Add(_frmVehicleManager);
            _frmVehicleManager.Hide();
            panelMain.Controls.Add(_frmVehicleManagerHS);
            _frmVehicleManagerHS.Hide();
            panelMenu.Controls.Add(_frmVehicleManagerMenu);
            _frmVehicleManagerMenu.Hide();
            panelMain.Controls.Add(_frmVehicleManagerEdit);
            _frmVehicleManagerEdit.Hide();
            panelMain.Controls.Add(_frmVehicleManagerRemove);
            _frmVehicleManagerEdit.Hide();   
        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }//Method OnFormClosing

        private void open_Main_Window()
        {
            System.Threading.Thread mainWindow = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadMainform));// Start a new thread for main form to exist in
            mainWindow.Start();
        }

        public static void ThreadMainform()
        {
            //Application.Run(new MainWindow(doLogin));
        }

        private void MnuItmSwitchUser_Click(object sender, EventArgs e)
        {
            _frmOfficeManagerHS.Hide();
            _frmOfficeManagerAddUser.Hide();
            _frmOfficeManager_Remove.Hide();
            _frmOfficeManagerMenu.Hide();
            _frmServiceManagerHS.Hide();
            _frmServiceManagerMenu.Hide();
            _frmServiceManagerSS.Hide();
            _frmTimeSheetManagerAddEmp.Hide();
            _frmTimeSheetManagerEnterHr.Hide();
            _frmTimeSheetManagerHS.Hide();
            _frmTimeSheetManagerMenu.Hide();
            _frmTripManagerHS.Hide();
            _frmTripManagerMenu.Hide();
            _frmTripManagerSchT.Hide();
            _frmTripManagerTripComp.Hide();
            _frmTripManagerTripIncidents.Hide();
            _frmTripManagerAddVehicle.Hide();
            _frmVehicleManager.Hide();
            _frmVehicleManagerHS.Hide();
            _frmVehicleManagerMenu.Hide();
            _frmVehicleManagerEdit.Hide();
            _frmVehicleManagerEdit.Hide();   
                
            _frmLogin.Show();
            _frmLogin.BringToFront();

        }
    }
}
