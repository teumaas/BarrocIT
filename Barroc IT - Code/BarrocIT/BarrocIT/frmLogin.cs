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

namespace BarrocIT
{
    public partial class frmLogin : Form
    {
        // Create Object here.
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        SqlDataReader SQLReader;
        frmMain main;

        private string Username, Password;

        public frmLogin()
        {
            InitializeComponent();

            //txtInfo - Color
            var pos = this.PointToScreen(lblInfo.Location);
            pos = picLogo.PointToClient(pos);
            lblInfo.Parent = picLogo;
            lblInfo.Location = pos;
            lblInfo.BackColor = Color.Transparent;

            string[] departments = new string[4] { "Sales", "Finance", "Development", "Administration" };

            //Textboxes Properties
            
            cmbUsername.Text = "Select department...";

            for (int i = 0; i < 4; i++)
            {
                cmbUsername.Items.Add(departments[i]);
            }
            
            txtPassword.Text = "Password";

            txtAssembly.ForeColor = SystemColors.ControlDarkDark;
            txtAssembly.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password" || txtPassword.Text == "Password invaild!")
            {
                txtPassword.Text = string.Empty;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(cmbUsername.Text, txtPassword.Text);
        }

        private void cmbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbUsername_Enter(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void Login(string UN, string PW)
        {
            try
            {
                UN = cmbUsername.Text;
                PW = txtPassword.Text;

                SQLHandler = new DatabaseHandler();
                SQLCommand = new SqlCommand("SELECT * FROM tbl_users WHERE Username = @Username AND Password = @Password",
                SQLHandler.getConnection());
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
                    txtPassword.Text = "Password invaild!";
                }
            }
            catch
            {
                
            }
        }
    }
}
