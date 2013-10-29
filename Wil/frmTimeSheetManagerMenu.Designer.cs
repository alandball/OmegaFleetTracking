namespace Wil
{
    partial class frmTimeSheetManagerMenu
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
            this.buttonEnterHours = new System.Windows.Forms.Button();
            this.buttonAddEmp = new System.Windows.Forms.Button();
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
            // buttonEnterHours
            // 
            this.buttonEnterHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnterHours.Location = new System.Drawing.Point(48, 143);
            this.buttonEnterHours.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnterHours.Name = "buttonEnterHours";
            this.buttonEnterHours.Size = new System.Drawing.Size(120, 120);
            this.buttonEnterHours.TabIndex = 1;
            this.buttonEnterHours.Text = "Enter Hours";
            this.buttonEnterHours.UseVisualStyleBackColor = true;
            this.buttonEnterHours.Click += new System.EventHandler(this.buttonEnterHours_Click);
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmp.Location = new System.Drawing.Point(48, 269);
            this.buttonAddEmp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.Size = new System.Drawing.Size(120, 120);
            this.buttonAddEmp.TabIndex = 2;
            this.buttonAddEmp.Text = "Add Employee";
            this.buttonAddEmp.UseVisualStyleBackColor = true;
            this.buttonAddEmp.Click += new System.EventHandler(this.buttonAddEmp_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Wil.Properties.Resources.LogoWithBackgroundNosmokesparks;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(38, 520);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(140, 133);
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmTimeSheetManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonAddEmp);
            this.Controls.Add(this.buttonEnterHours);
            this.Controls.Add(this.buttonHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTimeSheetManagerMenu";
            this.Size = new System.Drawing.Size(217, 656);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonEnterHours;
        private System.Windows.Forms.Button buttonAddEmp;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
