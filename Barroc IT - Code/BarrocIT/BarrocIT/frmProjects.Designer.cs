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
            this.dataGridAddProject.AllowUserToOrderColumns = true;
            this.dataGridAddProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAddProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAddProject.Location = new System.Drawing.Point(12, 12);
            this.dataGridAddProject.Name = "dataGridAddProject";
            this.dataGridAddProject.ReadOnly = true;
            this.dataGridAddProject.Size = new System.Drawing.Size(696, 363);
            this.dataGridAddProject.TabIndex = 0;
            this.dataGridAddProject.TabStop = false;
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustomers.Controls.Add(this.btnProjectRemove);
            this.groupBoxCustomers.Controls.Add(this.btnProjectEdit);
            this.groupBoxCustomers.Controls.Add(this.btnProjectAdd);
            this.groupBoxCustomers.Location = new System.Drawing.Point(714, 6);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Size = new System.Drawing.Size(147, 107);
            this.groupBoxCustomers.TabIndex = 0;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Menu";
            // 
            // btnProjectRemove
            // 
            this.btnProjectRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectRemove.Image = global::BarrocIT.Properties.Resources.Remove;
            this.btnProjectRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProjectRemove.Location = new System.Drawing.Point(6, 77);
            this.btnProjectRemove.Name = "btnProjectRemove";
            this.btnProjectRemove.Size = new System.Drawing.Size(135, 25);
            this.btnProjectRemove.TabIndex = 0;
            this.btnProjectRemove.TabStop = false;
            this.btnProjectRemove.Text = "Remove";
            this.btnProjectRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjectRemove.UseVisualStyleBackColor = true;
            // 
            // btnProjectEdit
            // 
            this.btnProjectEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectEdit.Image = global::BarrocIT.Properties.Resources.Edit;
            this.btnProjectEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProjectEdit.Location = new System.Drawing.Point(6, 48);
            this.btnProjectEdit.Name = "btnProjectEdit";
            this.btnProjectEdit.Size = new System.Drawing.Size(135, 25);
            this.btnProjectEdit.TabIndex = 0;
            this.btnProjectEdit.TabStop = false;
            this.btnProjectEdit.Text = "Edit";
            this.btnProjectEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjectEdit.UseVisualStyleBackColor = true;
            this.btnProjectEdit.Click += new System.EventHandler(this.btnProjectEdit_Click);
            // 
            // btnProjectAdd
            // 
            this.btnProjectAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectAdd.Image")));
            this.btnProjectAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProjectAdd.Location = new System.Drawing.Point(6, 19);
            this.btnProjectAdd.Name = "btnProjectAdd";
            this.btnProjectAdd.Size = new System.Drawing.Size(135, 25);
            this.btnProjectAdd.TabIndex = 0;
            this.btnProjectAdd.TabStop = false;
            this.btnProjectAdd.Text = "Add";
            this.btnProjectAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjectAdd.UseVisualStyleBackColor = true;
            this.btnProjectAdd.Click += new System.EventHandler(this.btnProjectAdd_Click);
            // 
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 387);
            this.Controls.Add(this.dataGridAddProject);
            this.Controls.Add(this.groupBoxCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Customer Projects";
            this.Load += new System.EventHandler(this.frmProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddProject)).EndInit();
            this.groupBoxCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAddProject;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.Button btnProjectRemove;
        private System.Windows.Forms.Button btnProjectEdit;
        private System.Windows.Forms.Button btnProjectAdd;
    }
}