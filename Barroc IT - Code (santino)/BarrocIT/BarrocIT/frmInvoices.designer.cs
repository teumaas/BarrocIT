namespace BarrocIT
{
    partial class frmInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoices));
            this.dataGridAddInvoice = new System.Windows.Forms.DataGridView();
            this.btnInvoicesPrintInvoice = new System.Windows.Forms.Button();
            this.btnInvoicesRemove = new System.Windows.Forms.Button();
            this.btnInvoicesEdit = new System.Windows.Forms.Button();
            this.btnInvoicesAdd = new System.Windows.Forms.Button();
            this.groupBoxInvoices = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddInvoice)).BeginInit();
            this.groupBoxInvoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAddInvoice
            // 
            this.dataGridAddInvoice.AllowUserToAddRows = false;
            this.dataGridAddInvoice.AllowUserToDeleteRows = false;
            this.dataGridAddInvoice.AllowUserToResizeColumns = false;
            this.dataGridAddInvoice.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridAddInvoice, "dataGridAddInvoice");
            this.dataGridAddInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAddInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAddInvoice.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridAddInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAddInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAddInvoice.MultiSelect = false;
            this.dataGridAddInvoice.Name = "dataGridAddInvoice";
            this.dataGridAddInvoice.ReadOnly = true;
            this.dataGridAddInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAddInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridAddInvoice.RowTemplate.Height = 32;
            this.dataGridAddInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddInvoice.StandardTab = true;
            this.dataGridAddInvoice.TabStop = false;
            // 
            // btnInvoicesPrintInvoice
            // 
            resources.ApplyResources(this.btnInvoicesPrintInvoice, "btnInvoicesPrintInvoice");
            this.btnInvoicesPrintInvoice.Image = global::BarrocIT.Properties.Resources.Print;
            this.btnInvoicesPrintInvoice.Name = "btnInvoicesPrintInvoice";
            this.btnInvoicesPrintInvoice.TabStop = false;
            this.btnInvoicesPrintInvoice.UseVisualStyleBackColor = true;
            this.btnInvoicesPrintInvoice.Click += new System.EventHandler(this.btnInvoicesPrintInvoice_Click);
            // 
            // btnInvoicesRemove
            // 
            resources.ApplyResources(this.btnInvoicesRemove, "btnInvoicesRemove");
            this.btnInvoicesRemove.Image = global::BarrocIT.Properties.Resources.Remove;
            this.btnInvoicesRemove.Name = "btnInvoicesRemove";
            this.btnInvoicesRemove.TabStop = false;
            this.btnInvoicesRemove.UseVisualStyleBackColor = true;
            this.btnInvoicesRemove.Click += new System.EventHandler(this.btnInvoicesRemove_Click);
            // 
            // btnInvoicesEdit
            // 
            resources.ApplyResources(this.btnInvoicesEdit, "btnInvoicesEdit");
            this.btnInvoicesEdit.Image = global::BarrocIT.Properties.Resources.Edit;
            this.btnInvoicesEdit.Name = "btnInvoicesEdit";
            this.btnInvoicesEdit.TabStop = false;
            this.btnInvoicesEdit.UseVisualStyleBackColor = true;
            this.btnInvoicesEdit.Click += new System.EventHandler(this.btnInvoicesEdit_Click);
            // 
            // btnInvoicesAdd
            // 
            resources.ApplyResources(this.btnInvoicesAdd, "btnInvoicesAdd");
            this.btnInvoicesAdd.Name = "btnInvoicesAdd";
            this.btnInvoicesAdd.TabStop = false;
            this.btnInvoicesAdd.UseVisualStyleBackColor = true;
            this.btnInvoicesAdd.Click += new System.EventHandler(this.btnInvoicesAdd_Click);
            // 
            // groupBoxInvoices
            // 
            resources.ApplyResources(this.groupBoxInvoices, "groupBoxInvoices");
            this.groupBoxInvoices.Controls.Add(this.btnInvoicesPrintInvoice);
            this.groupBoxInvoices.Controls.Add(this.btnInvoicesRemove);
            this.groupBoxInvoices.Controls.Add(this.btnInvoicesEdit);
            this.groupBoxInvoices.Controls.Add(this.btnInvoicesAdd);
            this.groupBoxInvoices.Name = "groupBoxInvoices";
            this.groupBoxInvoices.TabStop = false;
            // 
            // frmInvoices
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxInvoices);
            this.Controls.Add(this.dataGridAddInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoices";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInvoices_FormClosing);
            this.Validated += new System.EventHandler(this.frmInvoices_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddInvoice)).EndInit();
            this.groupBoxInvoices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridAddInvoice;
        private System.Windows.Forms.Button btnInvoicesPrintInvoice;
        private System.Windows.Forms.Button btnInvoicesRemove;
        private System.Windows.Forms.Button btnInvoicesEdit;
        private System.Windows.Forms.Button btnInvoicesAdd;
        private System.Windows.Forms.GroupBox groupBoxInvoices;
    }
}