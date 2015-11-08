namespace BarrocIT
{
    partial class frmAddProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProjects));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectPrice = new System.Windows.Forms.TextBox();
            this.txtProjectLimit = new System.Windows.Forms.TextBox();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectStatus = new System.Windows.Forms.Label();
            this.lblProjectPrice = new System.Windows.Forms.Label();
            this.lblProjectLimit = new System.Windows.Forms.Label();
            this.cmbProjectStatus = new System.Windows.Forms.ComboBox();
            this.lblMaintenceContact = new System.Windows.Forms.Label();
            this.cmbMaintenceContact = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::BarrocIT.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(198, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(12, 199);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 25);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtProjectID
            // 
            this.txtProjectID.Enabled = false;
            this.txtProjectID.Location = new System.Drawing.Point(83, 12);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(229, 20);
            this.txtProjectID.TabIndex = 1;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(83, 64);
            this.txtProjectName.MaxLength = 50;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(229, 20);
            this.txtProjectName.TabIndex = 3;
            this.txtProjectName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProjectName_KeyDown);
            // 
            // txtProjectPrice
            // 
            this.txtProjectPrice.Location = new System.Drawing.Point(83, 116);
            this.txtProjectPrice.MaxLength = 50;
            this.txtProjectPrice.Name = "txtProjectPrice";
            this.txtProjectPrice.Size = new System.Drawing.Size(229, 20);
            this.txtProjectPrice.TabIndex = 5;
            this.txtProjectPrice.Enter += new System.EventHandler(this.txtProjectPrice_Enter);
            this.txtProjectPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProjectPrice_KeyDown);
            this.txtProjectPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProjectPrice_KeyPress);
            // 
            // txtProjectLimit
            // 
            this.txtProjectLimit.Location = new System.Drawing.Point(83, 142);
            this.txtProjectLimit.MaxLength = 50;
            this.txtProjectLimit.Name = "txtProjectLimit";
            this.txtProjectLimit.Size = new System.Drawing.Size(229, 20);
            this.txtProjectLimit.TabIndex = 6;
            this.txtProjectLimit.Enter += new System.EventHandler(this.txtProjectLimit_Enter);
            this.txtProjectLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProjectLimit_KeyDown);
            this.txtProjectLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProjectLimit_KeyPress);
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Location = new System.Drawing.Point(24, 15);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(57, 13);
            this.lblProjectID.TabIndex = 0;
            this.lblProjectID.Text = "Project ID:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(7, 67);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(74, 13);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblProjectStatus
            // 
            this.lblProjectStatus.AutoSize = true;
            this.lblProjectStatus.Location = new System.Drawing.Point(5, 93);
            this.lblProjectStatus.Name = "lblProjectStatus";
            this.lblProjectStatus.Size = new System.Drawing.Size(76, 13);
            this.lblProjectStatus.TabIndex = 0;
            this.lblProjectStatus.Text = "Project Status:";
            // 
            // lblProjectPrice
            // 
            this.lblProjectPrice.AutoSize = true;
            this.lblProjectPrice.Location = new System.Drawing.Point(11, 119);
            this.lblProjectPrice.Name = "lblProjectPrice";
            this.lblProjectPrice.Size = new System.Drawing.Size(70, 13);
            this.lblProjectPrice.TabIndex = 0;
            this.lblProjectPrice.Text = "Project Price:";
            // 
            // lblProjectLimit
            // 
            this.lblProjectLimit.AutoSize = true;
            this.lblProjectLimit.Location = new System.Drawing.Point(14, 145);
            this.lblProjectLimit.Name = "lblProjectLimit";
            this.lblProjectLimit.Size = new System.Drawing.Size(67, 13);
            this.lblProjectLimit.TabIndex = 0;
            this.lblProjectLimit.Text = "Project Limit:";
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
            this.cmbProjectStatus.TabIndex = 4;
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
            this.lblMaintenceContact.TabIndex = 0;
            this.lblMaintenceContact.Text = "Maintence Contact:";
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
            this.cmbMaintenceContact.TabIndex = 7;
            this.cmbMaintenceContact.Text = "No";
            this.cmbMaintenceContact.Click += new System.EventHandler(this.cmbMaintenceContact_Click);
            this.cmbMaintenceContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMaintenceContact_KeyDown);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(13, 41);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 10;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(83, 38);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(229, 20);
            this.txtCustomerID.TabIndex = 11;
            // 
            // frmAddProjects
            // 
            this.AcceptButton = this.btnCreate;
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
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Add - Project";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddProjects_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectPrice;
        private System.Windows.Forms.TextBox txtProjectLimit;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectStatus;
        private System.Windows.Forms.Label lblProjectPrice;
        private System.Windows.Forms.Label lblProjectLimit;
        private System.Windows.Forms.ComboBox cmbProjectStatus;
        private System.Windows.Forms.Label lblMaintenceContact;
        private System.Windows.Forms.ComboBox cmbMaintenceContact;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
    }
}