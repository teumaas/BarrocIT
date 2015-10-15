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
            this.itemSignout = new System.Windows.Forms.MenuItem();
            this.itemExit = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.tabConDepartments = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.btnPrintInfo = new System.Windows.Forms.Button();
            this.btnCustomersRemove = new System.Windows.Forms.Button();
            this.btnCustomersEdit = new System.Windows.Forms.Button();
            this.btnCustomersAdd = new System.Windows.Forms.Button();
            this.tabInvoices = new System.Windows.Forms.TabPage();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.groupBoxInvoices = new System.Windows.Forms.GroupBox();
            this.comboBoxPayedStatus = new System.Windows.Forms.ComboBox();
            this.lblPayedStatus = new System.Windows.Forms.Label();
            this.btnInvoicesRemove = new System.Windows.Forms.Button();
            this.btnInvoicesEdit = new System.Windows.Forms.Button();
            this.btnInvoicesAdd = new System.Windows.Forms.Button();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.groupBoxProjects = new System.Windows.Forms.GroupBox();
            this.btnProjectsView = new System.Windows.Forms.Button();
            this.tabMeetings = new System.Windows.Forms.TabPage();
            this.dataGridViewMeetings = new System.Windows.Forms.DataGridView();
            this.groupBoxMeetings = new System.Windows.Forms.GroupBox();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnMeetingsRemove = new System.Windows.Forms.Button();
            this.btnMeetingsEdit = new System.Windows.Forms.Button();
            this.btnMeetingsAdd = new System.Windows.Forms.Button();
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
            this.tabMeetings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).BeginInit();
            this.groupBoxMeetings.SuspendLayout();
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
            this.itemSignout,
            this.itemExit});
            this.menuFile.Text = "File";
            // 
            // itemSignout
            // 
            this.itemSignout.Index = 0;
            this.itemSignout.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.itemSignout.Text = "&Sign out";
            this.itemSignout.Click += new System.EventHandler(this.itemSignout_Click);
            // 
            // itemExit
            // 
            this.itemExit.Index = 1;
            this.itemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 1;
            this.menuHelp.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuHelp.Text = "&Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // tabConDepartments
            // 
            this.tabConDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConDepartments.Controls.Add(this.tabCustomers);
            this.tabConDepartments.Controls.Add(this.tabInvoices);
            this.tabConDepartments.Controls.Add(this.tabProjects);
            this.tabConDepartments.Controls.Add(this.tabMeetings);
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
            this.dataGridViewCustomers.Size = new System.Drawing.Size(833, 437);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustomers.Controls.Add(this.btnPrintInfo);
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
            // btnPrintInfo
            // 
            this.btnPrintInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintInfo.Location = new System.Drawing.Point(6, 106);
            this.btnPrintInfo.Name = "btnPrintInfo";
            this.btnPrintInfo.Size = new System.Drawing.Size(135, 23);
            this.btnPrintInfo.TabIndex = 0;
            this.btnPrintInfo.TabStop = false;
            this.btnPrintInfo.Text = "Print info";
            this.btnPrintInfo.UseVisualStyleBackColor = true;
            // 
            // btnCustomersRemove
            // 
            this.btnCustomersRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomersRemove.Location = new System.Drawing.Point(6, 77);
            this.btnCustomersRemove.Name = "btnCustomersRemove";
            this.btnCustomersRemove.Size = new System.Drawing.Size(135, 23);
            this.btnCustomersRemove.TabIndex = 0;
            this.btnCustomersRemove.TabStop = false;
            this.btnCustomersRemove.Text = "Remove";
            this.btnCustomersRemove.UseVisualStyleBackColor = true;
            // 
            // btnCustomersEdit
            // 
            this.btnCustomersEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomersEdit.Location = new System.Drawing.Point(6, 48);
            this.btnCustomersEdit.Name = "btnCustomersEdit";
            this.btnCustomersEdit.Size = new System.Drawing.Size(135, 23);
            this.btnCustomersEdit.TabIndex = 0;
            this.btnCustomersEdit.TabStop = false;
            this.btnCustomersEdit.Text = "Edit";
            this.btnCustomersEdit.UseVisualStyleBackColor = true;
            this.btnCustomersEdit.Click += new System.EventHandler(this.btnCustomersEdit_Click);
            // 
            // btnCustomersAdd
            // 
            this.btnCustomersAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomersAdd.Location = new System.Drawing.Point(6, 19);
            this.btnCustomersAdd.Name = "btnCustomersAdd";
            this.btnCustomersAdd.Size = new System.Drawing.Size(135, 23);
            this.btnCustomersAdd.TabIndex = 0;
            this.btnCustomersAdd.TabStop = false;
            this.btnCustomersAdd.Text = "Add";
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
            this.dataGridViewInvoices.Size = new System.Drawing.Size(833, 437);
            this.dataGridViewInvoices.TabIndex = 0;
            this.dataGridViewInvoices.TabStop = false;
            // 
            // groupBoxInvoices
            // 
            this.groupBoxInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInvoices.Controls.Add(this.comboBoxPayedStatus);
            this.groupBoxInvoices.Controls.Add(this.lblPayedStatus);
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
            // comboBoxPayedStatus
            // 
            this.comboBoxPayedStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayedStatus.FormattingEnabled = true;
            this.comboBoxPayedStatus.Items.AddRange(new object[] {
            "Unpayed",
            "Payed"});
            this.comboBoxPayedStatus.Location = new System.Drawing.Point(49, 106);
            this.comboBoxPayedStatus.Name = "comboBoxPayedStatus";
            this.comboBoxPayedStatus.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPayedStatus.TabIndex = 0;
            this.comboBoxPayedStatus.TabStop = false;
            // 
            // lblPayedStatus
            // 
            this.lblPayedStatus.AutoSize = true;
            this.lblPayedStatus.Location = new System.Drawing.Point(6, 110);
            this.lblPayedStatus.Name = "lblPayedStatus";
            this.lblPayedStatus.Size = new System.Drawing.Size(40, 13);
            this.lblPayedStatus.TabIndex = 0;
            this.lblPayedStatus.Text = "Status:";
            // 
            // btnInvoicesRemove
            // 
            this.btnInvoicesRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoicesRemove.Location = new System.Drawing.Point(6, 77);
            this.btnInvoicesRemove.Name = "btnInvoicesRemove";
            this.btnInvoicesRemove.Size = new System.Drawing.Size(135, 23);
            this.btnInvoicesRemove.TabIndex = 0;
            this.btnInvoicesRemove.TabStop = false;
            this.btnInvoicesRemove.Text = "Remove";
            this.btnInvoicesRemove.UseVisualStyleBackColor = true;
            // 
            // btnInvoicesEdit
            // 
            this.btnInvoicesEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoicesEdit.Location = new System.Drawing.Point(6, 48);
            this.btnInvoicesEdit.Name = "btnInvoicesEdit";
            this.btnInvoicesEdit.Size = new System.Drawing.Size(135, 23);
            this.btnInvoicesEdit.TabIndex = 0;
            this.btnInvoicesEdit.TabStop = false;
            this.btnInvoicesEdit.Text = "Edit";
            this.btnInvoicesEdit.UseVisualStyleBackColor = true;
            this.btnInvoicesEdit.Click += new System.EventHandler(this.btnInvoicesEdit_Click);
            // 
            // btnInvoicesAdd
            // 
            this.btnInvoicesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoicesAdd.Location = new System.Drawing.Point(6, 19);
            this.btnInvoicesAdd.Name = "btnInvoicesAdd";
            this.btnInvoicesAdd.Size = new System.Drawing.Size(135, 23);
            this.btnInvoicesAdd.TabIndex = 0;
            this.btnInvoicesAdd.TabStop = false;
            this.btnInvoicesAdd.Text = "Add";
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
            this.btnProjectsView.Location = new System.Drawing.Point(6, 19);
            this.btnProjectsView.Name = "btnProjectsView";
            this.btnProjectsView.Size = new System.Drawing.Size(135, 23);
            this.btnProjectsView.TabIndex = 0;
            this.btnProjectsView.TabStop = false;
            this.btnProjectsView.Text = "View Projects";
            this.btnProjectsView.UseVisualStyleBackColor = true;
            this.btnProjectsView.Click += new System.EventHandler(this.btnProjectsView_Click);
            // 
            // tabMeetings
            // 
            this.tabMeetings.BackColor = System.Drawing.SystemColors.Control;
            this.tabMeetings.Controls.Add(this.dataGridViewMeetings);
            this.tabMeetings.Controls.Add(this.groupBoxMeetings);
            this.tabMeetings.Location = new System.Drawing.Point(4, 22);
            this.tabMeetings.Name = "tabMeetings";
            this.tabMeetings.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeetings.Size = new System.Drawing.Size(996, 456);
            this.tabMeetings.TabIndex = 3;
            this.tabMeetings.Text = "Meetings";
            // 
            // dataGridViewMeetings
            // 
            this.dataGridViewMeetings.AllowUserToOrderColumns = true;
            this.dataGridViewMeetings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeetings.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewMeetings.Name = "dataGridViewMeetings";
            this.dataGridViewMeetings.Size = new System.Drawing.Size(833, 437);
            this.dataGridViewMeetings.TabIndex = 0;
            this.dataGridViewMeetings.TabStop = false;
            // 
            // groupBoxMeetings
            // 
            this.groupBoxMeetings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMeetings.Controls.Add(this.btnCalendar);
            this.groupBoxMeetings.Controls.Add(this.btnMeetingsRemove);
            this.groupBoxMeetings.Controls.Add(this.btnMeetingsEdit);
            this.groupBoxMeetings.Controls.Add(this.btnMeetingsAdd);
            this.groupBoxMeetings.Location = new System.Drawing.Point(843, 6);
            this.groupBoxMeetings.Name = "groupBoxMeetings";
            this.groupBoxMeetings.Size = new System.Drawing.Size(147, 137);
            this.groupBoxMeetings.TabIndex = 0;
            this.groupBoxMeetings.TabStop = false;
            this.groupBoxMeetings.Text = "Menu";
            // 
            // btnCalendar
            // 
            this.btnCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendar.Location = new System.Drawing.Point(6, 106);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(135, 23);
            this.btnCalendar.TabIndex = 0;
            this.btnCalendar.TabStop = false;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnMeetingsRemove
            // 
            this.btnMeetingsRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeetingsRemove.Location = new System.Drawing.Point(6, 77);
            this.btnMeetingsRemove.Name = "btnMeetingsRemove";
            this.btnMeetingsRemove.Size = new System.Drawing.Size(135, 23);
            this.btnMeetingsRemove.TabIndex = 0;
            this.btnMeetingsRemove.TabStop = false;
            this.btnMeetingsRemove.Text = "Remove";
            this.btnMeetingsRemove.UseVisualStyleBackColor = true;
            // 
            // btnMeetingsEdit
            // 
            this.btnMeetingsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeetingsEdit.Location = new System.Drawing.Point(6, 48);
            this.btnMeetingsEdit.Name = "btnMeetingsEdit";
            this.btnMeetingsEdit.Size = new System.Drawing.Size(135, 23);
            this.btnMeetingsEdit.TabIndex = 0;
            this.btnMeetingsEdit.TabStop = false;
            this.btnMeetingsEdit.Text = "Edit";
            this.btnMeetingsEdit.UseVisualStyleBackColor = true;
            this.btnMeetingsEdit.Click += new System.EventHandler(this.btnMeetingsEdit_Click);
            // 
            // btnMeetingsAdd
            // 
            this.btnMeetingsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeetingsAdd.Location = new System.Drawing.Point(6, 19);
            this.btnMeetingsAdd.Name = "btnMeetingsAdd";
            this.btnMeetingsAdd.Size = new System.Drawing.Size(135, 23);
            this.btnMeetingsAdd.TabIndex = 0;
            this.btnMeetingsAdd.TabStop = false;
            this.btnMeetingsAdd.Text = "Add";
            this.btnMeetingsAdd.UseVisualStyleBackColor = true;
            this.btnMeetingsAdd.Click += new System.EventHandler(this.btnMeetingsAdd_Click);
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
            this.Text = "{DEPARTMENT} - {SELECTED TAB}";
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
            this.tabMeetings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).EndInit();
            this.groupBoxMeetings.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabMeetings;
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
        private System.Windows.Forms.GroupBox groupBoxMeetings;
        private System.Windows.Forms.Button btnMeetingsRemove;
        private System.Windows.Forms.Button btnMeetingsEdit;
        private System.Windows.Forms.Button btnMeetingsAdd;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.DataGridView dataGridViewMeetings;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.ComboBox comboBoxPayedStatus;
        private System.Windows.Forms.Label lblPayedStatus;
        private System.Windows.Forms.Button btnPrintInfo;
        private System.Windows.Forms.Button btnCalendar;
    }
}