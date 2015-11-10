using System;

namespace BarrocIT
{
    partial class frmEditCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCustomers));
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCustomerAdress1 = new System.Windows.Forms.Label();
            this.txtCustomerAdress1 = new System.Windows.Forms.TextBox();
            this.lblCustomerPhoneNumber1 = new System.Windows.Forms.Label();
            this.lblCustomerCity2 = new System.Windows.Forms.Label();
            this.lblCustomerCity1 = new System.Windows.Forms.Label();
            this.lblCustomerAdress2 = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerPhoneNumber2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCustomerCity1 = new System.Windows.Forms.TextBox();
            this.txtCustomerCity2 = new System.Windows.Forms.TextBox();
            this.txtCustomerPhoneNumber1 = new System.Windows.Forms.TextBox();
            this.txtCustomerAdress2 = new System.Windows.Forms.TextBox();
            this.cmbCustomerCreditWorthy = new System.Windows.Forms.ComboBox();
            this.cmbCustomerBKRCheck = new System.Windows.Forms.ComboBox();
            this.cmbCustomerPotential = new System.Windows.Forms.ComboBox();
            this.txtCustomerPhoneNumber2 = new System.Windows.Forms.TextBox();
            this.txtCustomerZipCode1 = new System.Windows.Forms.TextBox();
            this.txtCustomerZipCode2 = new System.Windows.Forms.TextBox();
            this.txtCustomerFaxNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerContactPerson = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerBankNumber = new System.Windows.Forms.TextBox();
            this.lblCustomerZipCode1 = new System.Windows.Forms.Label();
            this.lblCustomerZipCode2 = new System.Windows.Forms.Label();
            this.lblCustomerFaxNumber = new System.Windows.Forms.Label();
            this.lblCustomerContactPerson = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerBankNumber = new System.Windows.Forms.Label();
            this.lblCustomerCreditWorthy = new System.Windows.Forms.Label();
            this.lblCustomerBKRCheck = new System.Windows.Forms.Label();
            this.lblCustomerPotential = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::BarrocIT.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(197, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCustomerAdress1
            // 
            this.lblCustomerAdress1.AutoSize = true;
            this.lblCustomerAdress1.Location = new System.Drawing.Point(63, 89);
            this.lblCustomerAdress1.Name = "lblCustomerAdress1";
            this.lblCustomerAdress1.Size = new System.Drawing.Size(51, 13);
            this.lblCustomerAdress1.TabIndex = 0;
            this.lblCustomerAdress1.Text = "Adress 1:";
            // 
            // txtCustomerAdress1
            // 
            this.txtCustomerAdress1.Location = new System.Drawing.Point(116, 86);
            this.txtCustomerAdress1.MaxLength = 50;
            this.txtCustomerAdress1.Name = "txtCustomerAdress1";
            this.txtCustomerAdress1.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerAdress1.TabIndex = 2;
            this.txtCustomerAdress1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerAdress1_KeyDown);
            // 
            // lblCustomerPhoneNumber1
            // 
            this.lblCustomerPhoneNumber1.AutoSize = true;
            this.lblCustomerPhoneNumber1.Location = new System.Drawing.Point(24, 245);
            this.lblCustomerPhoneNumber1.Name = "lblCustomerPhoneNumber1";
            this.lblCustomerPhoneNumber1.Size = new System.Drawing.Size(90, 13);
            this.lblCustomerPhoneNumber1.TabIndex = 0;
            this.lblCustomerPhoneNumber1.Text = "Phone Number 1:";
            // 
            // lblCustomerCity2
            // 
            this.lblCustomerCity2.AutoSize = true;
            this.lblCustomerCity2.Location = new System.Drawing.Point(78, 219);
            this.lblCustomerCity2.Name = "lblCustomerCity2";
            this.lblCustomerCity2.Size = new System.Drawing.Size(36, 13);
            this.lblCustomerCity2.TabIndex = 0;
            this.lblCustomerCity2.Text = "City 2:";
            // 
            // lblCustomerCity1
            // 
            this.lblCustomerCity1.AutoSize = true;
            this.lblCustomerCity1.Location = new System.Drawing.Point(78, 193);
            this.lblCustomerCity1.Name = "lblCustomerCity1";
            this.lblCustomerCity1.Size = new System.Drawing.Size(36, 13);
            this.lblCustomerCity1.TabIndex = 0;
            this.lblCustomerCity1.Text = "City 1:";
            // 
            // lblCustomerAdress2
            // 
            this.lblCustomerAdress2.AutoSize = true;
            this.lblCustomerAdress2.Location = new System.Drawing.Point(63, 115);
            this.lblCustomerAdress2.Name = "lblCustomerAdress2";
            this.lblCustomerAdress2.Size = new System.Drawing.Size(51, 13);
            this.lblCustomerAdress2.TabIndex = 0;
            this.lblCustomerAdress2.Text = "Adress 2:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(46, 11);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(116, 8);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TabStop = false;
            // 
            // lblCustomerPhoneNumber2
            // 
            this.lblCustomerPhoneNumber2.AutoSize = true;
            this.lblCustomerPhoneNumber2.Location = new System.Drawing.Point(24, 271);
            this.lblCustomerPhoneNumber2.Name = "lblCustomerPhoneNumber2";
            this.lblCustomerPhoneNumber2.Size = new System.Drawing.Size(90, 13);
            this.lblCustomerPhoneNumber2.TabIndex = 0;
            this.lblCustomerPhoneNumber2.Text = "Phone Number 2:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(116, 34);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(29, 37);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BarrocIT.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(12, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomerCity1
            // 
            this.txtCustomerCity1.Location = new System.Drawing.Point(116, 190);
            this.txtCustomerCity1.MaxLength = 50;
            this.txtCustomerCity1.Name = "txtCustomerCity1";
            this.txtCustomerCity1.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerCity1.TabIndex = 6;
            this.txtCustomerCity1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerCity1_KeyDown);
            // 
            // txtCustomerCity2
            // 
            this.txtCustomerCity2.Location = new System.Drawing.Point(116, 216);
            this.txtCustomerCity2.MaxLength = 50;
            this.txtCustomerCity2.Name = "txtCustomerCity2";
            this.txtCustomerCity2.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerCity2.TabIndex = 7;
            // 
            // txtCustomerPhoneNumber1
            // 
            this.txtCustomerPhoneNumber1.Location = new System.Drawing.Point(116, 242);
            this.txtCustomerPhoneNumber1.MaxLength = 12;
            this.txtCustomerPhoneNumber1.Name = "txtCustomerPhoneNumber1";
            this.txtCustomerPhoneNumber1.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerPhoneNumber1.TabIndex = 8;
            this.txtCustomerPhoneNumber1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerPhoneNumber1_KeyDown);
            // 
            // txtCustomerAdress2
            // 
            this.txtCustomerAdress2.Location = new System.Drawing.Point(116, 112);
            this.txtCustomerAdress2.MaxLength = 50;
            this.txtCustomerAdress2.Name = "txtCustomerAdress2";
            this.txtCustomerAdress2.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerAdress2.TabIndex = 3;
            // 
            // cmbCustomerCreditWorthy
            // 
            this.cmbCustomerCreditWorthy.AutoCompleteCustomSource.AddRange(new string[] {
            "No",
            "Yes"});
            this.cmbCustomerCreditWorthy.FormattingEnabled = true;
            this.cmbCustomerCreditWorthy.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbCustomerCreditWorthy.Location = new System.Drawing.Point(116, 398);
            this.cmbCustomerCreditWorthy.Name = "cmbCustomerCreditWorthy";
            this.cmbCustomerCreditWorthy.Size = new System.Drawing.Size(195, 21);
            this.cmbCustomerCreditWorthy.TabIndex = 14;
            this.cmbCustomerCreditWorthy.Text = "No";
            this.cmbCustomerCreditWorthy.Click += new System.EventHandler(this.cmbCustomerCreditWorthy_Click);
            this.cmbCustomerCreditWorthy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerCreditWorthy_KeyDown);
            // 
            // cmbCustomerBKRCheck
            // 
            this.cmbCustomerBKRCheck.FormattingEnabled = true;
            this.cmbCustomerBKRCheck.Items.AddRange(new object[] {
            "Not done",
            "Done"});
            this.cmbCustomerBKRCheck.Location = new System.Drawing.Point(116, 425);
            this.cmbCustomerBKRCheck.Name = "cmbCustomerBKRCheck";
            this.cmbCustomerBKRCheck.Size = new System.Drawing.Size(195, 21);
            this.cmbCustomerBKRCheck.TabIndex = 15;
            this.cmbCustomerBKRCheck.Text = "Not done";
            this.cmbCustomerBKRCheck.Click += new System.EventHandler(this.cmbCustomerBKRCheck_Click);
            this.cmbCustomerBKRCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerBKRCheck_KeyDown);
            // 
            // cmbCustomerPotential
            // 
            this.cmbCustomerPotential.FormattingEnabled = true;
            this.cmbCustomerPotential.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbCustomerPotential.Location = new System.Drawing.Point(116, 452);
            this.cmbCustomerPotential.Name = "cmbCustomerPotential";
            this.cmbCustomerPotential.Size = new System.Drawing.Size(195, 21);
            this.cmbCustomerPotential.TabIndex = 16;
            this.cmbCustomerPotential.Text = "No";
            this.cmbCustomerPotential.Click += new System.EventHandler(this.cmbCustomerPotential_Click);
            this.cmbCustomerPotential.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerPotential_KeyDown);
            // 
            // txtCustomerPhoneNumber2
            // 
            this.txtCustomerPhoneNumber2.Location = new System.Drawing.Point(116, 268);
            this.txtCustomerPhoneNumber2.MaxLength = 12;
            this.txtCustomerPhoneNumber2.Name = "txtCustomerPhoneNumber2";
            this.txtCustomerPhoneNumber2.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerPhoneNumber2.TabIndex = 9;
            // 
            // txtCustomerZipCode1
            // 
            this.txtCustomerZipCode1.Location = new System.Drawing.Point(116, 138);
            this.txtCustomerZipCode1.MaxLength = 5;
            this.txtCustomerZipCode1.Name = "txtCustomerZipCode1";
            this.txtCustomerZipCode1.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerZipCode1.TabIndex = 4;
            this.txtCustomerZipCode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerZipCode1_KeyDown);
            // 
            // txtCustomerZipCode2
            // 
            this.txtCustomerZipCode2.Location = new System.Drawing.Point(116, 164);
            this.txtCustomerZipCode2.MaxLength = 6;
            this.txtCustomerZipCode2.Name = "txtCustomerZipCode2";
            this.txtCustomerZipCode2.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerZipCode2.TabIndex = 5;
            // 
            // txtCustomerFaxNumber
            // 
            this.txtCustomerFaxNumber.Location = new System.Drawing.Point(116, 294);
            this.txtCustomerFaxNumber.MaxLength = 12;
            this.txtCustomerFaxNumber.Name = "txtCustomerFaxNumber";
            this.txtCustomerFaxNumber.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerFaxNumber.TabIndex = 10;
            // 
            // txtCustomerContactPerson
            // 
            this.txtCustomerContactPerson.Location = new System.Drawing.Point(116, 320);
            this.txtCustomerContactPerson.MaxLength = 50;
            this.txtCustomerContactPerson.Name = "txtCustomerContactPerson";
            this.txtCustomerContactPerson.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerContactPerson.TabIndex = 11;
            this.txtCustomerContactPerson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerContactPerson_KeyDown);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(116, 346);
            this.txtCustomerEmail.MaxLength = 50;
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerEmail.TabIndex = 12;
            this.txtCustomerEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerEmail_KeyDown);
            // 
            // txtCustomerBankNumber
            // 
            this.txtCustomerBankNumber.Location = new System.Drawing.Point(116, 372);
            this.txtCustomerBankNumber.MaxLength = 20;
            this.txtCustomerBankNumber.Name = "txtCustomerBankNumber";
            this.txtCustomerBankNumber.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerBankNumber.TabIndex = 13;
            this.txtCustomerBankNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerBankNumber_KeyDown);
            // 
            // lblCustomerZipCode1
            // 
            this.lblCustomerZipCode1.AutoSize = true;
            this.lblCustomerZipCode1.Location = new System.Drawing.Point(56, 141);
            this.lblCustomerZipCode1.Name = "lblCustomerZipCode1";
            this.lblCustomerZipCode1.Size = new System.Drawing.Size(58, 13);
            this.lblCustomerZipCode1.TabIndex = 0;
            this.lblCustomerZipCode1.Text = "Zipcode 1:";
            // 
            // lblCustomerZipCode2
            // 
            this.lblCustomerZipCode2.AutoSize = true;
            this.lblCustomerZipCode2.Location = new System.Drawing.Point(56, 167);
            this.lblCustomerZipCode2.Name = "lblCustomerZipCode2";
            this.lblCustomerZipCode2.Size = new System.Drawing.Size(58, 13);
            this.lblCustomerZipCode2.TabIndex = 0;
            this.lblCustomerZipCode2.Text = "Zipcode 2:";
            // 
            // lblCustomerFaxNumber
            // 
            this.lblCustomerFaxNumber.AutoSize = true;
            this.lblCustomerFaxNumber.Location = new System.Drawing.Point(47, 297);
            this.lblCustomerFaxNumber.Name = "lblCustomerFaxNumber";
            this.lblCustomerFaxNumber.Size = new System.Drawing.Size(67, 13);
            this.lblCustomerFaxNumber.TabIndex = 0;
            this.lblCustomerFaxNumber.Text = "Fax Number:";
            // 
            // lblCustomerContactPerson
            // 
            this.lblCustomerContactPerson.AutoSize = true;
            this.lblCustomerContactPerson.Location = new System.Drawing.Point(31, 323);
            this.lblCustomerContactPerson.Name = "lblCustomerContactPerson";
            this.lblCustomerContactPerson.Size = new System.Drawing.Size(83, 13);
            this.lblCustomerContactPerson.TabIndex = 0;
            this.lblCustomerContactPerson.Text = "Contact Person:";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(79, 349);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 0;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // lblCustomerBankNumber
            // 
            this.lblCustomerBankNumber.AutoSize = true;
            this.lblCustomerBankNumber.Location = new System.Drawing.Point(39, 375);
            this.lblCustomerBankNumber.Name = "lblCustomerBankNumber";
            this.lblCustomerBankNumber.Size = new System.Drawing.Size(75, 13);
            this.lblCustomerBankNumber.TabIndex = 0;
            this.lblCustomerBankNumber.Text = "Bank Number:";
            // 
            // lblCustomerCreditWorthy
            // 
            this.lblCustomerCreditWorthy.AutoSize = true;
            this.lblCustomerCreditWorthy.Location = new System.Drawing.Point(40, 401);
            this.lblCustomerCreditWorthy.Name = "lblCustomerCreditWorthy";
            this.lblCustomerCreditWorthy.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerCreditWorthy.TabIndex = 0;
            this.lblCustomerCreditWorthy.Text = "Credit Worthy:";
            // 
            // lblCustomerBKRCheck
            // 
            this.lblCustomerBKRCheck.AutoSize = true;
            this.lblCustomerBKRCheck.Location = new System.Drawing.Point(48, 428);
            this.lblCustomerBKRCheck.Name = "lblCustomerBKRCheck";
            this.lblCustomerBKRCheck.Size = new System.Drawing.Size(66, 13);
            this.lblCustomerBKRCheck.TabIndex = 0;
            this.lblCustomerBKRCheck.Text = "BKR Check:";
            // 
            // lblCustomerPotential
            // 
            this.lblCustomerPotential.AutoSize = true;
            this.lblCustomerPotential.Location = new System.Drawing.Point(16, 455);
            this.lblCustomerPotential.Name = "lblCustomerPotential";
            this.lblCustomerPotential.Size = new System.Drawing.Size(98, 13);
            this.lblCustomerPotential.TabIndex = 0;
            this.lblCustomerPotential.Text = "Potential Customer:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(116, 60);
            this.txtCompany.MaxLength = 50;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(195, 20);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerAdress1_KeyDown);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(60, 63);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(54, 13);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Company:";
            // 
            // frmEditCustomers
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 509);
            this.Controls.Add(this.cmbCustomerPotential);
            this.Controls.Add(this.cmbCustomerBKRCheck);
            this.Controls.Add(this.cmbCustomerCreditWorthy);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblCustomerAdress1);
            this.Controls.Add(this.txtCustomerPhoneNumber1);
            this.Controls.Add(this.txtCustomerAdress2);
            this.Controls.Add(this.txtCustomerBankNumber);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerContactPerson);
            this.Controls.Add(this.txtCustomerFaxNumber);
            this.Controls.Add(this.txtCustomerZipCode2);
            this.Controls.Add(this.txtCustomerZipCode1);
            this.Controls.Add(this.txtCustomerPhoneNumber2);
            this.Controls.Add(this.txtCustomerCity2);
            this.Controls.Add(this.txtCustomerCity1);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtCustomerAdress1);
            this.Controls.Add(this.lblCustomerPotential);
            this.Controls.Add(this.lblCustomerBKRCheck);
            this.Controls.Add(this.lblCustomerCreditWorthy);
            this.Controls.Add(this.lblCustomerBankNumber);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerContactPerson);
            this.Controls.Add(this.lblCustomerFaxNumber);
            this.Controls.Add(this.lblCustomerZipCode2);
            this.Controls.Add(this.lblCustomerZipCode1);
            this.Controls.Add(this.lblCustomerPhoneNumber2);
            this.Controls.Add(this.lblCustomerPhoneNumber1);
            this.Controls.Add(this.lblCustomerCity2);
            this.Controls.Add(this.lblCustomerCity1);
            this.Controls.Add(this.lblCustomerAdress2);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Edit - Customer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditCustomers_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCustomerAdress1;
        private System.Windows.Forms.TextBox txtCustomerAdress1;
        private System.Windows.Forms.Label lblCustomerPhoneNumber1;
        private System.Windows.Forms.Label lblCustomerCity2;
        private System.Windows.Forms.Label lblCustomerCity1;
        private System.Windows.Forms.Label lblCustomerAdress2;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerPhoneNumber2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCustomerCity1;
        private System.Windows.Forms.TextBox txtCustomerCity2;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber1;
        private System.Windows.Forms.TextBox txtCustomerAdress2;
        private System.Windows.Forms.ComboBox cmbCustomerCreditWorthy;
        private System.Windows.Forms.ComboBox cmbCustomerBKRCheck;
        private System.Windows.Forms.ComboBox cmbCustomerPotential;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber2;
        private System.Windows.Forms.TextBox txtCustomerZipCode1;
        private System.Windows.Forms.TextBox txtCustomerZipCode2;
        private System.Windows.Forms.TextBox txtCustomerFaxNumber;
        private System.Windows.Forms.TextBox txtCustomerContactPerson;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerBankNumber;
        private System.Windows.Forms.Label lblCustomerZipCode1;
        private System.Windows.Forms.Label lblCustomerZipCode2;
        private System.Windows.Forms.Label lblCustomerFaxNumber;
        private System.Windows.Forms.Label lblCustomerContactPerson;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerBankNumber;
        private System.Windows.Forms.Label lblCustomerCreditWorthy;
        private System.Windows.Forms.Label lblCustomerBKRCheck;
        private System.Windows.Forms.Label lblCustomerPotential;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
    }
}