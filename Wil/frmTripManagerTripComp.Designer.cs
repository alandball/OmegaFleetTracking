namespace Wil
{
    partial class frmTripManagerTripComp
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
            this.labelFuelUsage = new System.Windows.Forms.Label();
            this.textBoxFuelUsage = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxVehicleRegistrationNum = new System.Windows.Forms.ComboBox();
            this.labelVehicleRegistrationNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFuelUsage
            // 
            this.labelFuelUsage.AutoSize = true;
            this.labelFuelUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelUsage.Location = new System.Drawing.Point(132, 242);
            this.labelFuelUsage.Name = "labelFuelUsage";
            this.labelFuelUsage.Size = new System.Drawing.Size(110, 20);
            this.labelFuelUsage.TabIndex = 0;
            this.labelFuelUsage.Text = "Fuel Usage:";
            // 
            // textBoxFuelUsage
            // 
            this.textBoxFuelUsage.Location = new System.Drawing.Point(407, 242);
            this.textBoxFuelUsage.Name = "textBoxFuelUsage";
            this.textBoxFuelUsage.Size = new System.Drawing.Size(135, 22);
            this.textBoxFuelUsage.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(83, 715);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(147, 74);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(264, 715);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(147, 74);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // comboBoxVehicleRegistrationNum
            // 
            this.comboBoxVehicleRegistrationNum.FormattingEnabled = true;
            this.comboBoxVehicleRegistrationNum.Location = new System.Drawing.Point(407, 139);
            this.comboBoxVehicleRegistrationNum.Name = "comboBoxVehicleRegistrationNum";
            this.comboBoxVehicleRegistrationNum.Size = new System.Drawing.Size(121, 24);
            this.comboBoxVehicleRegistrationNum.TabIndex = 18;
            // 
            // labelVehicleRegistrationNum
            // 
            this.labelVehicleRegistrationNum.AutoSize = true;
            this.labelVehicleRegistrationNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleRegistrationNum.Location = new System.Drawing.Point(132, 139);
            this.labelVehicleRegistrationNum.Name = "labelVehicleRegistrationNum";
            this.labelVehicleRegistrationNum.Size = new System.Drawing.Size(256, 20);
            this.labelVehicleRegistrationNum.TabIndex = 19;
            this.labelVehicleRegistrationNum.Text = "Vehicle Registration Number:";
            // 
            // frmTripManagerTripComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelVehicleRegistrationNum);
            this.Controls.Add(this.comboBoxVehicleRegistrationNum);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxFuelUsage);
            this.Controls.Add(this.labelFuelUsage);
            this.Name = "frmTripManagerTripComp";
            this.Size = new System.Drawing.Size(1040, 807);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFuelUsage;
        private System.Windows.Forms.TextBox textBoxFuelUsage;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxVehicleRegistrationNum;
        private System.Windows.Forms.Label labelVehicleRegistrationNum;
    }
}
