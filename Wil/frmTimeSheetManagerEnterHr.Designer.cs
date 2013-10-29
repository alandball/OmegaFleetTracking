namespace Wil
{
    partial class frmTimeSheetManagerEnterHr
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
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeHours = new System.Windows.Forms.TextBox();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelEmployeeHours = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(291, 128);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmployeeName.TabIndex = 0;
            // 
            // textBoxEmployeeHours
            // 
            this.textBoxEmployeeHours.Location = new System.Drawing.Point(291, 262);
            this.textBoxEmployeeHours.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmployeeHours.Name = "textBoxEmployeeHours";
            this.textBoxEmployeeHours.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmployeeHours.TabIndex = 1;
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.Location = new System.Drawing.Point(125, 128);
            this.labelEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(129, 17);
            this.labelEmployeeName.TabIndex = 2;
            this.labelEmployeeName.Text = "Employee Name:";
            // 
            // labelEmployeeHours
            // 
            this.labelEmployeeHours.AutoSize = true;
            this.labelEmployeeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeHours.Location = new System.Drawing.Point(125, 262);
            this.labelEmployeeHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeHours.Name = "labelEmployeeHours";
            this.labelEmployeeHours.Size = new System.Drawing.Size(131, 17);
            this.labelEmployeeHours.TabIndex = 3;
            this.labelEmployeeHours.Text = "Employee Hours:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(128, 537);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(110, 60);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(263, 537);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 60);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // frmTimeSheetManagerEnterHr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelEmployeeHours);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.textBoxEmployeeHours);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTimeSheetManagerEnterHr";
            this.Size = new System.Drawing.Size(780, 656);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeHours;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelEmployeeHours;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
    }
}
