namespace Wil
{
    partial class frmTripManagerHS
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
            this.gridViewSchedule = new System.Windows.Forms.DataGridView();
            this.gridViewIncidence = new System.Windows.Forms.DataGridView();
            this.gridViewTripCompleted = new System.Windows.Forms.DataGridView();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.labelIncidence = new System.Windows.Forms.Label();
            this.labelTripCompleted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncidence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTripCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewSchedule
            // 
            this.gridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSchedule.Location = new System.Drawing.Point(28, 93);
            this.gridViewSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridViewSchedule.Name = "gridViewSchedule";
            this.gridViewSchedule.RowTemplate.Height = 24;
            this.gridViewSchedule.Size = new System.Drawing.Size(710, 122);
            this.gridViewSchedule.TabIndex = 0;
            // 
            // gridViewIncidence
            // 
            this.gridViewIncidence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewIncidence.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewIncidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewIncidence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewIncidence.Location = new System.Drawing.Point(28, 293);
            this.gridViewIncidence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridViewIncidence.Name = "gridViewIncidence";
            this.gridViewIncidence.RowTemplate.Height = 24;
            this.gridViewIncidence.Size = new System.Drawing.Size(710, 122);
            this.gridViewIncidence.TabIndex = 1;
            // 
            // gridViewTripCompleted
            // 
            this.gridViewTripCompleted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewTripCompleted.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewTripCompleted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewTripCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTripCompleted.Location = new System.Drawing.Point(28, 496);
            this.gridViewTripCompleted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridViewTripCompleted.Name = "gridViewTripCompleted";
            this.gridViewTripCompleted.RowTemplate.Height = 24;
            this.gridViewTripCompleted.Size = new System.Drawing.Size(710, 122);
            this.gridViewTripCompleted.TabIndex = 2;
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchedule.Location = new System.Drawing.Point(346, 54);
            this.labelSchedule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(89, 20);
            this.labelSchedule.TabIndex = 3;
            this.labelSchedule.Text = "Schedule:";
            // 
            // labelIncidence
            // 
            this.labelIncidence.AutoSize = true;
            this.labelIncidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncidence.Location = new System.Drawing.Point(344, 262);
            this.labelIncidence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIncidence.Name = "labelIncidence";
            this.labelIncidence.Size = new System.Drawing.Size(92, 20);
            this.labelIncidence.TabIndex = 4;
            this.labelIncidence.Text = "Incidence:";
            // 
            // labelTripCompleted
            // 
            this.labelTripCompleted.AutoSize = true;
            this.labelTripCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTripCompleted.Location = new System.Drawing.Point(318, 464);
            this.labelTripCompleted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTripCompleted.Name = "labelTripCompleted";
            this.labelTripCompleted.Size = new System.Drawing.Size(135, 20);
            this.labelTripCompleted.TabIndex = 5;
            this.labelTripCompleted.Text = "Trip Completed:";
            // 
            // frmTripManagerHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTripCompleted);
            this.Controls.Add(this.labelIncidence);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.gridViewTripCompleted);
            this.Controls.Add(this.gridViewIncidence);
            this.Controls.Add(this.gridViewSchedule);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTripManagerHS";
            this.Size = new System.Drawing.Size(780, 656);
            this.Load += new System.EventHandler(this.frmTripManagerHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncidence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTripCompleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewSchedule;
        private System.Windows.Forms.DataGridView gridViewIncidence;
        private System.Windows.Forms.DataGridView gridViewTripCompleted;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.Label labelIncidence;
        private System.Windows.Forms.Label labelTripCompleted;
    }
}
