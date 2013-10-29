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
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(106, 248);
            this.textBoxNote.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(374, 336);
            this.textBoxNote.TabIndex = 0;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(103, 215);
            this.labelNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(47, 17);
            this.labelNote.TabIndex = 1;
            this.labelNote.Text = "Note:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(597, 306);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(110, 60);
            this.buttonSubmit.TabIndex = 17;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(597, 465);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 60);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelVehicleRegistrationNum
            // 
            this.labelVehicleRegistrationNum.AutoSize = true;
            this.labelVehicleRegistrationNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleRegistrationNum.Location = new System.Drawing.Point(294, 24);
            this.labelVehicleRegistrationNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVehicleRegistrationNum.Name = "labelVehicleRegistrationNum";
            this.labelVehicleRegistrationNum.Size = new System.Drawing.Size(147, 17);
            this.labelVehicleRegistrationNum.TabIndex = 20;
            this.labelVehicleRegistrationNum.Text = "Choose trip vehicle";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(106, 44);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(601, 150);
            this.dataGridViewInfo.TabIndex = 21;
            // 
            // frmTripManagerTripIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.labelVehicleRegistrationNum);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.textBoxNote);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTripManagerTripIncidents";
            this.Size = new System.Drawing.Size(780, 656);
            this.Load += new System.EventHandler(this.frmTripManagerTripIncidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelVehicleRegistrationNum;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
    }
}
