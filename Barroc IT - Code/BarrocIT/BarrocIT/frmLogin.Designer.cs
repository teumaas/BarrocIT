namespace BarrocIT
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picDepartments = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.txtAssembly = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Image = global::BarrocIT.Properties.Resources.Key;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(219, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 25);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(35, 167);
            this.txtPassword.MaxLength = 24;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TabStop = false;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // cmbUsername
            // 
            this.cmbUsername.BackColor = System.Drawing.SystemColors.Window;
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(35, 141);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(261, 21);
            this.cmbUsername.TabIndex = 0;
            this.cmbUsername.TabStop = false;
            this.cmbUsername.Enter += new System.EventHandler(this.cmbUsername_Enter);
            this.cmbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUsername_KeyDown);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(11, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(184, 46);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "BARROC IT.\r\nSOFTWARE FOR REAL.";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::BarrocIT.Properties.Resources.BarrocLogo;
            this.picLogo.Location = new System.Drawing.Point(-1, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(351, 129);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // picDepartments
            // 
            this.picDepartments.Image = global::BarrocIT.Properties.Resources.Departments;
            this.picDepartments.Location = new System.Drawing.Point(11, 143);
            this.picDepartments.Name = "picDepartments";
            this.picDepartments.Size = new System.Drawing.Size(16, 16);
            this.picDepartments.TabIndex = 6;
            this.picDepartments.TabStop = false;
            // 
            // picPassword
            // 
            this.picPassword.Image = global::BarrocIT.Properties.Resources.Password;
            this.picPassword.Location = new System.Drawing.Point(11, 169);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(16, 16);
            this.picPassword.TabIndex = 7;
            this.picPassword.TabStop = false;
            // 
            // txtAssembly
            // 
            this.txtAssembly.AutoSize = true;
            this.txtAssembly.Location = new System.Drawing.Point(11, 204);
            this.txtAssembly.Name = "txtAssembly";
            this.txtAssembly.Size = new System.Drawing.Size(80, 13);
            this.txtAssembly.TabIndex = 8;
            this.txtAssembly.Text = "{Assembly Info}";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(308, 227);
            this.Controls.Add(this.txtAssembly);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.picDepartments);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Login";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picDepartments;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Label txtAssembly;
        private System.Windows.Forms.ComboBox cmbUsername;
    }
}

