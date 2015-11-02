namespace BarrocIT
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menustripMain = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.itemRefresh = new System.Windows.Forms.MenuItem();
            this.itemSignout = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.itemExit = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.itemInfo = new System.Windows.Forms.MenuItem();
            this.tabConDepartments = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.btnCustomersPrintInfo = new System.Windows.Forms.Button();
            this.btnCustomersRemove = new System.Windows.Forms.Button();
            this.btnCustomersEdit = new System.Windows.Forms.Button();
            this.btnCustomersAdd = new System.Windows.Forms.Button();
            this.tabInvoices = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInvoicesView = new System.Windows.Forms.Button();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.groupBoxProjects = new System.Windows.Forms.GroupBox();
            this.btnProjectsView = new System.Windows.Forms.Button();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAppointmentsView = new System.Windows.Forms.Button();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.lblWhoami = new System.Windows.Forms.Label();
            this.tabConDepartments.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.groupBoxCustomers.SuspendLayout();
            this.tabInvoices.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.tabProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.groupBoxProjects.SuspendLayout();
            this.tabAppointments.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // menustripMain
            // 
            this.menustripMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuHelp});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.itemRefresh,
            this.itemSignout,
            this.menuItem1,
            this.itemExit});
            this.menuFile.Text = "File";
            // 
            // itemRefresh
            // 
            this.itemRefresh.Index = 0;
            this.itemRefresh.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.itemRefresh.Tag = "This refreshes the Database.";
            this.itemRefresh.Text = "Refresh";
            this.itemRefresh.Click += new System.EventHandler(this.itemRefresh_Click);
            // 
            // itemSignout
            // 
            this.itemSignout.Index = 1;
            this.itemSignout.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.itemSignout.Text = "&Sign out";
            this.itemSignout.Click += new System.EventHandler(this.itemSignout_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // itemExit
            // 
            this.itemExit.Index = 3;
            this.itemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 1;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.itemInfo});
            this.menuHelp.Text = "Help";
            // 
            // itemInfo
            // 
            this.itemInfo.Index = 0;
            this.itemInfo.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
            this.itemInfo.Text = "&Info";
            this.itemInfo.Click += new System.EventHandler(this.itemInfo_Click);
            // 
            // tabConDepartments
            // 
            this.tabConDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConDepartments.Controls.Add(this.tabCustomers);
            this.tabConDepartments.Controls.Add(this.tabInvoices);
            this.tabConDepartments.Controls.Add(this.tabProjects);
            this.tabConDepartments.Controls.Add(this.tabAppointments);
            this.tabConDepartments.Location = new System.Drawing.Point(9, 2);
            this.tabConDepartments.Name = "tabConDepartments";
            this.tabConDepartments.SelectedIndex = 0;
            this.tabConDepartments.Size = new System.Drawing.Size(1005, 460);
            this.tabConDepartments.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabConDepartments.TabIndex = 0;
            this.tabConDepartments.TabStop = false;
            this.tabConDepartments.SelectedIndexChanged += new System.EventHandler(this.tabConDepartments_SelectedIndexChanged);
            // 
            // tabCustomers
            // 
            this.tabCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.tabCustomers.Controls.Add(this.dataGridViewCustomers);
            this.tabCustomers.Controls.Add(this.groupBoxCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(997, 434);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            this.dataGridViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCustomers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewCustomers.MultiSelect = false;
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewCustomers.RowTemplate.Height = 32;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(835, 415);
            this.dataGridViewCustomers.StandardTab = true;
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.TabStop = false;
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustomers.Controls.Add(this.btnCustomersPrintInfo);
            this.groupBoxCustomers.Controls.Add(this.btnCustomersRemove);
            this.groupBoxCustomers.Controls.Add(this.btnCustomersEdit);
            this.groupBoxCustomers.Controls.Add(this.btnCustomersAdd);
            this.groupBoxCustomers.Location = new System.Drawing.Point(845, 7);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Size = new System.Drawing.Size(147, 137);
            this.groupBoxCustomers.TabIndex = 0;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Menu";
            // 
            // btnCustomersPrintInfo
            // 
            this.btnCustomersPrintInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomersPrintInfo.Enabled = false;
            this.btnCustomersPrintInfo.Image = global::BarrocIT.Properties.Resources.Print;
            this.btnCustomersPrintInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomersPrintInfo.Location = new System.Drawing.Point(6, 106);
            this.btnCustomersPrintInfo.Name = "btnCustomersPrintInfo";
            this.btnCustomersPrintInfo.Size = new System.Drawing.Size(135, 25);
            this.btnCustomersPrintInfo.TabIndex = 0;
            this.btnCustomersPrintInfo.TabStop = false;
            this.btnCustomersPrintInfo.Text = "Print info";
            this.btnCustomersPrintInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomersPrintInfo.UseVisualStyleBackColor = true;
            // 
            // btnCustomersRemove
            // 
            this.btnCustomersRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomersRemove.Image = global::BarrocIT.Properties.Resources.Remove;
            this.btnCustomersRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomersRemove.Location = new System.Drawing.Point(6, 77);
            this.btnCustomersRemove.Name = "btnCustomersRemove";
            this.btnCustomersRemove.Size = new System.Drawing.Size(135, 25);
            this.btnCustomersRemove.TabIndex = 0;
            this.btnCustomersRemove.TabStop = false;
            this.btnCustomersRemove.Text = "Remove";
            this.btnCustomersRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomersRemove.UseVisualStyleBackColor = true;
            this.btnCustomersRemove.Click += new System.EventHandler(this.btnCustomersRemove_Click);
            // 
            // btnCustomersEdit
            // 
            this.btnCustomersEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomersEdit.Image = global::BarrocIT.Properties.Resources.Edit;
            this.btnCustomersEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomersEdit.Location = new System.Drawing.Point(6, 48);
            this.btnCustomersEdit.Name = "btnCustomersEdit";
            this.btnCustomersEdit.Size = new System.Drawing.Size(135, 25);
            this.btnCustomersEdit.TabIndex = 0;
            this.btnCustomersEdit.TabStop = false;
            this.btnCustomersEdit.Text = "Edit";
            this.btnCustomersEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomersEdit.UseVisualStyleBackColor = true;
            this.btnCustomersEdit.Click += new System.EventHandler(this.btnCustomersEdit_Click);
            // 
            // btnCustomersAdd
            // 
            this.btnCustomersAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomersAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomersAdd.Image")));
            this.btnCustomersAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomersAdd.Location = new System.Drawing.Point(6, 19);
            this.btnCustomersAdd.Name = "btnCustomersAdd";
            this.btnCustomersAdd.Size = new System.Drawing.Size(135, 25);
            this.btnCustomersAdd.TabIndex = 0;
            this.btnCustomersAdd.TabStop = false;
            this.btnCustomersAdd.Text = "Add";
            this.btnCustomersAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomersAdd.UseVisualStyleBackColor = true;
            this.btnCustomersAdd.Click += new System.EventHandler(this.btnCustomersAdd_Click);
            // 
            // tabInvoices
            // 
            this.tabInvoices.BackColor = System.Drawing.SystemColors.Control;
            this.tabInvoices.Controls.Add(this.groupBox1);
            this.tabInvoices.Controls.Add(this.dataGridViewInvoices);
            this.tabInvoices.Location = new System.Drawing.Point(4, 22);
            this.tabInvoices.Name = "tabInvoices";
            this.tabInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoices.Size = new System.Drawing.Size(997, 434);
            this.tabInvoices.TabIndex = 1;
            this.tabInvoices.Text = "Invoices";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnInvoicesView);
            this.groupBox1.Location = new System.Drawing.Point(845, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnInvoicesView
            // 
            this.btnInvoicesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoicesView.Image = global::BarrocIT.Properties.Resources.Invoice;
            this.btnInvoicesView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoicesView.Location = new System.Drawing.Point(6, 19);
            this.btnInvoicesView.Name = "btnInvoicesView";
            this.btnInvoicesView.Size = new System.Drawing.Size(135, 25);
            this.btnInvoicesView.TabIndex = 0;
            this.btnInvoicesView.TabStop = false;
            this.btnInvoicesView.Text = "View Invoices";
            this.btnInvoicesView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoicesView.UseVisualStyleBackColor = true;
            this.btnInvoicesView.Click += new System.EventHandler(this.btnInvoicesView_Click);
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.AllowUserToAddRows = false;
            this.dataGridViewInvoices.AllowUserToDeleteRows = false;
            this.dataGridViewInvoices.AllowUserToResizeRows = false;
            this.dataGridViewInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewInvoices.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewInvoices.MultiSelect = false;
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.ReadOnly = true;
            this.dataGridViewInvoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewInvoices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewInvoices.RowTemplate.Height = 32;
            this.dataGridViewInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(835, 415);
            this.dataGridViewInvoices.StandardTab = true;
            this.dataGridViewInvoices.TabIndex = 0;
            this.dataGridViewInvoices.TabStop = false;
            // 
            // tabProjects
            // 
            this.tabProjects.BackColor = System.Drawing.SystemColors.Control;
            this.tabProjects.Controls.Add(this.dataGridViewProjects);
            this.tabProjects.Controls.Add(this.groupBoxProjects);
            this.tabProjects.Location = new System.Drawing.Point(4, 22);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjects.Size = new System.Drawing.Size(997, 434);
            this.tabProjects.TabIndex = 2;
            this.tabProjects.Text = "Projects";
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AllowUserToAddRows = false;
            this.dataGridViewProjects.AllowUserToDeleteRows = false;
            this.dataGridViewProjects.AllowUserToResizeRows = false;
            this.dataGridViewProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProjects.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProjects.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewProjects.MultiSelect = false;
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.ReadOnly = true;
            this.dataGridViewProjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewProjects.RowTemplate.Height = 32;
            this.dataGridViewProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjects.Size = new System.Drawing.Size(835, 415);
            this.dataGridViewProjects.StandardTab = true;
            this.dataGridViewProjects.TabIndex = 0;
            this.dataGridViewProjects.TabStop = false;
            // 
            // groupBoxProjects
            // 
            this.groupBoxProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProjects.Controls.Add(this.btnProjectsView);
            this.groupBoxProjects.Location = new System.Drawing.Point(845, 7);
            this.groupBoxProjects.Name = "groupBoxProjects";
            this.groupBoxProjects.Size = new System.Drawing.Size(147, 50);
            this.groupBoxProjects.TabIndex = 0;
            this.groupBoxProjects.TabStop = false;
            this.groupBoxProjects.Text = "Menu";
            // 
            // btnProjectsView
            // 
            this.btnProjectsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectsView.Image = global::BarrocIT.Properties.Resources.Project;
            this.btnProjectsView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProjectsView.Location = new System.Drawing.Point(6, 19);
            this.btnProjectsView.Name = "btnProjectsView";
            this.btnProjectsView.Size = new System.Drawing.Size(135, 25);
            this.btnProjectsView.TabIndex = 0;
            this.btnProjectsView.TabStop = false;
            this.btnProjectsView.Text = "View Projects";
            this.btnProjectsView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjectsView.UseVisualStyleBackColor = true;
            this.btnProjectsView.Click += new System.EventHandler(this.btnProjectsView_Click);
            // 
            // tabAppointments
            // 
            this.tabAppointments.BackColor = System.Drawing.SystemColors.Control;
            this.tabAppointments.Controls.Add(this.groupBox2);
            this.tabAppointments.Controls.Add(this.dataGridViewAppointments);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointments.Size = new System.Drawing.Size(997, 434);
            this.tabAppointments.TabIndex = 3;
            this.tabAppointments.Text = "Appointments";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAppointmentsView);
            this.groupBox2.Location = new System.Drawing.Point(845, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // btnAppointmentsView
            // 
            this.btnAppointmentsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppointmentsView.Image = global::BarrocIT.Properties.Resources.Calendar;
            this.btnAppointmentsView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppointmentsView.Location = new System.Drawing.Point(6, 19);
            this.btnAppointmentsView.Name = "btnAppointmentsView";
            this.btnAppointmentsView.Size = new System.Drawing.Size(135, 25);
            this.btnAppointmentsView.TabIndex = 0;
            this.btnAppointmentsView.TabStop = false;
            this.btnAppointmentsView.Text = "View Appointments";
            this.btnAppointmentsView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppointmentsView.UseVisualStyleBackColor = true;
            this.btnAppointmentsView.Click += new System.EventHandler(this.btnAppointmentsView_Click);
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToAddRows = false;
            this.dataGridViewAppointments.AllowUserToDeleteRows = false;
            this.dataGridViewAppointments.AllowUserToResizeRows = false;
            this.dataGridViewAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAppointments.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewAppointments.MultiSelect = false;
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.ReadOnly = true;
            this.dataGridViewAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAppointments.RowTemplate.Height = 32;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(835, 415);
            this.dataGridViewAppointments.StandardTab = true;
            this.dataGridViewAppointments.TabIndex = 0;
            this.dataGridViewAppointments.TabStop = false;
            // 
            // lblWhoami
            // 
            this.lblWhoami.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWhoami.AutoSize = true;
            this.lblWhoami.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWhoami.Location = new System.Drawing.Point(873, 5);
            this.lblWhoami.Name = "lblWhoami";
            this.lblWhoami.Size = new System.Drawing.Size(74, 13);
            this.lblWhoami.TabIndex = 0;
            this.lblWhoami.Text = "Logged in as: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 468);
            this.Controls.Add(this.lblWhoami);
            this.Controls.Add(this.tabConDepartments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.menustripMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.tabConDepartments.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.groupBoxCustomers.ResumeLayout(false);
            this.tabInvoices.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.tabProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.groupBoxProjects.ResumeLayout(false);
            this.tabAppointments.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu menustripMain;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.MenuItem itemSignout;
        private System.Windows.Forms.MenuItem itemExit;
        private System.Windows.Forms.MenuItem menuHelp;
        private System.Windows.Forms.TabControl tabConDepartments;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabInvoices;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.Button btnCustomersRemove;
        private System.Windows.Forms.Button btnCustomersEdit;
        private System.Windows.Forms.Button btnCustomersAdd;
        private System.Windows.Forms.GroupBox groupBoxProjects;
        private System.Windows.Forms.Button btnProjectsView;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button btnCustomersPrintInfo;
        private System.Windows.Forms.MenuItem itemRefresh;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem itemInfo;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInvoicesView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAppointmentsView;
        private System.Windows.Forms.Label lblWhoami;
    }
}