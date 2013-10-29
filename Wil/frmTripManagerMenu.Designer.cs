namespace Wil
{
    partial class frmTripManagerMenu
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonScheduleTrip = new System.Windows.Forms.Button();
            this.buttonIncidence = new System.Windows.Forms.Button();
            this.buttonTripCompleted = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(48, 17);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(120, 120);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonScheduleTrip
            // 
            this.buttonScheduleTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleTrip.Location = new System.Drawing.Point(48, 143);
            this.buttonScheduleTrip.Margin = new System.Windows.Forms.Padding(2);
            this.buttonScheduleTrip.Name = "buttonScheduleTrip";
            this.buttonScheduleTrip.Size = new System.Drawing.Size(120, 120);
            this.buttonScheduleTrip.TabIndex = 1;
            this.buttonScheduleTrip.Text = "Schedule Trip";
            this.buttonScheduleTrip.UseVisualStyleBackColor = true;
            this.buttonScheduleTrip.Click += new System.EventHandler(this.buttonScheduleTrip_Click);
            // 
            // buttonIncidence
            // 
            this.buttonIncidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncidence.Location = new System.Drawing.Point(48, 269);
            this.buttonIncidence.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIncidence.Name = "buttonIncidence";
            this.buttonIncidence.Size = new System.Drawing.Size(120, 120);
            this.buttonIncidence.TabIndex = 2;
            this.buttonIncidence.Text = "Incidents";
            this.buttonIncidence.UseVisualStyleBackColor = true;
            this.buttonIncidence.Click += new System.EventHandler(this.buttonIncidence_Click);
            // 
            // buttonTripCompleted
            // 
            this.buttonTripCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTripCompleted.Location = new System.Drawing.Point(48, 395);
            this.buttonTripCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTripCompleted.Name = "buttonTripCompleted";
            this.buttonTripCompleted.Size = new System.Drawing.Size(120, 120);
            this.buttonTripCompleted.TabIndex = 3;
            this.buttonTripCompleted.Text = "Trip Completed";
            this.buttonTripCompleted.UseVisualStyleBackColor = true;
            this.buttonTripCompleted.Click += new System.EventHandler(this.buttonTripCompleted_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Wil.Properties.Resources.LogoWithBackgroundNosmokesparks;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(37, 520);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(140, 133);
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmTripManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonTripCompleted);
            this.Controls.Add(this.buttonIncidence);
            this.Controls.Add(this.buttonScheduleTrip);
            this.Controls.Add(this.buttonHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTripManagerMenu";
            this.Size = new System.Drawing.Size(217, 656);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonScheduleTrip;
        private System.Windows.Forms.Button buttonIncidence;
        private System.Windows.Forms.Button buttonTripCompleted;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
