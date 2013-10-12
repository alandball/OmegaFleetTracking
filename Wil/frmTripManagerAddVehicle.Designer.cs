namespace Wil
{
    partial class frmTripManagerAddVehicle
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
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gridViewAllVehicles = new System.Windows.Forms.DataGridView();
            this.gridViewAllTrailers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllTrailers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVehicle.Location = new System.Drawing.Point(295, 253);
            this.buttonAddVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(173, 60);
            this.buttonAddVehicle.TabIndex = 13;
            this.buttonAddVehicle.Text = "Add a Truck";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(295, 554);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add a Trailer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridViewAllVehicles
            // 
            this.gridViewAllVehicles.AllowUserToAddRows = false;
            this.gridViewAllVehicles.AllowUserToDeleteRows = false;
            this.gridViewAllVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewAllVehicles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewAllVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewAllVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAllVehicles.Location = new System.Drawing.Point(49, 59);
            this.gridViewAllVehicles.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewAllVehicles.Name = "gridViewAllVehicles";
            this.gridViewAllVehicles.RowTemplate.Height = 24;
            this.gridViewAllVehicles.Size = new System.Drawing.Size(678, 190);
            this.gridViewAllVehicles.TabIndex = 15;
            // 
            // gridViewAllTrailers
            // 
            this.gridViewAllTrailers.AllowUserToAddRows = false;
            this.gridViewAllTrailers.AllowUserToDeleteRows = false;
            this.gridViewAllTrailers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewAllTrailers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewAllTrailers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewAllTrailers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAllTrailers.Location = new System.Drawing.Point(49, 360);
            this.gridViewAllTrailers.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewAllTrailers.Name = "gridViewAllTrailers";
            this.gridViewAllTrailers.RowTemplate.Height = 24;
            this.gridViewAllTrailers.Size = new System.Drawing.Size(678, 190);
            this.gridViewAllTrailers.TabIndex = 16;
            // 
            // frmTripManagerAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridViewAllTrailers);
            this.Controls.Add(this.gridViewAllVehicles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddVehicle);
            this.Name = "frmTripManagerAddVehicle";
            this.Size = new System.Drawing.Size(780, 656);
            this.Load += new System.EventHandler(this.frmTripManagerAddVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllTrailers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridViewAllVehicles;
        private System.Windows.Forms.DataGridView gridViewAllTrailers;

    }
}
