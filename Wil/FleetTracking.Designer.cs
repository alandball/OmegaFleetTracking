namespace Wil
{
    partial class FleetTracking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.toolStripItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MnuItmSwitchUser = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleStatusReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceRequirementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceCompletionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificServiceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plannedTripReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeTripReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesheetReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemFile,
            this.toolStripItemEdit,
            this.toolStripItemProfile,
            this.toolStripItemReport,
            this.toolStripItemAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1008, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // toolStripItemFile
            // 
            this.toolStripItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItmSwitchUser,
            this.exitToolStripMenuItem});
            this.toolStripItemFile.Name = "toolStripItemFile";
            this.toolStripItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripItemFile.Text = "File";
            // 
            // toolStripItemEdit
            // 
            this.toolStripItemEdit.Name = "toolStripItemEdit";
            this.toolStripItemEdit.Size = new System.Drawing.Size(39, 20);
            this.toolStripItemEdit.Text = "Edit";
            // 
            // toolStripItemProfile
            // 
            this.toolStripItemProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem});
            this.toolStripItemProfile.Name = "toolStripItemProfile";
            this.toolStripItemProfile.Size = new System.Drawing.Size(53, 20);
            this.toolStripItemProfile.Text = "Profile";
            // 
            // toolStripItemReport
            // 
            this.toolStripItemReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleStatusReportToolStripMenuItem,
            this.serviceListToolStripMenuItem,
            this.serviceRequirementsToolStripMenuItem,
            this.serviceCompletionReportToolStripMenuItem,
            this.specificServiceReportToolStripMenuItem,
            this.plannedTripReportToolStripMenuItem,
            this.completeTripReportToolStripMenuItem,
            this.timesheetReportToolStripMenuItem});
            this.toolStripItemReport.Name = "toolStripItemReport";
            this.toolStripItemReport.Size = new System.Drawing.Size(54, 20);
            this.toolStripItemReport.Text = "Report";
            // 
            // toolStripItemAbout
            // 
            this.toolStripItemAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripItemAbout.Name = "toolStripItemAbout";
            this.toolStripItemAbout.Size = new System.Drawing.Size(44, 20);
            this.toolStripItemAbout.Text = "Help";
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Controls.Add(this.panelMenu);
            this.panelContainer.ForeColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(0, 27);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1008, 701);
            this.panelContainer.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMain.Location = new System.Drawing.Point(225, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(780, 656);
            this.panelMain.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Location = new System.Drawing.Point(2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 656);
            this.panelMenu.TabIndex = 0;
            // 
            // MnuItmSwitchUser
            // 
            this.MnuItmSwitchUser.Name = "MnuItmSwitchUser";
            this.MnuItmSwitchUser.Size = new System.Drawing.Size(152, 22);
            this.MnuItmSwitchUser.Text = "Switch User";
            this.MnuItmSwitchUser.Click += new System.EventHandler(this.MnuItmSwitchUser_Click);
            // 
            // vehicleStatusReportToolStripMenuItem
            // 
            this.vehicleStatusReportToolStripMenuItem.Name = "vehicleStatusReportToolStripMenuItem";
            this.vehicleStatusReportToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.vehicleStatusReportToolStripMenuItem.Text = "Vehicle Status Report";
            // 
            // serviceListToolStripMenuItem
            // 
            this.serviceListToolStripMenuItem.Name = "serviceListToolStripMenuItem";
            this.serviceListToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.serviceListToolStripMenuItem.Text = "Service List Report";
            // 
            // serviceRequirementsToolStripMenuItem
            // 
            this.serviceRequirementsToolStripMenuItem.Name = "serviceRequirementsToolStripMenuItem";
            this.serviceRequirementsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.serviceRequirementsToolStripMenuItem.Text = "Service Requirements Report";
            // 
            // serviceCompletionReportToolStripMenuItem
            // 
            this.serviceCompletionReportToolStripMenuItem.Name = "serviceCompletionReportToolStripMenuItem";
            this.serviceCompletionReportToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.serviceCompletionReportToolStripMenuItem.Text = "Service Completion Report";
            // 
            // specificServiceReportToolStripMenuItem
            // 
            this.specificServiceReportToolStripMenuItem.Name = "specificServiceReportToolStripMenuItem";
            this.specificServiceReportToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.specificServiceReportToolStripMenuItem.Text = "Specific Service Report";
            // 
            // plannedTripReportToolStripMenuItem
            // 
            this.plannedTripReportToolStripMenuItem.Name = "plannedTripReportToolStripMenuItem";
            this.plannedTripReportToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.plannedTripReportToolStripMenuItem.Text = "Planned Trip Report";
            // 
            // completeTripReportToolStripMenuItem
            // 
            this.completeTripReportToolStripMenuItem.Name = "completeTripReportToolStripMenuItem";
            this.completeTripReportToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.completeTripReportToolStripMenuItem.Text = "Complete Trip Report";
            // 
            // timesheetReportToolStripMenuItem
            // 
            this.timesheetReportToolStripMenuItem.Name = "timesheetReportToolStripMenuItem";
            this.timesheetReportToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.timesheetReportToolStripMenuItem.Text = "Timesheet Report";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FleetTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 689);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.mnuMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FleetTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Omega Technologies Fleet Tracking";
            this.Load += new System.EventHandler(this.FleetTracking_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemProfile;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemReport;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemAbout;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuItmSwitchUser;
        private System.Windows.Forms.ToolStripMenuItem vehicleStatusReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceRequirementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceCompletionReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificServiceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plannedTripReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeTripReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesheetReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

