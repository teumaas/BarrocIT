namespace BarrocIT
{
    partial class frmAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointments));
            this.dataGridAddAppointment = new System.Windows.Forms.DataGridView();
            this.groupBoxAppointments = new System.Windows.Forms.GroupBox();
            this.btnAppointmentsCalendar = new System.Windows.Forms.Button();
            this.btnAppointmentsRemove = new System.Windows.Forms.Button();
            this.btnAppointmentsEdit = new System.Windows.Forms.Button();
            this.btnAppointmentsAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddAppointment)).BeginInit();
            this.groupBoxAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAddAppointment
            // 
            this.dataGridAddAppointment.AllowUserToAddRows = false;
            this.dataGridAddAppointment.AllowUserToDeleteRows = false;
            this.dataGridAddAppointment.AllowUserToResizeColumns = false;
            this.dataGridAddAppointment.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridAddAppointment, "dataGridAddAppointment");
            this.dataGridAddAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAddAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAddAppointment.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridAddAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAddAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAddAppointment.MultiSelect = false;
            this.dataGridAddAppointment.Name = "dataGridAddAppointment";
            this.dataGridAddAppointment.ReadOnly = true;
            this.dataGridAddAppointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAddAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridAddAppointment.RowTemplate.Height = 32;
            this.dataGridAddAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddAppointment.StandardTab = true;
            this.dataGridAddAppointment.TabStop = false;
            // 
            // groupBoxAppointments
            // 
            resources.ApplyResources(this.groupBoxAppointments, "groupBoxAppointments");
            this.groupBoxAppointments.Controls.Add(this.btnAppointmentsCalendar);
            this.groupBoxAppointments.Controls.Add(this.btnAppointmentsRemove);
            this.groupBoxAppointments.Controls.Add(this.btnAppointmentsEdit);
            this.groupBoxAppointments.Controls.Add(this.btnAppointmentsAdd);
            this.groupBoxAppointments.Name = "groupBoxAppointments";
            this.groupBoxAppointments.TabStop = false;
            // 
            // btnAppointmentsCalendar
            // 
            resources.ApplyResources(this.btnAppointmentsCalendar, "btnAppointmentsCalendar");
            this.btnAppointmentsCalendar.Image = global::BarrocIT.Properties.Resources.Calendar;
            this.btnAppointmentsCalendar.Name = "btnAppointmentsCalendar";
            this.btnAppointmentsCalendar.TabStop = false;
            this.btnAppointmentsCalendar.UseVisualStyleBackColor = true;
            this.btnAppointmentsCalendar.Click += new System.EventHandler(this.btnAppointmentsCalendar_Click);
            // 
            // btnAppointmentsRemove
            // 
            resources.ApplyResources(this.btnAppointmentsRemove, "btnAppointmentsRemove");
            this.btnAppointmentsRemove.Image = global::BarrocIT.Properties.Resources.Remove;
            this.btnAppointmentsRemove.Name = "btnAppointmentsRemove";
            this.btnAppointmentsRemove.TabStop = false;
            this.btnAppointmentsRemove.UseVisualStyleBackColor = true;
            this.btnAppointmentsRemove.Click += new System.EventHandler(this.btnAppointmentsRemove_Click);
            // 
            // btnAppointmentsEdit
            // 
            resources.ApplyResources(this.btnAppointmentsEdit, "btnAppointmentsEdit");
            this.btnAppointmentsEdit.Image = global::BarrocIT.Properties.Resources.Edit;
            this.btnAppointmentsEdit.Name = "btnAppointmentsEdit";
            this.btnAppointmentsEdit.TabStop = false;
            this.btnAppointmentsEdit.UseVisualStyleBackColor = true;
            this.btnAppointmentsEdit.Click += new System.EventHandler(this.btnAppointmentsEdit_Click);
            // 
            // btnAppointmentsAdd
            // 
            resources.ApplyResources(this.btnAppointmentsAdd, "btnAppointmentsAdd");
            this.btnAppointmentsAdd.Name = "btnAppointmentsAdd";
            this.btnAppointmentsAdd.TabStop = false;
            this.btnAppointmentsAdd.UseVisualStyleBackColor = true;
            this.btnAppointmentsAdd.Click += new System.EventHandler(this.btnAppointmentsAdd_Click);
            // 
            // frmAppointments
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAppointments);
            this.Controls.Add(this.dataGridAddAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppointments";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAppointments_FormClosing);
            this.Validated += new System.EventHandler(this.frmAppointments_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddAppointment)).EndInit();
            this.groupBoxAppointments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridAddAppointment;
        private System.Windows.Forms.GroupBox groupBoxAppointments;
        private System.Windows.Forms.Button btnAppointmentsCalendar;
        private System.Windows.Forms.Button btnAppointmentsRemove;
        private System.Windows.Forms.Button btnAppointmentsEdit;
        private System.Windows.Forms.Button btnAppointmentsAdd;
    }
}