namespace Wil
{
    partial class frmTimeSheetManagerHS
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
            this.gridViewDriverTotals = new System.Windows.Forms.DataGridView();
            this.gridViewMechanicsTotals = new System.Windows.Forms.DataGridView();
            this.labelDriverTotals = new System.Windows.Forms.Label();
            this.labelMechanicsTotals = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDriverTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMechanicsTotals)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewDriverTotals
            // 
            this.gridViewDriverTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDriverTotals.Location = new System.Drawing.Point(230, 93);
            this.gridViewDriverTotals.Name = "gridViewDriverTotals";
            this.gridViewDriverTotals.RowTemplate.Height = 24;
            this.gridViewDriverTotals.Size = new System.Drawing.Size(539, 209);
            this.gridViewDriverTotals.TabIndex = 0;
            // 
            // gridViewMechanicsTotals
            // 
            this.gridViewMechanicsTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMechanicsTotals.Location = new System.Drawing.Point(230, 414);
            this.gridViewMechanicsTotals.Name = "gridViewMechanicsTotals";
            this.gridViewMechanicsTotals.RowTemplate.Height = 24;
            this.gridViewMechanicsTotals.Size = new System.Drawing.Size(539, 231);
            this.gridViewMechanicsTotals.TabIndex = 1;
            // 
            // labelDriverTotals
            // 
            this.labelDriverTotals.AutoSize = true;
            this.labelDriverTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDriverTotals.Location = new System.Drawing.Point(449, 59);
            this.labelDriverTotals.Name = "labelDriverTotals";
            this.labelDriverTotals.Size = new System.Drawing.Size(119, 20);
            this.labelDriverTotals.TabIndex = 2;
            this.labelDriverTotals.Text = "Driver Totals";
            // 
            // labelMechanicsTotals
            // 
            this.labelMechanicsTotals.AutoSize = true;
            this.labelMechanicsTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMechanicsTotals.Location = new System.Drawing.Point(449, 383);
            this.labelMechanicsTotals.Name = "labelMechanicsTotals";
            this.labelMechanicsTotals.Size = new System.Drawing.Size(163, 20);
            this.labelMechanicsTotals.TabIndex = 3;
            this.labelMechanicsTotals.Text = "Mechanics Totals:";
            // 
            // frmTimeSheetManagerHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMechanicsTotals);
            this.Controls.Add(this.labelDriverTotals);
            this.Controls.Add(this.gridViewMechanicsTotals);
            this.Controls.Add(this.gridViewDriverTotals);
            this.Name = "frmTimeSheetManagerHS";
            this.Size = new System.Drawing.Size(1040, 807);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDriverTotals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMechanicsTotals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewDriverTotals;
        private System.Windows.Forms.DataGridView gridViewMechanicsTotals;
        private System.Windows.Forms.Label labelDriverTotals;
        private System.Windows.Forms.Label labelMechanicsTotals;
    }
}
