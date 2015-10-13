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
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();

            var pos = this.PointToScreen(lblInfo.Location);
            pos = picLogo.PointToClient(pos);
            lblInfo.Parent = picLogo;
            lblInfo.Location = pos;
            lblInfo.BackColor = Color.Transparent;

            txtAssembly.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            txtPassword.Text = "Password";
            txtPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            txtPassword.ForeColor = SystemColors.ControlDarkDark;
            cmbUsername.Text = "Select department...";
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
    }
}
