namespace Wil
{
    partial class frmTripManagerSchT
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
            this.datePickerDateOfDeparture = new System.Windows.Forms.DateTimePicker();
            this.datePickerDateOfArrival = new System.Windows.Forms.DateTimePicker();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelDateOfDeparture = new System.Windows.Forms.Label();
            this.labelDateOfArrival = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelChooseID = new System.Windows.Forms.Label();
            this.comboBoxChooseID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // datePickerDateOfDeparture
            // 
            this.datePickerDateOfDeparture.Location = new System.Drawing.Point(401, 109);
            this.datePickerDateOfDeparture.Name = "datePickerDateOfDeparture";
            this.datePickerDateOfDeparture.Size = new System.Drawing.Size(200, 22);
            this.datePickerDateOfDeparture.TabIndex = 0;
            // 
            // datePickerDateOfArrival
            // 
            this.datePickerDateOfArrival.Location = new System.Drawing.Point(401, 205);
            this.datePickerDateOfArrival.Name = "datePickerDateOfArrival";
            this.datePickerDateOfArrival.Size = new System.Drawing.Size(200, 22);
            this.datePickerDateOfArrival.TabIndex = 1;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(401, 292);
            this.textBoxDestination.Multiline = true;
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(256, 69);
            this.textBoxDestination.TabIndex = 2;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(401, 396);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(256, 128);
            this.textBoxNotes.TabIndex = 3;
            // 
            // labelDateOfDeparture
            // 
            this.labelDateOfDeparture.AutoSize = true;
            this.labelDateOfDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfDeparture.Location = new System.Drawing.Point(187, 111);
            this.labelDateOfDeparture.Name = "labelDateOfDeparture";
            this.labelDateOfDeparture.Size = new System.Drawing.Size(171, 20);
            this.labelDateOfDeparture.TabIndex = 5;
            this.labelDateOfDeparture.Text = "Date Of Departure:";
            // 
            // labelDateOfArrival
            // 
            this.labelDateOfArrival.AutoSize = true;
            this.labelDateOfArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfArrival.Location = new System.Drawing.Point(187, 207);
            this.labelDateOfArrival.Name = "labelDateOfArrival";
            this.labelDateOfArrival.Size = new System.Drawing.Size(142, 20);
            this.labelDateOfArrival.TabIndex = 6;
            this.labelDateOfArrival.Text = "Date Of Arrival:";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(187, 292);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(111, 20);
            this.labelDestination.TabIndex = 7;
            this.labelDestination.Text = "Destination:";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(187, 396);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(64, 20);
            this.labelNotes.TabIndex = 8;
            this.labelNotes.Text = "Notes:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(83, 715);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(147, 74);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(264, 715);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(147, 74);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelChooseID
            // 
            this.labelChooseID.AutoSize = true;
            this.labelChooseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseID.Location = new System.Drawing.Point(187, 575);
            this.labelChooseID.Name = "labelChooseID";
            this.labelChooseID.Size = new System.Drawing.Size(103, 20);
            this.labelChooseID.TabIndex = 9;
            this.labelChooseID.Text = "Choose ID:";
            // 
            // comboBoxChooseID
            // 
            this.comboBoxChooseID.FormattingEnabled = true;
            this.comboBoxChooseID.Location = new System.Drawing.Point(401, 575);
            this.comboBoxChooseID.Name = "comboBoxChooseID";
            this.comboBoxChooseID.Size = new System.Drawing.Size(256, 24);
            this.comboBoxChooseID.TabIndex = 4;
            // 
            // frmTripManagerSchT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelChooseID);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelDateOfArrival);
            this.Controls.Add(this.labelDateOfDeparture);
            this.Controls.Add(this.comboBoxChooseID);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.datePickerDateOfArrival);
            this.Controls.Add(this.datePickerDateOfDeparture);
            this.Name = "frmTripManagerSchT";
            this.Size = new System.Drawing.Size(1040, 807);
            this.Load += new System.EventHandler(this.frmTripManagerSchT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickerDateOfDeparture;
        private System.Windows.Forms.DateTimePicker datePickerDateOfArrival;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelDateOfDeparture;
        private System.Windows.Forms.Label labelDateOfArrival;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelChooseID;
        private System.Windows.Forms.ComboBox comboBoxChooseID;
    }
}
