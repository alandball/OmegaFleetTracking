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
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(64, 21);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(160, 148);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonEnterHours
            // 
            this.buttonEnterHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnterHours.Location = new System.Drawing.Point(64, 176);
            this.buttonEnterHours.Name = "buttonEnterHours";
            this.buttonEnterHours.Size = new System.Drawing.Size(160, 148);
            this.buttonEnterHours.TabIndex = 1;
            this.buttonEnterHours.Text = "Enter Hours:";
            this.buttonEnterHours.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmp.Location = new System.Drawing.Point(64, 331);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.Size = new System.Drawing.Size(160, 148);
            this.buttonAddEmp.TabIndex = 2;
            this.buttonAddEmp.Text = "Add Employee:";
            this.buttonAddEmp.UseVisualStyleBackColor = true;
            // 
            // frmTimeSheetManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddEmp);
            this.Controls.Add(this.buttonEnterHours);
            this.Controls.Add(this.buttonHome);
            this.Name = "frmTimeSheetManagerMenu";
            this.Size = new System.Drawing.Size(289, 807);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonEnterHours;
        private System.Windows.Forms.Button buttonAddEmp;
    }
}
