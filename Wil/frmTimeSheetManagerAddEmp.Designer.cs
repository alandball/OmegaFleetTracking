namespace Wil
{
    partial class frmTimeSheetManagerAddEmp
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeTel = new System.Windows.Forms.TextBox();
            this.comboBoxEmployeeType = new System.Windows.Forms.ComboBox();
            this.labelEmployeeTel = new System.Windows.Forms.Label();
            this.labelEmployeeType = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(83, 715);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(147, 74);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(264, 715);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(147, 74);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(423, 156);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(191, 22);
            this.textBoxEmployeeName.TabIndex = 14;
            // 
            // textBoxEmployeeTel
            // 
            this.textBoxEmployeeTel.Location = new System.Drawing.Point(423, 259);
            this.textBoxEmployeeTel.Name = "textBoxEmployeeTel";
            this.textBoxEmployeeTel.Size = new System.Drawing.Size(191, 22);
            this.textBoxEmployeeTel.TabIndex = 15;
            // 
            // comboBoxEmployeeType
            // 
            this.comboBoxEmployeeType.FormattingEnabled = true;
            this.comboBoxEmployeeType.Location = new System.Drawing.Point(413, 383);
            this.comboBoxEmployeeType.Name = "comboBoxEmployeeType";
            this.comboBoxEmployeeType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEmployeeType.TabIndex = 16;
            // 
            // labelEmployeeTel
            // 
            this.labelEmployeeTel.AutoSize = true;
            this.labelEmployeeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeTel.Location = new System.Drawing.Point(198, 259);
            this.labelEmployeeTel.Name = "labelEmployeeTel";
            this.labelEmployeeTel.Size = new System.Drawing.Size(156, 20);
            this.labelEmployeeTel.TabIndex = 18;
            this.labelEmployeeTel.Text = "Employee Name: ";
            // 
            // labelEmployeeType
            // 
            this.labelEmployeeType.AutoSize = true;
            this.labelEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeType.Location = new System.Drawing.Point(198, 383);
            this.labelEmployeeType.Name = "labelEmployeeType";
            this.labelEmployeeType.Size = new System.Drawing.Size(142, 20);
            this.labelEmployeeType.TabIndex = 19;
            this.labelEmployeeType.Text = "Employee Type:";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.Location = new System.Drawing.Point(198, 156);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(150, 20);
            this.labelEmployeeName.TabIndex = 20;
            this.labelEmployeeName.Text = "Employee Name:";
            // 
            // frmTimeSheetManagerAddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.labelEmployeeType);
            this.Controls.Add(this.labelEmployeeTel);
            this.Controls.Add(this.comboBoxEmployeeType);
            this.Controls.Add(this.textBoxEmployeeTel);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "frmTimeSheetManagerAddEmp";
            this.Size = new System.Drawing.Size(1040, 807);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeTel;
        private System.Windows.Forms.ComboBox comboBoxEmployeeType;
        private System.Windows.Forms.Label labelEmployeeTel;
        private System.Windows.Forms.Label labelEmployeeType;
        private System.Windows.Forms.Label labelEmployeeName;
    }
}
