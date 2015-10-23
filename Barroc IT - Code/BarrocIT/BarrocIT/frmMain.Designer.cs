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
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.groupBoxInvoices = new System.Windows.Forms.GroupBox();
            this.cmbCustomersStatus = new System.Windows.Forms.ComboBox();
            this.lblCustomersStatus = new System.Windows.Forms.Label();
            this.btnInvoicesRemove = new System.Windows.Forms.Button();
            this.btnInvoicesEdit = new System.Windows.Forms.Button();
            this.btnInvoicesAdd = new System.Windows.Forms.Button();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.groupBoxProjects = new System.Windows.Forms.GroupBox();
            this.btnProjectsView = new System.Windows.Forms.Button();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.groupBoxAppointments = new System.Windows.Forms.GroupBox();
            this.btnAppointmentsCalendar = new System.Windows.Forms.Button();
            this.btnAppointmentsRemove = new System.Windows.Forms.Button();
            this.btnAppointmentsEdit = new System.Windows.Forms.Button();
            this.btnAppointmentsAdd = new System.Windows.Forms.Button();
            this.tabConDepartments.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.groupBoxCustomers.SuspendLayout();
            this.tabInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.groupBoxInvoices.SuspendLayout();
            this.tabProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.groupBoxProjects.SuspendLayout();
            this.tabAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.groupBoxAppointments.SuspendLayout();
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
            this.tabConDepartments.Size = new System.Drawing.Size(1004, 482);
            this.tabConDepartments.TabIndex = 0;
            this.tabConDepartments.TabStop = false;
            // 
            // tabCustomers
            // 
            this.tabCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.tabCustomers.Controls.Add(this.dataGridViewCustomers);
            this.tabCustomers.Controls.Add(this.groupBoxCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(996, 456);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToOrderColumns = true;
            this.dataGridViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(833, 437);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustomers.Controls.Add(this.btnCustomersPrintInfo);
            this.groupBoxCustomers.Controls.Add(this.btnCustomersRemove);
            this.groupBoxCustomers.Controls.Add(this.btnCustomersEdit);
            this.groupBoxCustomers.Controls.Add(this.btnCustomersAdd);
            this.groupBoxCustomers.Location = new System.Drawing.Point(843, 6);
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
            this.tabInvoices.Controls.Add(this.dataGridViewInvoices);
            this.tabInvoices.Controls.Add(this.groupBoxInvoices);
            this.tabInvoices.Location = new System.Drawing.Point(4, 22);
            this.tabInvoices.Name = "tabInvoices";
            this.tabInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoices.Size = new System.Drawing.Size(996, 456);
            this.tabInvoices.TabIndex = 1;
            this.tabInvoices.Text = "Invoices";
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.AllowUserToOrderColumns = true;
            this.dataGridViewInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.ReadOnly = true;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(833, 437);
            this.dataGridViewInvoices.TabIndex = 0;
            this.dataGridViewInvoices.TabStop = false;
            // 
            // groupBoxInvoices
            // 
            this.groupBoxInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInvoices.Controls.Add(this.cmbCustomersStatus);
            this.groupBoxInvoices.Controls.Add(this.lblCustomersStatus);
            this.groupBoxInvoices.Controls.Add(this.btnInvoicesRemove);
            this.groupBoxInvoices.Controls.Add(this.btnInvoicesEdit);
            this.groupBoxInvoices.Controls.Add(this.btnInvoicesAdd);
            this.groupBoxInvoices.Location = new System.Drawing.Point(843, 6);
            this.groupBoxInvoices.Name = "groupBoxInvoices";
            this.groupBoxInvoices.Size = new System.Drawing.Size(147, 137);
            this.groupBoxInvoices.TabIndex = 0;
            this.groupBoxInvoices.TabStop = false;
            this.groupBoxInvoices.Text = "Menu";
            // 
            // cmbCustomersStatus
            // 
            this.cmbCustomersStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomersStatus.FormattingEnabled = true;
            this.cmbCustomersStatus.Items.AddRange(new object[] {
            "Unpayed",
            "Payed"});
            this.cmbCustomersStatus.Location = new System.Drawing.Point(48, 108);
            this.cmbCustomersStatus.Name = "cmbCustomersStatus";
            this.cmbCustomersStatus.Size = new System.Drawing.Size(92, 21);
            this.cmbCustomersStatus.TabIndex = 0;
            this.cmbCustomersStatus.TabStop = false;
            // 
            // lblCustomersStatus
            // 
            this.lblCustomersStatus.AutoSize = true;
            this.lblCustomersStatus.Location = new System.Drawing.Point(6, 112);
            this.lblCustomersStatus.Name = "lblCustomersStatus";
            this.lblCustomersStatus.Size = new System.Drawing.Size(40, 13);
            this.lblCustomersStatus.TabIndex = 0;
            this.lblCustomersStatus.Text = "Status:";
            // 
            // btnInvoicesRemove
            // 
            this.btnInvoicesRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoicesRemove.Image = global::BarrocIT.Properties.Resources.Remove;
            this.btnInvoicesRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoicesRemove.Location = new System.Drawing.Point(6, 77);
            this.btnInvoicesRemove.Name = "btnInvoicesRemove";
            this.btnInvoicesRemove.Size = new System.Drawing.Size(135, 25);
            this.btnInvoicesRemove.TabIndex = 0;
            this.btnInvoicesRemove.TabStop = false;
            this.btnInvoicesRemove.Text = "Remove";
            this.btnInvoicesRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoicesRemove.UseVisualStyleBackColor = true;
            // 
            // btnInvoicesEdit
            // 
            this.btnInvoicesEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoicesEdit.Image = global::BarrocIT.Properties.Resources.Edit;
            this.btnInvoicesEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoicesEdit.Location = new System.Drawing.Point(6, 48);
            this.btnInvoicesEdit.Name = "btnInvoicesEdit";
            this.btnInvoicesEdit.Size = new System.Drawing.Size(135, 25);
            this.btnInvoicesEdit.TabIndex = 0;
            this.btnInvoicesEdit.TabStop = false;
            this.btnInvoicesEdit.Text = "Edit";
            this.btnInvoicesEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoicesEdit.UseVisualStyleBackColor = true;
            this.btnInvoicesEdit.Click += new System.EventHandler(this.btnInvoicesEdit_Click);
            // 
            // btnInvoicesAdd
            // 
            this.btnInvoicesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoicesAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoicesAdd.Image")));
            this.btnInvoicesAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoicesAdd.Location = new System.Drawing.Point(6, 19);
            this.btnInvoicesAdd.Name = "btnInvoicesAdd";
            this.btnInvoicesAdd.Size = new System.Drawing.Size(135, 25);
            this.btnInvoicesAdd.TabIndex = 0;
            this.btnInvoicesAdd.TabStop = false;
            this.btnInvoicesAdd.Text = "Add";
            this.btnInvoicesAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoicesAdd.UseVisualStyleBackColor = true;
            this.btnInvoicesAdd.Click += new System.EventHandler(this.btnInvoicesAdd_Click);
            // 
            // tabProjects
            // 
            this.tabProjects.BackColor = System.Drawing.SystemColors.Control;
            this.tabProjects.Controls.Add(this.dataGridViewProjects);
            this.tabProjects.Controls.Add(this.groupBoxProjects);
            this.tabProjects.Location = new System.Drawing.Point(4, 22);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjects.Size = new System.Drawing.Size(996, 456);
            this.tabProjects.TabIndex = 2;
            this.tabProjects.Text = "Projects";
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AllowUserToOrderColumns = true;
            this.dataGridViewProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.ReadOnly = true;
            this.dataGridViewProjects.Size = new System.Drawing.Size(833, 437);
            this.dataGridViewProjects.TabIndex = 0;
            this.dataGridViewProjects.TabStop = false;
            // 
            // groupBoxProjects
            // 
            this.groupBoxProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProjects.Controls.Add(this.btnProjectsView);
            this.groupBoxProjects.Location = new System.Drawing.Point(843, 6);
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
            this.tabAppointments.Controls.Add(this.dataGridViewAppointments);
            this.tabAppointments.Controls.Add(this.groupBoxAppointments);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointments.Size = new System.Drawing.Size(996, 456);
            this.tabAppointments.TabIndex = 3;
            this.tabAppointments.Text = "Appointments";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToOrderColumns = true;
            this.dataGridViewAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.ReadOnly = true;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(833, 437);
            this.dataGridViewAppointments.TabIndex = 0;
            this.dataGridViewAppointments.TabStop = false;
            // 
            // groupBoxAppointments
            // 
            this.groupBoxAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAppointments.Controls.Add(this.btnAppointmentsCalendar);
            this.groupBoxAppointments.Controls.Add(this.btnAppointmentsRemove);
            this.groupBoxAppointments.Controls.Add(this.btnAppointmentsEdit);
            this.groupBoxAppointments.Controls.Add(this.btnAppointmentsAdd);
            this.groupBoxAppointments.Location = new System.Drawing.Point(843, 6);
            this.groupBoxAppointments.Name = "groupBoxAppointments";
            this.groupBoxAppointments.Size = new System.Drawing.Size(147, 137);
            this.groupBoxAppointments.TabIndex = 0;
            this.groupBoxAppointments.TabStop = false;
            this.groupBoxAppointments.Text = "Menu";
            // 
            // btnAppointmentsCalendar
            // 
            this.btnAppointmentsCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppointmentsCalendar.Image = global::BarrocIT.Properties.Resources.Calendar;
            this.btnAppointmentsCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppointmentsCalendar.Location = new System.Drawing.Point(6, 106);
            this.btnAppointmentsCalendar.Name = "btnAppointmentsCalendar";
            this.btnAppointmentsCalendar.Size = new System.Drawing.Size(135, 25);
            this.btnAppointmentsCalendar.TabIndex = 0;
            this.btnAppointmentsCalendar.TabStop = false;
            this.btnAppointmentsCalendar.Text = "Calendar";
            this.btnAppointmentsCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppointmentsCalendar.UseVisualStyleBackColor = true;
            this.btnAppointmentsCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnAppointmentsRemove
            // 
            this.btnAppointmentsRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppointmentsRemove.Image = global::BarrocIT.Properties.Resources.Remove;
            this.btnAppointmentsRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppointmentsRemove.Location = new System.Drawing.Point(6, 77);
            this.btnAppointmentsRemove.Name = "btnAppointmentsRemove";
            this.btnAppointmentsRemove.Size = new System.Drawing.Size(135, 25);
            this.btnAppointmentsRemove.TabIndex = 0;
            this.btnAppointmentsRemove.TabStop = false;
            this.btnAppointmentsRemove.Text = "Remove";
            this.btnAppointmentsRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppointmentsRemove.UseVisualStyleBackColor = true;
            // 
            // btnAppointmentsEdit
            // 
            this.btnAppointmentsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppointmentsEdit.Image = global::BarrocIT.Properties.Resources.Edit;
            this.btnAppointmentsEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppointmentsEdit.Location = new System.Drawing.Point(6, 48);
            this.btnAppointmentsEdit.Name = "btnAppointmentsEdit";
            this.btnAppointmentsEdit.Size = new System.Drawing.Size(135, 25);
            this.btnAppointmentsEdit.TabIndex = 0;
            this.btnAppointmentsEdit.TabStop = false;
            this.btnAppointmentsEdit.Text = "Edit";
            this.btnAppointmentsEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppointmentsEdit.UseVisualStyleBackColor = true;
            this.btnAppointmentsEdit.Click += new System.EventHandler(this.btnAppointmentsEdit_Click);
            // 
            // btnAppointmentsAdd
            // 
            this.btnAppointmentsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppointmentsAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointmentsAdd.Image")));
            this.btnAppointmentsAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppointmentsAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAppointmentsAdd.Name = "btnAppointmentsAdd";
            this.btnAppointmentsAdd.Size = new System.Drawing.Size(135, 25);
            this.btnAppointmentsAdd.TabIndex = 0;
            this.btnAppointmentsAdd.TabStop = false;
            this.btnAppointmentsAdd.Text = "Add";
            this.btnAppointmentsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppointmentsAdd.UseVisualStyleBackColor = true;
            this.btnAppointmentsAdd.Click += new System.EventHandler(this.btnAppointmentsAdd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 489);
            this.Controls.Add(this.tabConDepartments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.menustripMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - {DEPARTMENT} - {SELECTED TAB}";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabConDepartments.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.groupBoxCustomers.ResumeLayout(false);
            this.tabInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.groupBoxInvoices.ResumeLayout(false);
            this.groupBoxInvoices.PerformLayout();
            this.tabProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.groupBoxProjects.ResumeLayout(false);
            this.tabAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.groupBoxAppointments.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBoxInvoices;
        private System.Windows.Forms.Button btnInvoicesRemove;
        private System.Windows.Forms.Button btnInvoicesEdit;
        private System.Windows.Forms.Button btnInvoicesAdd;
        private System.Windows.Forms.GroupBox groupBoxProjects;
        private System.Windows.Forms.Button btnProjectsView;
        private System.Windows.Forms.GroupBox groupBoxAppointments;
        private System.Windows.Forms.Button btnAppointmentsRemove;
        private System.Windows.Forms.Button btnAppointmentsEdit;
        private System.Windows.Forms.Button btnAppointmentsAdd;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.ComboBox cmbCustomersStatus;
        private System.Windows.Forms.Label lblCustomersStatus;
        private System.Windows.Forms.Button btnCustomersPrintInfo;
        private System.Windows.Forms.Button btnAppointmentsCalendar;
        private System.Windows.Forms.MenuItem itemRefresh;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem itemInfo;
    }
}