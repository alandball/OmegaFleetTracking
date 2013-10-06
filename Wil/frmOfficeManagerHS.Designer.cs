namespace Wil
{
    partial class frmOfficeManagerHS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAllUsers = new System.Windows.Forms.Label();
            this.gridViewAllUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAllUsers
            // 
            this.labelAllUsers.AutoSize = true;
            this.labelAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllUsers.Location = new System.Drawing.Point(357, 41);
            this.labelAllUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllUsers.Name = "labelAllUsers";
            this.labelAllUsers.Size = new System.Drawing.Size(81, 20);
            this.labelAllUsers.TabIndex = 0;
            this.labelAllUsers.Text = "All Users";
            // 
            // gridViewAllUsers
            // 
            this.gridViewAllUsers.AllowUserToAddRows = false;
            this.gridViewAllUsers.AllowUserToDeleteRows = false;
            this.gridViewAllUsers.AllowUserToResizeColumns = false;
            this.gridViewAllUsers.AllowUserToResizeRows = false;
            this.gridViewAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewAllUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAllUsers.Location = new System.Drawing.Point(50, 91);
            this.gridViewAllUsers.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewAllUsers.Name = "gridViewAllUsers";
            this.gridViewAllUsers.RowTemplate.Height = 24;
            this.gridViewAllUsers.Size = new System.Drawing.Size(675, 513);
            this.gridViewAllUsers.TabIndex = 1;
            // 
            // frmOfficeManagerHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridViewAllUsers);
            this.Controls.Add(this.labelAllUsers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOfficeManagerHS";
            this.Size = new System.Drawing.Size(780, 656);
            this.Load += new System.EventHandler(this.frmOfficeManagerHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAllUsers;
        private System.Windows.Forms.DataGridView gridViewAllUsers;
    }
}
