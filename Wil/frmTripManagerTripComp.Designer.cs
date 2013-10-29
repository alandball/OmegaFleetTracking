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
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.labelDateOfDeparture = new System.Windows.Forms.Label();
            this.datePickerDateOfDeparture = new System.Windows.Forms.DateTimePicker();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelDateOfArrival = new System.Windows.Forms.Label();
            this.datePickerDateOfArrival = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelFuelUsage
            // 
            this.labelFuelUsage.AutoSize = true;
            this.labelFuelUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelUsage.Location = new System.Drawing.Point(91, 297);
            this.labelFuelUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFuelUsage.Name = "labelFuelUsage";
            this.labelFuelUsage.Size = new System.Drawing.Size(95, 17);
            this.labelFuelUsage.TabIndex = 0;
            this.labelFuelUsage.Text = "Fuel Usage:";
            // 
            // textBoxFuelUsage
            // 
            this.textBoxFuelUsage.Location = new System.Drawing.Point(315, 296);
            this.textBoxFuelUsage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFuelUsage.Name = "textBoxFuelUsage";
            this.textBoxFuelUsage.Size = new System.Drawing.Size(102, 20);
            this.textBoxFuelUsage.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(147, 528);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(110, 60);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(283, 528);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 60);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // comboBoxVehicleRegistrationNum
            // 
            this.comboBoxVehicleRegistrationNum.FormattingEnabled = true;
            this.comboBoxVehicleRegistrationNum.Location = new System.Drawing.Point(315, 242);
            this.comboBoxVehicleRegistrationNum.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxVehicleRegistrationNum.Name = "comboBoxVehicleRegistrationNum";
            this.comboBoxVehicleRegistrationNum.Size = new System.Drawing.Size(92, 21);
            this.comboBoxVehicleRegistrationNum.TabIndex = 18;
            // 
            // labelVehicleRegistrationNum
            // 
            this.labelVehicleRegistrationNum.AutoSize = true;
            this.labelVehicleRegistrationNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleRegistrationNum.Location = new System.Drawing.Point(91, 243);
            this.labelVehicleRegistrationNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVehicleRegistrationNum.Name = "labelVehicleRegistrationNum";
            this.labelVehicleRegistrationNum.Size = new System.Drawing.Size(220, 17);
            this.labelVehicleRegistrationNum.TabIndex = 19;
            this.labelVehicleRegistrationNum.Text = "Vehicle Registration Number:";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(315, 175);
            this.comboBoxDestination.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(92, 21);
            this.comboBoxDestination.TabIndex = 20;
            // 
            // labelDateOfDeparture
            // 
            this.labelDateOfDeparture.AutoSize = true;
            this.labelDateOfDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfDeparture.Location = new System.Drawing.Point(91, 81);
            this.labelDateOfDeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateOfDeparture.Name = "labelDateOfDeparture";
            this.labelDateOfDeparture.Size = new System.Drawing.Size(147, 17);
            this.labelDateOfDeparture.TabIndex = 24;
            this.labelDateOfDeparture.Text = "Date Of Departure:";
            // 
            // datePickerDateOfDeparture
            // 
            this.datePickerDateOfDeparture.Location = new System.Drawing.Point(315, 77);
            this.datePickerDateOfDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerDateOfDeparture.Name = "datePickerDateOfDeparture";
            this.datePickerDateOfDeparture.Size = new System.Drawing.Size(151, 20);
            this.datePickerDateOfDeparture.TabIndex = 25;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(91, 176);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(95, 17);
            this.labelDestination.TabIndex = 26;
            this.labelDestination.Text = "Destination:";
            // 
            // labelDateOfArrival
            // 
            this.labelDateOfArrival.AutoSize = true;
            this.labelDateOfArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfArrival.Location = new System.Drawing.Point(91, 131);
            this.labelDateOfArrival.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateOfArrival.Name = "labelDateOfArrival";
            this.labelDateOfArrival.Size = new System.Drawing.Size(121, 17);
            this.labelDateOfArrival.TabIndex = 27;
            this.labelDateOfArrival.Text = "Date Of Arrival:";
            // 
            // datePickerDateOfArrival
            // 
            this.datePickerDateOfArrival.Location = new System.Drawing.Point(315, 127);
            this.datePickerDateOfArrival.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerDateOfArrival.Name = "datePickerDateOfArrival";
            this.datePickerDateOfArrival.Size = new System.Drawing.Size(151, 20);
            this.datePickerDateOfArrival.TabIndex = 29;
            // 
            // frmTripManagerTripComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datePickerDateOfArrival);
            this.Controls.Add(this.labelDateOfArrival);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.datePickerDateOfDeparture);
            this.Controls.Add(this.labelDateOfDeparture);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.labelVehicleRegistrationNum);
            this.Controls.Add(this.comboBoxVehicleRegistrationNum);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxFuelUsage);
            this.Controls.Add(this.labelFuelUsage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTripManagerTripComp";
            this.Size = new System.Drawing.Size(780, 656);
            this.Load += new System.EventHandler(this.frmTripManagerTripComp_Load);
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
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label labelDateOfDeparture;
        private System.Windows.Forms.DateTimePicker datePickerDateOfDeparture;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelDateOfArrival;
        private System.Windows.Forms.DateTimePicker datePickerDateOfArrival;
    }
}
