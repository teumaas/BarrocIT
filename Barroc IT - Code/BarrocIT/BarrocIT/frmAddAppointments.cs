// Made by Tom Smits..

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BarrocIT
{
    public partial class frmAddAppointments : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmAppointments frmappointments;
        private Regex Validator;

        private int AppointmentID;
        private int CustomerID;
        private string AppointmentSubject;
        private DateTime AppointmentDate;
        private string AppointmentLocation;
        private string AppointmentAdress;
        private string AppointmentAdressZipcode;
        private DateTime AppointmentTime;

        public frmAddAppointments(int CID, frmAppointments frmappointments)
        {
            InitializeComponent();
            this.frmappointments = frmappointments;
            AppointmentID = 0;
            CustomerID = CID;
            AppointmentDate = DateTime.Today;
            AppointmentTime = DateTime.Today;

            SQLHandler = new DatabaseHandler();
            SQLCommand = new SqlCommand("SELECT MAX(AppointmentID) FROM tbl_appointments", SQLHandler.getConnection());
            Validator = new Regex(@"[(a-z)(A-Z)(0-9)\s]");

            int AID;
            int.TryParse(SQLHandler.GetFirstValue("SELECT MAX(AppointmentID) FROM tbl_appointments").ToString(), out AID);
            AID++;

            txtAppointmentID.Text = AID.ToString();
            txtCustomerID.Text = Convert.ToString(CustomerID);
            dtpAppointmentDate.Text = Convert.ToString(AppointmentDate);
            dtpAppointmentTime.Text = Convert.ToString(AppointmentTime);

            SQLHandler.closeConnection();          
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!Validator.Match(txtAppointmentSubject.Text).Success)
            {
                txtAppointmentSubject.BackColor = Color.IndianRed;
            }
            if(!Validator.Match(txtAppointmentLocation.Text).Success)
            {
                txtAppointmentLocation.BackColor = Color.IndianRed;
            }
            if(!Validator.Match(txtAppointmentAdress.Text).Success)
            {
                txtAppointmentAdress.BackColor = Color.IndianRed;
            }
            if(!Validator.Match(txtAppointmentAdressZipcode.Text).Success)
            {
                txtAppointmentAdressZipcode.BackColor = Color.IndianRed;
            }
            if (Validator.Match(txtAppointmentSubject.Text).Success && Validator.Match(txtAppointmentLocation.Text).Success && Validator.Match(txtAppointmentAdress.Text).Success && Validator.Match(txtAppointmentAdressZipcode.Text).Success)
            {
                SQLHandler = new DatabaseHandler();
                SQLCommand = new SqlCommand("INSERT INTO tbl_appointments (CustomerID, AppointmentSubject, AppointmentDate, AppointmentLocation, AppointmentAdress, AppointmentAdressZipcode, AppointmentTime) VALUES (@CustomerID, @AppointmentSubject, @AppointmentDate, @AppointmentLocation, @AppointmentAdress, @AppointmentAdressZipcode, @AppointmentTime)", SQLHandler.getConnection());

                AppointmentID = Convert.ToInt32(txtAppointmentID.Text);
                CustomerID = Convert.ToInt32(txtCustomerID.Text);
                AppointmentSubject = Convert.ToString(txtAppointmentSubject.Text);
                AppointmentLocation = Convert.ToString(txtAppointmentLocation.Text);
                AppointmentAdress = Convert.ToString(txtAppointmentAdress.Text);
                AppointmentAdressZipcode = Convert.ToString(txtAppointmentAdressZipcode.Text);
                AppointmentTime = Convert.ToDateTime(dtpAppointmentTime.Text);
                AppointmentDate = Convert.ToDateTime(dtpAppointmentDate.Text);

                SQLCommand.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                SQLCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                SQLCommand.Parameters.AddWithValue("@AppointmentSubject", AppointmentSubject);
                SQLCommand.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                SQLCommand.Parameters.AddWithValue("@AppointmentLocation", AppointmentLocation);
                SQLCommand.Parameters.AddWithValue("@AppointmentAdress", AppointmentAdress);
                SQLCommand.Parameters.AddWithValue("@AppointmentAdressZipcode", AppointmentAdressZipcode);
                SQLCommand.Parameters.AddWithValue("@AppointmentTime", AppointmentTime);

                SQLHandler.openConnection();
                SQLCommand.ExecuteNonQuery();
                SQLHandler.closeConnection();

                frmappointments.refreshDataGridView();
                frmappointments.Enabled = true;
                Dispose();
                frmappointments.Activate();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really wish to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                frmappointments.Enabled = true;
                Dispose();
                frmappointments.Activate();
            }
        }

        private void cmbAppointmentHours_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbAppointmentMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void frmAddAppointments_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really wish to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (exit == DialogResult.OK)
            {
                e.Cancel = false;
                frmappointments.Enabled = true;
            }
        }

        private void txtAppointmentSubject_KeyDown(object sender, KeyEventArgs e)
        {
                txtAppointmentSubject.BackColor = SystemColors.Window;
        }

        private void txtAppointmentLocation_TextChanged(object sender, EventArgs e)
        {
                txtAppointmentLocation.BackColor = SystemColors.Window;
        }

        private void txtAppointmentAdress_KeyDown(object sender, KeyEventArgs e)
        {
                txtAppointmentAdress.BackColor = SystemColors.Window;
        }

        private void txtAppointmentAdressZipcode_TextChanged(object sender, EventArgs e)
        {
                txtAppointmentAdressZipcode.BackColor = SystemColors.Window;
        }
    }
}
