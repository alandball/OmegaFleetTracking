namespace Wil
{
    partial class frmVehicleManager
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
            this.comboBoxTrailerOrVehicle = new System.Windows.Forms.ComboBox();
            this.textBoxRegNumber = new System.Windows.Forms.TextBox();
            this.textBoxVinNumber = new System.Windows.Forms.TextBox();
            this.textBoxVehicleDesc = new System.Windows.Forms.TextBox();
            this.textBoxVehicleKm = new System.Windows.Forms.TextBox();
            this.labelTrailerOrVehicle = new System.Windows.Forms.Label();
            this.labelRegNumber = new System.Windows.Forms.Label();
            this.labelVinNumber = new System.Windows.Forms.Label();
            this.labelVehicleDesc = new System.Windows.Forms.Label();
            this.labelVehicleKm = new System.Windows.Forms.Label();
            this.labelCategoryID = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxTrailerOrVehicle
            // 
            this.comboBoxTrailerOrVehicle.FormattingEnabled = true;
            this.comboBoxTrailerOrVehicle.Items.AddRange(new object[] {
            "Truck",
            "Trailer"});
            this.comboBoxTrailerOrVehicle.Location = new System.Drawing.Point(272, 49);
            this.comboBoxTrailerOrVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTrailerOrVehicle.Name = "comboBoxTrailerOrVehicle";
            this.comboBoxTrailerOrVehicle.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTrailerOrVehicle.TabIndex = 0;
            // 
            // textBoxRegNumber
            // 
            this.textBoxRegNumber.Location = new System.Drawing.Point(272, 115);
            this.textBoxRegNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRegNumber.Name = "textBoxRegNumber";
            this.textBoxRegNumber.Size = new System.Drawing.Size(169, 20);
            this.textBoxRegNumber.TabIndex = 1;
            // 
            // textBoxVinNumber
            // 
            this.textBoxVinNumber.Location = new System.Drawing.Point(272, 184);
            this.textBoxVinNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVinNumber.Name = "textBoxVinNumber";
            this.textBoxVinNumber.Size = new System.Drawing.Size(169, 20);
            this.textBoxVinNumber.TabIndex = 2;
            // 
            // textBoxVehicleDesc
            // 
            this.textBoxVehicleDesc.Location = new System.Drawing.Point(272, 251);
            this.textBoxVehicleDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVehicleDesc.Multiline = true;
            this.textBoxVehicleDesc.Name = "textBoxVehicleDesc";
            this.textBoxVehicleDesc.Size = new System.Drawing.Size(169, 102);
            this.textBoxVehicleDesc.TabIndex = 3;
            // 
            // textBoxVehicleKm
            // 
            this.textBoxVehicleKm.Location = new System.Drawing.Point(272, 430);
            this.textBoxVehicleKm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVehicleKm.Name = "textBoxVehicleKm";
            this.textBoxVehicleKm.Size = new System.Drawing.Size(169, 20);
            this.textBoxVehicleKm.TabIndex = 4;
            // 
            // labelTrailerOrVehicle
            // 
            this.labelTrailerOrVehicle.AutoSize = true;
            this.labelTrailerOrVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrailerOrVehicle.Location = new System.Drawing.Point(106, 49);
            this.labelTrailerOrVehicle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrailerOrVehicle.Name = "labelTrailerOrVehicle";
            this.labelTrailerOrVehicle.Size = new System.Drawing.Size(107, 17);
            this.labelTrailerOrVehicle.TabIndex = 6;
            this.labelTrailerOrVehicle.Text = "Trailer/Truck:";
            // 
            // labelRegNumber
            // 
            this.labelRegNumber.AutoSize = true;
            this.labelRegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegNumber.Location = new System.Drawing.Point(106, 115);
            this.labelRegNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegNumber.Name = "labelRegNumber";
            this.labelRegNumber.Size = new System.Drawing.Size(162, 17);
            this.labelRegNumber.TabIndex = 7;
            this.labelRegNumber.Text = "Registration Number:";
            // 
            // labelVinNumber
            // 
            this.labelVinNumber.AutoSize = true;
            this.labelVinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVinNumber.Location = new System.Drawing.Point(106, 184);
            this.labelVinNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVinNumber.Name = "labelVinNumber";
            this.labelVinNumber.Size = new System.Drawing.Size(97, 17);
            this.labelVinNumber.TabIndex = 8;
            this.labelVinNumber.Text = "Vin Number:";
            // 
            // labelVehicleDesc
            // 
            this.labelVehicleDesc.AutoSize = true;
            this.labelVehicleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleDesc.Location = new System.Drawing.Point(106, 251);
            this.labelVehicleDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVehicleDesc.Name = "labelVehicleDesc";
            this.labelVehicleDesc.Size = new System.Drawing.Size(153, 17);
            this.labelVehicleDesc.TabIndex = 9;
            this.labelVehicleDesc.Text = "Vehicle Description:";
            // 
            // labelVehicleKm
            // 
            this.labelVehicleKm.AutoSize = true;
            this.labelVehicleKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleKm.Location = new System.Drawing.Point(106, 430);
            this.labelVehicleKm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVehicleKm.Name = "labelVehicleKm";
            this.labelVehicleKm.Size = new System.Drawing.Size(93, 17);
            this.labelVehicleKm.TabIndex = 10;
            this.labelVehicleKm.Text = "Vehicle Km:";
            // 
            // labelCategoryID
            // 
            this.labelCategoryID.AutoSize = true;
            this.labelCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryID.Location = new System.Drawing.Point(106, 526);
            this.labelCategoryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoryID.Name = "labelCategoryID";
            this.labelCategoryID.Size = new System.Drawing.Size(119, 17);
            this.labelCategoryID.TabIndex = 11;
            this.labelCategoryID.Text = "Category Name";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(62, 581);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(110, 60);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(198, 581);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 60);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(272, 526);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(169, 21);
            this.comboBoxCategory.TabIndex = 14;
            // 
            // frmVehicleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelCategoryID);
            this.Controls.Add(this.labelVehicleKm);
            this.Controls.Add(this.labelVehicleDesc);
            this.Controls.Add(this.labelVinNumber);
            this.Controls.Add(this.labelRegNumber);
            this.Controls.Add(this.labelTrailerOrVehicle);
            this.Controls.Add(this.textBoxVehicleKm);
            this.Controls.Add(this.textBoxVehicleDesc);
            this.Controls.Add(this.textBoxVinNumber);
            this.Controls.Add(this.textBoxRegNumber);
            this.Controls.Add(this.comboBoxTrailerOrVehicle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVehicleManager";
            this.Size = new System.Drawing.Size(780, 656);
            this.Load += new System.EventHandler(this.frmVehicleManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTrailerOrVehicle;
        private System.Windows.Forms.TextBox textBoxRegNumber;
        private System.Windows.Forms.TextBox textBoxVinNumber;
        private System.Windows.Forms.TextBox textBoxVehicleDesc;
        private System.Windows.Forms.TextBox textBoxVehicleKm;
        private System.Windows.Forms.Label labelTrailerOrVehicle;
        private System.Windows.Forms.Label labelRegNumber;
        private System.Windows.Forms.Label labelVinNumber;
        private System.Windows.Forms.Label labelVehicleDesc;
        private System.Windows.Forms.Label labelVehicleKm;
        private System.Windows.Forms.Label labelCategoryID;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}
