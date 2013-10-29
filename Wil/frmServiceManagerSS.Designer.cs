namespace Wil
{
    partial class frmServiceManagerSS
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
            this.comboBoxSelecetVehicle = new System.Windows.Forms.ComboBox();
            this.datePickerServiceDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrecedureCode = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelSelectVehicle = new System.Windows.Forms.Label();
            this.labelServiceDate = new System.Windows.Forms.Label();
            this.labelPrecedureCode = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSelecetVehicle
            // 
            this.comboBoxSelecetVehicle.FormattingEnabled = true;
            this.comboBoxSelecetVehicle.Location = new System.Drawing.Point(236, 74);
            this.comboBoxSelecetVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSelecetVehicle.Name = "comboBoxSelecetVehicle";
            this.comboBoxSelecetVehicle.Size = new System.Drawing.Size(92, 21);
            this.comboBoxSelecetVehicle.TabIndex = 0;
            // 
            // datePickerServiceDate
            // 
            this.datePickerServiceDate.Location = new System.Drawing.Point(236, 168);
            this.datePickerServiceDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePickerServiceDate.Name = "datePickerServiceDate";
            this.datePickerServiceDate.Size = new System.Drawing.Size(151, 20);
            this.datePickerServiceDate.TabIndex = 1;
            // 
            // textBoxPrecedureCode
            // 
            this.textBoxPrecedureCode.Location = new System.Drawing.Point(236, 264);
            this.textBoxPrecedureCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrecedureCode.Name = "textBoxPrecedureCode";
            this.textBoxPrecedureCode.Size = new System.Drawing.Size(165, 20);
            this.textBoxPrecedureCode.TabIndex = 2;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(236, 340);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(316, 162);
            this.textBoxNotes.TabIndex = 3;
            // 
            // labelSelectVehicle
            // 
            this.labelSelectVehicle.AutoSize = true;
            this.labelSelectVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectVehicle.Location = new System.Drawing.Point(83, 74);
            this.labelSelectVehicle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectVehicle.Name = "labelSelectVehicle";
            this.labelSelectVehicle.Size = new System.Drawing.Size(128, 17);
            this.labelSelectVehicle.TabIndex = 4;
            this.labelSelectVehicle.Text = "Select a vehicle:";
            // 
            // labelServiceDate
            // 
            this.labelServiceDate.AutoSize = true;
            this.labelServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceDate.Location = new System.Drawing.Point(83, 170);
            this.labelServiceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelServiceDate.Name = "labelServiceDate";
            this.labelServiceDate.Size = new System.Drawing.Size(106, 17);
            this.labelServiceDate.TabIndex = 5;
            this.labelServiceDate.Text = "Service Date:";
            // 
            // labelPrecedureCode
            // 
            this.labelPrecedureCode.AutoSize = true;
            this.labelPrecedureCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecedureCode.Location = new System.Drawing.Point(83, 264);
            this.labelPrecedureCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecedureCode.Name = "labelPrecedureCode";
            this.labelPrecedureCode.Size = new System.Drawing.Size(130, 17);
            this.labelPrecedureCode.TabIndex = 6;
            this.labelPrecedureCode.Text = "Precedure Code:";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(83, 340);
            this.labelNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(55, 17);
            this.labelNotes.TabIndex = 7;
            this.labelNotes.Text = "Notes:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(269, 549);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(110, 60);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(404, 549);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 60);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // frmServiceManagerSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelPrecedureCode);
            this.Controls.Add(this.labelServiceDate);
            this.Controls.Add(this.labelSelectVehicle);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxPrecedureCode);
            this.Controls.Add(this.datePickerServiceDate);
            this.Controls.Add(this.comboBoxSelecetVehicle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmServiceManagerSS";
            this.Size = new System.Drawing.Size(780, 656);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelecetVehicle;
        private System.Windows.Forms.DateTimePicker datePickerServiceDate;
        private System.Windows.Forms.TextBox textBoxPrecedureCode;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelSelectVehicle;
        private System.Windows.Forms.Label labelServiceDate;
        private System.Windows.Forms.Label labelPrecedureCode;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
    }
}
