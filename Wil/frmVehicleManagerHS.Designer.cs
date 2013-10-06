namespace Wil
{
    partial class frmVehicleManagerHS
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
            this.labelAllVehicles = new System.Windows.Forms.Label();
            this.gridViewAllVehicles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAllVehicles
            // 
            this.labelAllVehicles.AutoSize = true;
            this.labelAllVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllVehicles.Location = new System.Drawing.Point(340, 30);
            this.labelAllVehicles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllVehicles.Name = "labelAllVehicles";
            this.labelAllVehicles.Size = new System.Drawing.Size(102, 20);
            this.labelAllVehicles.TabIndex = 0;
            this.labelAllVehicles.Text = "All Vehicles";
            // 
            // gridViewAllVehicles
            // 
            this.gridViewAllVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewAllVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAllVehicles.Location = new System.Drawing.Point(45, 110);
            this.gridViewAllVehicles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridViewAllVehicles.Name = "gridViewAllVehicles";
            this.gridViewAllVehicles.RowTemplate.Height = 24;
            this.gridViewAllVehicles.Size = new System.Drawing.Size(678, 496);
            this.gridViewAllVehicles.TabIndex = 1;
            // 
            // frmVehicleManagerHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridViewAllVehicles);
            this.Controls.Add(this.labelAllVehicles);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVehicleManagerHS";
            this.Size = new System.Drawing.Size(780, 656);
            this.Load += new System.EventHandler(this.frmVehicleManagerHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAllVehicles;
        private System.Windows.Forms.DataGridView gridViewAllVehicles;
    }
}
