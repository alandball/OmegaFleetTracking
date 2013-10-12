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
            this.datePickerDateOfDeparture.Location = new System.Drawing.Point(301, 89);
            this.datePickerDateOfDeparture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePickerDateOfDeparture.Name = "datePickerDateOfDeparture";
            this.datePickerDateOfDeparture.Size = new System.Drawing.Size(151, 20);
            this.datePickerDateOfDeparture.TabIndex = 0;
            // 
            // datePickerDateOfArrival
            // 
            this.datePickerDateOfArrival.Location = new System.Drawing.Point(301, 167);
            this.datePickerDateOfArrival.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePickerDateOfArrival.Name = "datePickerDateOfArrival";
            this.datePickerDateOfArrival.Size = new System.Drawing.Size(151, 20);
            this.datePickerDateOfArrival.TabIndex = 1;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(301, 237);
            this.textBoxDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDestination.Multiline = true;
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(193, 57);
            this.textBoxDestination.TabIndex = 2;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(301, 322);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(193, 105);
            this.textBoxNotes.TabIndex = 3;
            // 
            // labelDateOfDeparture
            // 
            this.labelDateOfDeparture.AutoSize = true;
            this.labelDateOfDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfDeparture.Location = new System.Drawing.Point(140, 90);
            this.labelDateOfDeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateOfDeparture.Name = "labelDateOfDeparture";
            this.labelDateOfDeparture.Size = new System.Drawing.Size(147, 17);
            this.labelDateOfDeparture.TabIndex = 5;
            this.labelDateOfDeparture.Text = "Date Of Departure:";
            // 
            // labelDateOfArrival
            // 
            this.labelDateOfArrival.AutoSize = true;
            this.labelDateOfArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfArrival.Location = new System.Drawing.Point(140, 168);
            this.labelDateOfArrival.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateOfArrival.Name = "labelDateOfArrival";
            this.labelDateOfArrival.Size = new System.Drawing.Size(121, 17);
            this.labelDateOfArrival.TabIndex = 6;
            this.labelDateOfArrival.Text = "Date Of Arrival:";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(140, 237);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(95, 17);
            this.labelDestination.TabIndex = 7;
            this.labelDestination.Text = "Destination:";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(140, 322);
            this.labelNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(55, 17);
            this.labelNotes.TabIndex = 8;
            this.labelNotes.Text = "Notes:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(62, 581);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(110, 60);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(198, 581);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 60);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelChooseID
            // 
            this.labelChooseID.AutoSize = true;
            this.labelChooseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseID.Location = new System.Drawing.Point(140, 467);
            this.labelChooseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseID.Name = "labelChooseID";
            this.labelChooseID.Size = new System.Drawing.Size(107, 17);
            this.labelChooseID.TabIndex = 9;
            this.labelChooseID.Text = "Select Driver:";
            // 
            // comboBoxChooseID
            // 
            this.comboBoxChooseID.FormattingEnabled = true;
            this.comboBoxChooseID.Location = new System.Drawing.Point(301, 467);
            this.comboBoxChooseID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxChooseID.Name = "comboBoxChooseID";
            this.comboBoxChooseID.Size = new System.Drawing.Size(193, 21);
            this.comboBoxChooseID.TabIndex = 4;
            // 
            // frmTripManagerSchT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTripManagerSchT";
            this.Size = new System.Drawing.Size(780, 656);
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
