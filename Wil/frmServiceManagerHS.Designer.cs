﻿namespace Wil
{
    partial class frmServiceManagerHS
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
            this.gridViewScheduleVS = new System.Windows.Forms.DataGridView();
            this.gridViewLastService = new System.Windows.Forms.DataGridView();
            this.labelLastService = new System.Windows.Forms.Label();
            this.labelScheduleVS = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewScheduleVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLastService)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewScheduleVS
            // 
            this.gridViewScheduleVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewScheduleVS.Location = new System.Drawing.Point(292, 119);
            this.gridViewScheduleVS.Name = "gridViewScheduleVS";
            this.gridViewScheduleVS.RowTemplate.Height = 24;
            this.gridViewScheduleVS.Size = new System.Drawing.Size(424, 172);
            this.gridViewScheduleVS.TabIndex = 0;
            // 
            // gridViewLastService
            // 
            this.gridViewLastService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewLastService.Location = new System.Drawing.Point(292, 400);
            this.gridViewLastService.Name = "gridViewLastService";
            this.gridViewLastService.RowTemplate.Height = 24;
            this.gridViewLastService.Size = new System.Drawing.Size(424, 271);
            this.gridViewLastService.TabIndex = 1;
            // 
            // labelLastService
            // 
            this.labelLastService.AutoSize = true;
            this.labelLastService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastService.Location = new System.Drawing.Point(443, 366);
            this.labelLastService.Name = "labelLastService";
            this.labelLastService.Size = new System.Drawing.Size(131, 20);
            this.labelLastService.TabIndex = 2;
            this.labelLastService.Text = "Last Serviced:";
            // 
            // labelScheduleVS
            // 
            this.labelScheduleVS.AutoSize = true;
            this.labelScheduleVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduleVS.Location = new System.Drawing.Point(389, 82);
            this.labelScheduleVS.Name = "labelScheduleVS";
            this.labelScheduleVS.Size = new System.Drawing.Size(239, 20);
            this.labelScheduleVS.TabIndex = 3;
            this.labelScheduleVS.Text = "Schedule Vehicle Services:";
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
            // frmServiceManagerHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelScheduleVS);
            this.Controls.Add(this.labelLastService);
            this.Controls.Add(this.gridViewLastService);
            this.Controls.Add(this.gridViewScheduleVS);
            this.Name = "frmServiceManagerHS";
            this.Size = new System.Drawing.Size(1040, 807);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewScheduleVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLastService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewScheduleVS;
        private System.Windows.Forms.DataGridView gridViewLastService;
        private System.Windows.Forms.Label labelLastService;
        private System.Windows.Forms.Label labelScheduleVS;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
    }
}
