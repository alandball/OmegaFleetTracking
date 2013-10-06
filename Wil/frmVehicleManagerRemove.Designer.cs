namespace Wil
{
    partial class frmVehicleManagerRemove
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
            this.comboBoxSearchReg = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelVehicleReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSearchReg
            // 
            this.comboBoxSearchReg.FormattingEnabled = true;
            this.comboBoxSearchReg.Location = new System.Drawing.Point(306, 59);
            this.comboBoxSearchReg.Name = "comboBoxSearchReg";
            this.comboBoxSearchReg.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchReg.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(327, 130);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelVehicleReg
            // 
            this.labelVehicleReg.AutoSize = true;
            this.labelVehicleReg.Location = new System.Drawing.Point(176, 62);
            this.labelVehicleReg.Name = "labelVehicleReg";
            this.labelVehicleReg.Size = new System.Drawing.Size(63, 13);
            this.labelVehicleReg.TabIndex = 2;
            this.labelVehicleReg.Text = "Registration";
            // 
            // frmVehicleManagerRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelVehicleReg);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxSearchReg);
            this.Name = "frmVehicleManagerRemove";
            this.Size = new System.Drawing.Size(780, 656);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearchReg;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelVehicleReg;
    }
}
