using System;

namespace BarrocIT
{
    partial class frmEditProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditProjects));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.cmbMaintenceContact = new System.Windows.Forms.ComboBox();
            this.cmbProjectStatus = new System.Windows.Forms.ComboBox();
            this.lblMaintenceContact = new System.Windows.Forms.Label();
            this.lblProjectLimit = new System.Windows.Forms.Label();
            this.lblProjectPrice = new System.Windows.Forms.Label();
            this.lblProjectStatus = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.txtProjectLimit = new System.Windows.Forms.TextBox();
            this.txtProjectPrice = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BarrocIT.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(12, 199);
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
            this.btnCancel.Location = new System.Drawing.Point(198, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(83, 38);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(229, 20);
            this.txtCustomerID.TabIndex = 27;
            // 
            // cmbMaintenceContact
            // 
            this.cmbMaintenceContact.FormattingEnabled = true;
            this.cmbMaintenceContact.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbMaintenceContact.Location = new System.Drawing.Point(115, 168);
            this.cmbMaintenceContact.Name = "cmbMaintenceContact";
            this.cmbMaintenceContact.Size = new System.Drawing.Size(197, 21);
            this.cmbMaintenceContact.TabIndex = 23;
            this.cmbMaintenceContact.Text = "No";
            this.cmbMaintenceContact.Click += new System.EventHandler(this.cmbMaintenceContact_Click);
            this.cmbMaintenceContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMaintenceContact_KeyDown);
            // 
            // cmbProjectStatus
            // 
            this.cmbProjectStatus.FormattingEnabled = true;
            this.cmbProjectStatus.Items.AddRange(new object[] {
            "Unfinished",
            "Finished"});
            this.cmbProjectStatus.Location = new System.Drawing.Point(83, 90);
            this.cmbProjectStatus.Name = "cmbProjectStatus";
            this.cmbProjectStatus.Size = new System.Drawing.Size(229, 21);
            this.cmbProjectStatus.TabIndex = 20;
            this.cmbProjectStatus.Text = "Unfinished";
            this.cmbProjectStatus.Click += new System.EventHandler(this.cmbProjectStatus_Click);
            this.cmbProjectStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProjectStatus_KeyDown);
            // 
            // lblMaintenceContact
            // 
            this.lblMaintenceContact.AutoSize = true;
            this.lblMaintenceContact.Location = new System.Drawing.Point(13, 171);
            this.lblMaintenceContact.Name = "lblMaintenceContact";
            this.lblMaintenceContact.Size = new System.Drawing.Size(100, 13);
            this.lblMaintenceContact.TabIndex = 12;
            this.lblMaintenceContact.Text = "Maintence Contact:";
            // 
            // lblProjectLimit
            // 
            this.lblProjectLimit.AutoSize = true;
            this.lblProjectLimit.Location = new System.Drawing.Point(14, 145);
            this.lblProjectLimit.Name = "lblProjectLimit";
            this.lblProjectLimit.Size = new System.Drawing.Size(67, 13);
            this.lblProjectLimit.TabIndex = 13;
            this.lblProjectLimit.Text = "Project Limit:";
            // 
            // lblProjectPrice
            // 
            this.lblProjectPrice.AutoSize = true;
            this.lblProjectPrice.Location = new System.Drawing.Point(11, 119);
            this.lblProjectPrice.Name = "lblProjectPrice";
            this.lblProjectPrice.Size = new System.Drawing.Size(70, 13);
            this.lblProjectPrice.TabIndex = 14;
            this.lblProjectPrice.Text = "Project Price:";
            // 
            // lblProjectStatus
            // 
            this.lblProjectStatus.AutoSize = true;
            this.lblProjectStatus.Location = new System.Drawing.Point(5, 93);
            this.lblProjectStatus.Name = "lblProjectStatus";
            this.lblProjectStatus.Size = new System.Drawing.Size(76, 13);
            this.lblProjectStatus.TabIndex = 15;
            this.lblProjectStatus.Text = "Project Status:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(7, 67);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(74, 13);
            this.lblProjectName.TabIndex = 16;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Location = new System.Drawing.Point(24, 15);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(57, 13);
            this.lblProjectID.TabIndex = 17;
            this.lblProjectID.Text = "Project ID:";
            // 
            // txtProjectLimit
            // 
            this.txtProjectLimit.Location = new System.Drawing.Point(83, 142);
            this.txtProjectLimit.MaxLength = 50;
            this.txtProjectLimit.Name = "txtProjectLimit";
            this.txtProjectLimit.Size = new System.Drawing.Size(229, 20);
            this.txtProjectLimit.TabIndex = 22;
            this.txtProjectLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProjectLimit_KeyDown);
            this.txtProjectLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProjectLimit_KeyPress);
            // 
            // txtProjectPrice
            // 
            this.txtProjectPrice.Location = new System.Drawing.Point(83, 116);
            this.txtProjectPrice.MaxLength = 50;
            this.txtProjectPrice.Name = "txtProjectPrice";
            this.txtProjectPrice.Size = new System.Drawing.Size(229, 20);
            this.txtProjectPrice.TabIndex = 21;
            this.txtProjectPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProjectPrice_KeyDown);
            this.txtProjectPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProjectPrice_KeyPress);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(83, 64);
            this.txtProjectName.MaxLength = 50;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(229, 20);
            this.txtProjectName.TabIndex = 19;
            this.txtProjectName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProjectName_KeyDown);
            // 
            // txtProjectID
            // 
            this.txtProjectID.Enabled = false;
            this.txtProjectID.Location = new System.Drawing.Point(83, 12);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(229, 20);
            this.txtProjectID.TabIndex = 18;
            // 
            // frmEditProjects
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 230);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.cmbMaintenceContact);
            this.Controls.Add(this.cmbProjectStatus);
            this.Controls.Add(this.lblMaintenceContact);
            this.Controls.Add(this.lblProjectLimit);
            this.Controls.Add(this.lblProjectPrice);
            this.Controls.Add(this.lblProjectStatus);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.txtProjectLimit);
            this.Controls.Add(this.txtProjectPrice);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Edit - Project";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditProjects_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ComboBox cmbMaintenceContact;
        private System.Windows.Forms.ComboBox cmbProjectStatus;
        private System.Windows.Forms.Label lblMaintenceContact;
        private System.Windows.Forms.Label lblProjectLimit;
        private System.Windows.Forms.Label lblProjectPrice;
        private System.Windows.Forms.Label lblProjectStatus;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.TextBox txtProjectLimit;
        private System.Windows.Forms.TextBox txtProjectPrice;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectID;
    }
}