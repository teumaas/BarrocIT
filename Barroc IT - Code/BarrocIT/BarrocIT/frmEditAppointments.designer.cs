using System;

namespace BarrocIT
{
    partial class frmEditAppointments
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAppointments));
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAppointmentSubject = new System.Windows.Forms.Label();
            this.txtAppointmentSubject = new System.Windows.Forms.TextBox();
            this.lblAppointmentAdressZipcode = new System.Windows.Forms.Label();
            this.lblAppointmentAdress = new System.Windows.Forms.Label();
            this.lblAppointmentLocation = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.lblLastContactDate = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAppointmentLocation = new System.Windows.Forms.TextBox();
            this.txtAppointmentAdress = new System.Windows.Forms.TextBox();
            this.txtAppointmentAdressZipcode = new System.Windows.Forms.TextBox();
            this.dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::BarrocIT.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(199, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAppointmentSubject
            // 
            this.lblAppointmentSubject.AutoSize = true;
            this.lblAppointmentSubject.Location = new System.Drawing.Point(5, 67);
            this.lblAppointmentSubject.Name = "lblAppointmentSubject";
            this.lblAppointmentSubject.Size = new System.Drawing.Size(108, 13);
            this.lblAppointmentSubject.TabIndex = 0;
            this.lblAppointmentSubject.Text = "Appointment Subject:";
            // 
            // txtAppointmentSubject
            // 
            this.txtAppointmentSubject.Location = new System.Drawing.Point(115, 64);
            this.txtAppointmentSubject.MaxLength = 50;
            this.txtAppointmentSubject.Name = "txtAppointmentSubject";
            this.txtAppointmentSubject.Size = new System.Drawing.Size(197, 20);
            this.txtAppointmentSubject.TabIndex = 1;
            this.txtAppointmentSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAppointmentSubject_KeyDown);
            // 
            // lblAppointmentAdressZipcode
            // 
            this.lblAppointmentAdressZipcode.AutoSize = true;
            this.lblAppointmentAdressZipcode.Location = new System.Drawing.Point(3, 171);
            this.lblAppointmentAdressZipcode.Name = "lblAppointmentAdressZipcode";
            this.lblAppointmentAdressZipcode.Size = new System.Drawing.Size(146, 13);
            this.lblAppointmentAdressZipcode.TabIndex = 0;
            this.lblAppointmentAdressZipcode.Text = "Appointment Adress Zipcode:";
            // 
            // lblAppointmentAdress
            // 
            this.lblAppointmentAdress.AutoSize = true;
            this.lblAppointmentAdress.Location = new System.Drawing.Point(10, 145);
            this.lblAppointmentAdress.Name = "lblAppointmentAdress";
            this.lblAppointmentAdress.Size = new System.Drawing.Size(104, 13);
            this.lblAppointmentAdress.TabIndex = 0;
            this.lblAppointmentAdress.Text = "Appointment Adress:";
            // 
            // lblAppointmentLocation
            // 
            this.lblAppointmentLocation.AutoSize = true;
            this.lblAppointmentLocation.Location = new System.Drawing.Point(1, 119);
            this.lblAppointmentLocation.Name = "lblAppointmentLocation";
            this.lblAppointmentLocation.Size = new System.Drawing.Size(113, 13);
            this.lblAppointmentLocation.TabIndex = 0;
            this.lblAppointmentLocation.Text = "Appointment Location:";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(18, 93);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(95, 13);
            this.lblAppointmentDate.TabIndex = 0;
            this.lblAppointmentDate.Text = "Appointment Date:";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(30, 15);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(83, 13);
            this.lblAppointmentID.TabIndex = 0;
            this.lblAppointmentID.Text = "Appointment ID:";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Enabled = false;
            this.txtAppointmentID.Location = new System.Drawing.Point(115, 12);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(197, 20);
            this.txtAppointmentID.TabIndex = 0;
            this.txtAppointmentID.TabStop = false;
            // 
            // lblLastContactDate
            // 
            this.lblLastContactDate.AutoSize = true;
            this.lblLastContactDate.Location = new System.Drawing.Point(19, 197);
            this.lblLastContactDate.Name = "lblLastContactDate";
            this.lblLastContactDate.Size = new System.Drawing.Size(95, 13);
            this.lblLastContactDate.TabIndex = 0;
            this.lblLastContactDate.Text = "Appointment Time:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(115, 38);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(197, 20);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TabStop = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(45, 41);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(115, 90);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(197, 20);
            this.dtpAppointmentDate.TabIndex = 2;
            this.dtpAppointmentDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BarrocIT.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(12, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAppointmentLocation
            // 
            this.txtAppointmentLocation.Location = new System.Drawing.Point(116, 116);
            this.txtAppointmentLocation.MaxLength = 50;
            this.txtAppointmentLocation.Name = "txtAppointmentLocation";
            this.txtAppointmentLocation.Size = new System.Drawing.Size(196, 20);
            this.txtAppointmentLocation.TabIndex = 3;
            this.txtAppointmentLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAppointmentLocation_KeyDown);
            // 
            // txtAppointmentAdress
            // 
            this.txtAppointmentAdress.Location = new System.Drawing.Point(116, 142);
            this.txtAppointmentAdress.MaxLength = 50;
            this.txtAppointmentAdress.Name = "txtAppointmentAdress";
            this.txtAppointmentAdress.Size = new System.Drawing.Size(196, 20);
            this.txtAppointmentAdress.TabIndex = 4;
            this.txtAppointmentAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAppointmentAdress_KeyDown);
            // 
            // txtAppointmentAdressZipcode
            // 
            this.txtAppointmentAdressZipcode.Location = new System.Drawing.Point(151, 168);
            this.txtAppointmentAdressZipcode.MaxLength = 6;
            this.txtAppointmentAdressZipcode.Name = "txtAppointmentAdressZipcode";
            this.txtAppointmentAdressZipcode.Size = new System.Drawing.Size(161, 20);
            this.txtAppointmentAdressZipcode.TabIndex = 5;
            this.txtAppointmentAdressZipcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAppointmentAdressZipcode_KeyDown);
            // 
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.CustomFormat = "HH:mm";
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(115, 195);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.Size = new System.Drawing.Size(197, 20);
            this.dtpAppointmentTime.TabIndex = 6;
            // 
            // frmEditAppointments
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 252);
            this.Controls.Add(this.dtpAppointmentTime);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.lblAppointmentSubject);
            this.Controls.Add(this.txtAppointmentAdressZipcode);
            this.Controls.Add(this.txtAppointmentAdress);
            this.Controls.Add(this.txtAppointmentLocation);
            this.Controls.Add(this.txtAppointmentSubject);
            this.Controls.Add(this.lblLastContactDate);
            this.Controls.Add(this.lblAppointmentAdressZipcode);
            this.Controls.Add(this.lblAppointmentAdress);
            this.Controls.Add(this.lblAppointmentLocation);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblAppointmentID);
            this.Controls.Add(this.txtAppointmentID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Edit - Appointment";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditAppointments_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAppointmentSubject;
        private System.Windows.Forms.TextBox txtAppointmentSubject;
        private System.Windows.Forms.Label lblAppointmentAdressZipcode;
        private System.Windows.Forms.Label lblAppointmentAdress;
        private System.Windows.Forms.Label lblAppointmentLocation;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Label lblLastContactDate;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAppointmentLocation;
        private System.Windows.Forms.TextBox txtAppointmentAdress;
        private System.Windows.Forms.TextBox txtAppointmentAdressZipcode;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
    }
}