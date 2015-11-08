using System;

namespace BarrocIT
{
    partial class frmEditInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditInvoices));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.cmbInvoicePaid = new System.Windows.Forms.ComboBox();
            this.lblInvoiceTerms = new System.Windows.Forms.Label();
            this.lblInvoiceStatus = new System.Windows.Forms.Label();
            this.lblInvoiceSent = new System.Windows.Forms.Label();
            this.lblInvoicePaid = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.lblLastContactDate = new System.Windows.Forms.Label();
            this.lblLedgerAccountNumber = new System.Windows.Forms.Label();
            this.lblTaxCode = new System.Windows.Forms.Label();
            this.dtpLastContactDate = new System.Windows.Forms.DateTimePicker();
            this.txtLedgerContactNumber = new System.Windows.Forms.TextBox();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.cmbInvoiceSent = new System.Windows.Forms.ComboBox();
            this.cmbInvoiceStatus = new System.Windows.Forms.ComboBox();
            this.txtInvoiceTerms = new System.Windows.Forms.TextBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = global::BarrocIT.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(10, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::BarrocIT.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(198, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Location = new System.Drawing.Point(24, 67);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(57, 13);
            this.lblProjectID.TabIndex = 26;
            this.lblProjectID.Text = "Project ID:";
            // 
            // txtProjectID
            // 
            this.txtProjectID.Enabled = false;
            this.txtProjectID.Location = new System.Drawing.Point(83, 64);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(229, 20);
            this.txtProjectID.TabIndex = 3;
            // 
            // cmbInvoicePaid
            // 
            this.cmbInvoicePaid.FormattingEnabled = true;
            this.cmbInvoicePaid.Items.AddRange(new object[] {
            "Not payed",
            "Payed"});
            this.cmbInvoicePaid.Location = new System.Drawing.Point(83, 116);
            this.cmbInvoicePaid.Name = "cmbInvoicePaid";
            this.cmbInvoicePaid.Size = new System.Drawing.Size(229, 21);
            this.cmbInvoicePaid.TabIndex = 5;
            this.cmbInvoicePaid.Text = "Not payed";
            this.cmbInvoicePaid.Click += new System.EventHandler(this.cmbInvoicePaid_Click);
            this.cmbInvoicePaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInvoicePaid_KeyDown);
            // 
            // lblInvoiceTerms
            // 
            this.lblInvoiceTerms.AutoSize = true;
            this.lblInvoiceTerms.Location = new System.Drawing.Point(4, 198);
            this.lblInvoiceTerms.Name = "lblInvoiceTerms";
            this.lblInvoiceTerms.Size = new System.Drawing.Size(77, 13);
            this.lblInvoiceTerms.TabIndex = 12;
            this.lblInvoiceTerms.Text = "Invoice Terms:";
            // 
            // lblInvoiceStatus
            // 
            this.lblInvoiceStatus.AutoSize = true;
            this.lblInvoiceStatus.Location = new System.Drawing.Point(3, 171);
            this.lblInvoiceStatus.Name = "lblInvoiceStatus";
            this.lblInvoiceStatus.Size = new System.Drawing.Size(78, 13);
            this.lblInvoiceStatus.TabIndex = 13;
            this.lblInvoiceStatus.Text = "Invoice Status:";
            // 
            // lblInvoiceSent
            // 
            this.lblInvoiceSent.AutoSize = true;
            this.lblInvoiceSent.Location = new System.Drawing.Point(11, 145);
            this.lblInvoiceSent.Name = "lblInvoiceSent";
            this.lblInvoiceSent.Size = new System.Drawing.Size(70, 13);
            this.lblInvoiceSent.TabIndex = 14;
            this.lblInvoiceSent.Text = "Invoice Sent:";
            // 
            // lblInvoicePaid
            // 
            this.lblInvoicePaid.AutoSize = true;
            this.lblInvoicePaid.Location = new System.Drawing.Point(12, 119);
            this.lblInvoicePaid.Name = "lblInvoicePaid";
            this.lblInvoicePaid.Size = new System.Drawing.Size(69, 13);
            this.lblInvoicePaid.TabIndex = 15;
            this.lblInvoicePaid.Text = "Invoice Paid:";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(10, 93);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(71, 13);
            this.lblInvoiceDate.TabIndex = 16;
            this.lblInvoiceDate.Text = "Invoice Date:";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(17, 15);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(64, 13);
            this.lblInvoiceID.TabIndex = 17;
            this.lblInvoiceID.Text = "Invoices ID:";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Enabled = false;
            this.txtInvoiceID.Location = new System.Drawing.Point(83, 12);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(229, 20);
            this.txtInvoiceID.TabIndex = 1;
            // 
            // lblLastContactDate
            // 
            this.lblLastContactDate.AutoSize = true;
            this.lblLastContactDate.Location = new System.Drawing.Point(1, 223);
            this.lblLastContactDate.Name = "lblLastContactDate";
            this.lblLastContactDate.Size = new System.Drawing.Size(93, 13);
            this.lblLastContactDate.TabIndex = 12;
            this.lblLastContactDate.Text = "Last contact date:";
            // 
            // lblLedgerAccountNumber
            // 
            this.lblLedgerAccountNumber.AutoSize = true;
            this.lblLedgerAccountNumber.Location = new System.Drawing.Point(1, 248);
            this.lblLedgerAccountNumber.Name = "lblLedgerAccountNumber";
            this.lblLedgerAccountNumber.Size = new System.Drawing.Size(123, 13);
            this.lblLedgerAccountNumber.TabIndex = 12;
            this.lblLedgerAccountNumber.Text = "Ledger account number:";
            // 
            // lblTaxCode
            // 
            this.lblTaxCode.AutoSize = true;
            this.lblTaxCode.Location = new System.Drawing.Point(29, 273);
            this.lblTaxCode.Name = "lblTaxCode";
            this.lblTaxCode.Size = new System.Drawing.Size(52, 13);
            this.lblTaxCode.TabIndex = 12;
            this.lblTaxCode.Text = "Taxcode:";
            // 
            // dtpLastContactDate
            // 
            this.dtpLastContactDate.Location = new System.Drawing.Point(96, 220);
            this.dtpLastContactDate.Name = "dtpLastContactDate";
            this.dtpLastContactDate.Size = new System.Drawing.Size(216, 20);
            this.dtpLastContactDate.TabIndex = 9;
            this.dtpLastContactDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // txtLedgerContactNumber
            // 
            this.txtLedgerContactNumber.Location = new System.Drawing.Point(126, 245);
            this.txtLedgerContactNumber.MaxLength = 12;
            this.txtLedgerContactNumber.Name = "txtLedgerContactNumber";
            this.txtLedgerContactNumber.Size = new System.Drawing.Size(186, 20);
            this.txtLedgerContactNumber.TabIndex = 10;
            this.txtLedgerContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedgerContactNumber_KeyDown);
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(83, 270);
            this.txtTaxCode.MaxLength = 12;
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(229, 20);
            this.txtTaxCode.TabIndex = 11;
            this.txtTaxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaxCode_KeyDown);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(83, 38);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(229, 20);
            this.txtCustomerID.TabIndex = 2;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(13, 41);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 26;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // cmbInvoiceSent
            // 
            this.cmbInvoiceSent.FormattingEnabled = true;
            this.cmbInvoiceSent.Items.AddRange(new object[] {
            "Not sent",
            "Sent"});
            this.cmbInvoiceSent.Location = new System.Drawing.Point(83, 142);
            this.cmbInvoiceSent.Name = "cmbInvoiceSent";
            this.cmbInvoiceSent.Size = new System.Drawing.Size(229, 21);
            this.cmbInvoiceSent.TabIndex = 6;
            this.cmbInvoiceSent.Text = "Not sent";
            this.cmbInvoiceSent.Click += new System.EventHandler(this.cmbInvoiceSent_Click);
            this.cmbInvoiceSent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInvoiceSent_KeyDown);
            // 
            // cmbInvoiceStatus
            // 
            this.cmbInvoiceStatus.FormattingEnabled = true;
            this.cmbInvoiceStatus.Items.AddRange(new object[] {
            "Not Ready",
            "Ready"});
            this.cmbInvoiceStatus.Location = new System.Drawing.Point(83, 168);
            this.cmbInvoiceStatus.Name = "cmbInvoiceStatus";
            this.cmbInvoiceStatus.Size = new System.Drawing.Size(229, 21);
            this.cmbInvoiceStatus.TabIndex = 7;
            this.cmbInvoiceStatus.Text = "Not ready";
            this.cmbInvoiceStatus.Click += new System.EventHandler(this.cmbInvoiceStatus_Click);
            this.cmbInvoiceStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInvoiceStatus_KeyDown);
            // 
            // txtInvoiceTerms
            // 
            this.txtInvoiceTerms.Location = new System.Drawing.Point(83, 195);
            this.txtInvoiceTerms.MaxLength = 50;
            this.txtInvoiceTerms.Name = "txtInvoiceTerms";
            this.txtInvoiceTerms.Size = new System.Drawing.Size(229, 20);
            this.txtInvoiceTerms.TabIndex = 8;
            this.txtInvoiceTerms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoiceTerms_KeyDown);
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Location = new System.Drawing.Point(83, 90);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(229, 20);
            this.dtpInvoiceDate.TabIndex = 4;
            this.dtpInvoiceDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // frmEditInvoices
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 333);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.dtpLastContactDate);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.cmbInvoiceStatus);
            this.Controls.Add(this.cmbInvoiceSent);
            this.Controls.Add(this.cmbInvoicePaid);
            this.Controls.Add(this.lblTaxCode);
            this.Controls.Add(this.lblLedgerAccountNumber);
            this.Controls.Add(this.lblLastContactDate);
            this.Controls.Add(this.lblInvoiceTerms);
            this.Controls.Add(this.lblInvoiceStatus);
            this.Controls.Add(this.lblInvoiceSent);
            this.Controls.Add(this.lblInvoicePaid);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.txtTaxCode);
            this.Controls.Add(this.txtLedgerContactNumber);
            this.Controls.Add(this.txtInvoiceTerms);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Edit - Invoice";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditInvoices_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.ComboBox cmbInvoicePaid;
        private System.Windows.Forms.Label lblInvoiceTerms;
        private System.Windows.Forms.Label lblInvoiceStatus;
        private System.Windows.Forms.Label lblInvoiceSent;
        private System.Windows.Forms.Label lblInvoicePaid;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label lblLastContactDate;
        private System.Windows.Forms.Label lblLedgerAccountNumber;
        private System.Windows.Forms.Label lblTaxCode;
        private System.Windows.Forms.DateTimePicker dtpLastContactDate;
        private System.Windows.Forms.TextBox txtLedgerContactNumber;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ComboBox cmbInvoiceSent;
        private System.Windows.Forms.ComboBox cmbInvoiceStatus;
        private System.Windows.Forms.TextBox txtInvoiceTerms;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
    }
}