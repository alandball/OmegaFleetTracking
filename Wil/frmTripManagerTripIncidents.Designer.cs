namespace Wil
{
    partial class frmTripManagerTripIncidents
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
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelVehicleRegistrationNum = new System.Windows.Forms.Label();
            this.comboBoxVehicleRegistrationNum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(383, 170);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(497, 412);
            this.textBoxNote.TabIndex = 0;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(242, 173);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(54, 20);
            this.labelNote.TabIndex = 1;
            this.labelNote.Text = "Note:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(83, 715);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(147, 74);
            this.buttonSubmit.TabIndex = 17;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(264, 715);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(147, 74);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelVehicleRegistrationNum
            // 
            this.labelVehicleRegistrationNum.AutoSize = true;
            this.labelVehicleRegistrationNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleRegistrationNum.Location = new System.Drawing.Point(242, 68);
            this.labelVehicleRegistrationNum.Name = "labelVehicleRegistrationNum";
            this.labelVehicleRegistrationNum.Size = new System.Drawing.Size(256, 20);
            this.labelVehicleRegistrationNum.TabIndex = 20;
            this.labelVehicleRegistrationNum.Text = "Vehicle Registration Number:";
            // 
            // comboBoxVehicleRegistrationNum
            // 
            this.comboBoxVehicleRegistrationNum.FormattingEnabled = true;
            this.comboBoxVehicleRegistrationNum.Location = new System.Drawing.Point(556, 68);
            this.comboBoxVehicleRegistrationNum.Name = "comboBoxVehicleRegistrationNum";
            this.comboBoxVehicleRegistrationNum.Size = new System.Drawing.Size(121, 24);
            this.comboBoxVehicleRegistrationNum.TabIndex = 21;
            // 
            // frmTripManagerTripIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxVehicleRegistrationNum);
            this.Controls.Add(this.labelVehicleRegistrationNum);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.textBoxNote);
            this.Name = "frmTripManagerTripIncidents";
            this.Size = new System.Drawing.Size(1040, 807);
            this.Load += new System.EventHandler(this.frmTripManagerTripIncidents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelVehicleRegistrationNum;
        private System.Windows.Forms.ComboBox comboBoxVehicleRegistrationNum;
    }
}
