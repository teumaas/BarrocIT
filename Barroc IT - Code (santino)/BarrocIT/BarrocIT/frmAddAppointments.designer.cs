﻿using System;

namespace BarrocIT
{
    partial class frmAddAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAppointments));
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtAppointmentLocation = new System.Windows.Forms.TextBox();
            this.txtAppointmentAdres = new System.Windows.Forms.TextBox();
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
            this.lblAppointmentSubject.TabIndex = 26;
            this.lblAppointmentSubject.Text = "Appointment Subject:";
            // 
            // txtAppointmentSubject
            // 
            this.txtAppointmentSubject.Location = new System.Drawing.Point(115, 64);
            this.txtAppointmentSubject.Name = "txtAppointmentSubject";
            this.txtAppointmentSubject.Size = new System.Drawing.Size(197, 20);
            this.txtAppointmentSubject.TabIndex = 3;
            // 
            // lblAppointmentAdressZipcode
            // 
            this.lblAppointmentAdressZipcode.AutoSize = true;
            this.lblAppointmentAdressZipcode.Location = new System.Drawing.Point(3, 171);
            this.lblAppointmentAdressZipcode.Name = "lblAppointmentAdressZipcode";
            this.lblAppointmentAdressZipcode.Size = new System.Drawing.Size(146, 13);
            this.lblAppointmentAdressZipcode.TabIndex = 13;
            this.lblAppointmentAdressZipcode.Text = "Appointment Adress Zipcode:";
            // 
            // lblAppointmentAdress
            // 
            this.lblAppointmentAdress.AutoSize = true;
            this.lblAppointmentAdress.Location = new System.Drawing.Point(10, 145);
            this.lblAppointmentAdress.Name = "lblAppointmentAdress";
            this.lblAppointmentAdress.Size = new System.Drawing.Size(104, 13);
            this.lblAppointmentAdress.TabIndex = 14;
            this.lblAppointmentAdress.Text = "Appointment Adress:";
            // 
            // lblAppointmentLocation
            // 
            this.lblAppointmentLocation.AutoSize = true;
            this.lblAppointmentLocation.Location = new System.Drawing.Point(1, 119);
            this.lblAppointmentLocation.Name = "lblAppointmentLocation";
            this.lblAppointmentLocation.Size = new System.Drawing.Size(113, 13);
            this.lblAppointmentLocation.TabIndex = 15;
            this.lblAppointmentLocation.Text = "Appointment Location:";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(18, 93);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(95, 13);
            this.lblAppointmentDate.TabIndex = 16;
            this.lblAppointmentDate.Text = "Appointment Date:";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(30, 15);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(83, 13);
            this.lblAppointmentID.TabIndex = 17;
            this.lblAppointmentID.Text = "Appointment ID:";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Enabled = false;
            this.txtAppointmentID.Location = new System.Drawing.Point(115, 12);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(197, 20);
            this.txtAppointmentID.TabIndex = 1;
            // 
            // lblLastContactDate
            // 
            this.lblLastContactDate.AutoSize = true;
            this.lblLastContactDate.Location = new System.Drawing.Point(19, 197);
            this.lblLastContactDate.Name = "lblLastContactDate";
            this.lblLastContactDate.Size = new System.Drawing.Size(95, 13);
            this.lblLastContactDate.TabIndex = 12;
            this.lblLastContactDate.Text = "Appointment Time:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(115, 38);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(197, 20);
            this.txtCustomerID.TabIndex = 2;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(45, 41);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 26;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(115, 90);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(197, 20);
            this.dtpAppointmentDate.TabIndex = 4;
            this.dtpAppointmentDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // btnCreate
            // 
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(12, 224);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 25);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtAppointmentLocation
            // 
            this.txtAppointmentLocation.Location = new System.Drawing.Point(116, 116);
            this.txtAppointmentLocation.Name = "txtAppointmentLocation";
            this.txtAppointmentLocation.Size = new System.Drawing.Size(196, 20);
            this.txtAppointmentLocation.TabIndex = 5;
            // 
            // txtAppointmentAdres
            // 
            this.txtAppointmentAdres.Location = new System.Drawing.Point(116, 142);
            this.txtAppointmentAdres.Name = "txtAppointmentAdres";
            this.txtAppointmentAdres.Size = new System.Drawing.Size(196, 20);
            this.txtAppointmentAdres.TabIndex = 6;
            // 
            // txtAppointmentAdressZipcode
            // 
            this.txtAppointmentAdressZipcode.Location = new System.Drawing.Point(151, 168);
            this.txtAppointmentAdressZipcode.Name = "txtAppointmentAdressZipcode";
            this.txtAppointmentAdressZipcode.Size = new System.Drawing.Size(161, 20);
            this.txtAppointmentAdressZipcode.TabIndex = 7;
            // 
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.CustomFormat = "HH:mm";
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(115, 195);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.Size = new System.Drawing.Size(197, 20);
            this.dtpAppointmentTime.TabIndex = 27;
            // 
            // frmAddAppointments
            // 
            this.AcceptButton = this.btnCreate;
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
            this.Controls.Add(this.txtAppointmentAdres);
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
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Add - Appointment";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddAppointments_FormClosing);
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
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtAppointmentLocation;
        private System.Windows.Forms.TextBox txtAppointmentAdres;
        private System.Windows.Forms.TextBox txtAppointmentAdressZipcode;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
    }
}