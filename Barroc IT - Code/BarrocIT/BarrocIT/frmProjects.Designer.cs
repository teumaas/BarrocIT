namespace BarrocIT
{
    partial class frmProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjects));
            this.dataGridAddProject = new System.Windows.Forms.DataGridView();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.btnProjectRemove = new System.Windows.Forms.Button();
            this.btnProjectEdit = new System.Windows.Forms.Button();
            this.btnProjectAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddProject)).BeginInit();
            this.groupBoxCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAddProject
            // 
            this.dataGridAddProject.AllowUserToAddRows = false;
            this.dataGridAddProject.AllowUserToDeleteRows = false;
            this.dataGridAddProject.AllowUserToResizeColumns = false;
            this.dataGridAddProject.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridAddProject, "dataGridAddProject");
            this.dataGridAddProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAddProject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAddProject.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridAddProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAddProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAddProject.MultiSelect = false;
            this.dataGridAddProject.Name = "dataGridAddProject";
            this.dataGridAddProject.ReadOnly = true;
            this.dataGridAddProject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAddProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridAddProject.RowTemplate.Height = 32;
            this.dataGridAddProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddProject.StandardTab = true;
            this.dataGridAddProject.TabStop = false;
            // 
            // groupBoxCustomers
            // 
            resources.ApplyResources(this.groupBoxCustomers, "groupBoxCustomers");
            this.groupBoxCustomers.Controls.Add(this.btnProjectRemove);
            this.groupBoxCustomers.Controls.Add(this.btnProjectEdit);
            this.groupBoxCustomers.Controls.Add(this.btnProjectAdd);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.TabStop = false;
            // 
            // btnProjectRemove
            // 
            resources.ApplyResources(this.btnProjectRemove, "btnProjectRemove");
            this.btnProjectRemove.Image = global::BarrocIT.Properties.Resources.Remove;
            this.btnProjectRemove.Name = "btnProjectRemove";
            this.btnProjectRemove.TabStop = false;
            this.btnProjectRemove.UseVisualStyleBackColor = true;
            this.btnProjectRemove.Click += new System.EventHandler(this.btnProjectRemove_Click);
            // 
            // btnProjectEdit
            // 
            resources.ApplyResources(this.btnProjectEdit, "btnProjectEdit");
            this.btnProjectEdit.Image = global::BarrocIT.Properties.Resources.Edit;
            this.btnProjectEdit.Name = "btnProjectEdit";
            this.btnProjectEdit.TabStop = false;
            this.btnProjectEdit.UseVisualStyleBackColor = true;
            this.btnProjectEdit.Click += new System.EventHandler(this.btnProjectEdit_Click);
            // 
            // btnProjectAdd
            // 
            resources.ApplyResources(this.btnProjectAdd, "btnProjectAdd");
            this.btnProjectAdd.Name = "btnProjectAdd";
            this.btnProjectAdd.TabStop = false;
            this.btnProjectAdd.UseVisualStyleBackColor = true;
            this.btnProjectAdd.Click += new System.EventHandler(this.btnProjectAdd_Click);
            // 
            // frmProjects
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridAddProject);
            this.Controls.Add(this.groupBoxCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProjects";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProjects_FormClosing);
            this.Validated += new System.EventHandler(this.frmProjects_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddProject)).EndInit();
            this.groupBoxCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.Button btnProjectRemove;
        private System.Windows.Forms.Button btnProjectEdit;
        private System.Windows.Forms.Button btnProjectAdd;
        private System.Windows.Forms.DataGridView dataGridAddProject;
    }
}