using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIT
{
    public partial class frmLogin : Form
    {
        // Create Object here.
        DatabaseHandler sqlHandler;
        frmMain mainForm;

        public frmLogin()
        {
            InitializeComponent();

            mainForm = new frmMain();

            //txtInfo - Color
            var pos = this.PointToScreen(lblInfo.Location);
            pos = picLogo.PointToClient(pos);
            lblInfo.Parent = picLogo;
            lblInfo.Location = pos;
            lblInfo.BackColor = Color.Transparent;

            //Textboxes Properties
            cmbUsername.Text = "Select department...";

            txtPassword.Text = "Password";
            txtPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            txtPassword.ForeColor = SystemColors.ControlDarkDark;

            cmbUsername.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            cmbUsername.ForeColor = SystemColors.ControlDarkDark;

            txtAssembly.ForeColor = SystemColors.ControlDarkDark;
            txtAssembly.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = string.Empty;
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtPassword.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                txtPassword.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
    }
}
