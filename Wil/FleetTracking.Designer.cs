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
            this.toolStripItemProfile.Name = "toolStripItemProfile";
            this.toolStripItemProfile.Size = new System.Drawing.Size(53, 20);
            this.toolStripItemProfile.Text = "Profile";
            // 
            // toolStripItemReport
            // 
            this.toolStripItemReport.Name = "toolStripItemReport";
            this.toolStripItemReport.Size = new System.Drawing.Size(54, 20);
            this.toolStripItemReport.Text = "Report";
            // 
            // toolStripItemAbout
            // 
            this.toolStripItemAbout.Name = "toolStripItemAbout";
            this.toolStripItemAbout.Size = new System.Drawing.Size(52, 20);
            this.toolStripItemAbout.Text = "About";
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

