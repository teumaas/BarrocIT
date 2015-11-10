// Made by Tom Smits..

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
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BarrocIT
{
    public partial class frmLogin : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private SqlDataReader SQLReader;
        private frmMain main;

        private bool txtPasswordWrong;

        public frmLogin()
        {
            InitializeComponent();

            //txtInfo - Color
            Point pos = this.PointToScreen(lblInfo.Location);
            pos = picLogo.PointToClient(pos);
            lblInfo.Parent = picLogo;
            lblInfo.Location = pos;
            lblInfo.BackColor = Color.Transparent;

            string[] departments = new string[4] { "Sales", "Finance", "Development", "Administration" };

            //Textboxes & Buttons
            for (int i = 0; i < 4; i++)
            {
                cmbUsername.Items.Add(departments[i]);
            }
            cmbUsername.Text = "Select department...";
            txtPassword.Text = "Password";
            btnLogin.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.BorderStyle = BorderStyle.Fixed3D;

            //Assembly Info
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            lblAssembly.Text = "Version: " + fvi.ProductVersion;
            lblDeveloped.Text = "Developed by " + fvi.CompanyName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(cmbUsername.Text, txtPassword.Text);
        }


        private void Login(string UN, string PW)
        {
            UN = cmbUsername.Text;
            PW = txtPassword.Text;

            SQLHandler = new DatabaseHandler();
            SQLCommand = new SqlCommand("SELECT * FROM tbl_users WHERE Username = @Username AND Password = @Password", SQLHandler.getConnection());
            SQLHandler.openConnection();

            SQLCommand.Parameters.AddWithValue("@Username", UN);
            SQLCommand.Parameters.AddWithValue("@Password", PW);

            SQLReader = SQLCommand.ExecuteReader();

            int count = 0;

            while (SQLReader.Read())
            {
                count++;
            }

            if (count > 0)
            {
                main = new frmMain(UN);
                main.Show();
                this.Hide();
                SQLHandler.closeConnection();
            }
            else
            {
                txtPassword.Text = string.Empty;
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Invaild Password!";
                txtPasswordWrong = true;
                this.Refresh();
                txtPassword.SelectionStart = 0;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPassword.Text == "Invaild Password!")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = string.Empty;
                txtPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
                txtPasswordWrong = false;
                this.Refresh();
            }
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            if (txtPasswordWrong)
            {
                txtPassword.BorderStyle = BorderStyle.FixedSingle;
                Pen p = new Pen(Color.Red);
                txtPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
                Graphics g = e.Graphics;
                int variance = 1;
                txtPassword.SelectionStart = 0;
                g.DrawRectangle(p, new Rectangle(txtPassword.Location.X - variance, txtPassword.Location.Y - variance, txtPassword.Width + variance, txtPassword.Height + variance));
            }
            else
            {
                txtPassword.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (cmbUsername.SelectedIndex == i)
                {
                    btnLogin.Enabled = true;
                    txtPassword.Enabled = true;
                }
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password" || txtPassword.Text == "Invaild Password!")
            {
                txtPassword.Text = string.Empty;
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
                txtPasswordWrong = false;
                this.Refresh();
                txtPassword.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
                txtPasswordWrong = false;
                this.Refresh();
                txtPassword.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void cmbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbUsername_Click(object sender, EventArgs e)
        {
            cmbUsername.DroppedDown = true;
        }

        private void cmbUsername_Enter(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
