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
    public partial class frmEditAppointments : Form
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

        public frmEditAppointments(int AID, int CID, string AS, DateTime AD, string AL, string AA, string AAZ, DateTime AT, frmAppointments frmappointments)
        {
            InitializeComponent();
            this.frmappointments = frmappointments;

            Validator = new Regex(@"[(a-z)(A-Z)(0-9)\s]");

            AppointmentID = AID;
            CustomerID = CID;
            AppointmentSubject = AS;
            AppointmentDate = AD;
            AppointmentLocation = AL;
            AppointmentAdress = AA;
            AppointmentAdressZipcode = AAZ;
            AppointmentTime = AT;

            txtAppointmentID.Text = Convert.ToString(AppointmentID);
            txtCustomerID.Text = Convert.ToString(CustomerID);
            txtAppointmentSubject.Text = Convert.ToString(AppointmentSubject);
            dtpAppointmentDate.Text = Convert.ToString(AppointmentDate);
            txtAppointmentLocation.Text = Convert.ToString(AppointmentLocation);
            txtAppointmentAdress.Text = Convert.ToString(AppointmentAdress);
            txtAppointmentAdressZipcode.Text = Convert.ToString(AppointmentAdressZipcode);
            dtpAppointmentTime.Text = Convert.ToString(AppointmentTime);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validator.Match(txtAppointmentSubject.Text).Success)
            {
                txtAppointmentSubject.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtAppointmentLocation.Text).Success)
            {
                txtAppointmentLocation.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtAppointmentAdress.Text).Success)
            {
                txtAppointmentAdress.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtAppointmentAdressZipcode.Text).Success)
            {
                txtAppointmentAdressZipcode.BackColor = Color.IndianRed;
            }
            if (Validator.Match(txtAppointmentSubject.Text).Success && Validator.Match(txtAppointmentLocation.Text).Success && Validator.Match(txtAppointmentAdress.Text).Success && Validator.Match(txtAppointmentAdressZipcode.Text).Success)
            {
                SQLHandler = new DatabaseHandler();
                SQLCommand = new SqlCommand("UPDATE tbl_appointments SET AppointmentSubject = @AppointmentSubject, AppointmentDate = @AppointmentDate, AppointmentLocation = @AppointmentLocation, AppointmentAdress = @AppointmentAdress, AppointmentAdressZipcode = @AppointmentAdressZipcode, AppointmentTime = @AppointmentTime WHERE @AppointmentID = AppointmentID", SQLHandler.getConnection());

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

        private void frmEditAppointments_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtAppointmentLocation_KeyDown(object sender, KeyEventArgs e)
        {
            txtAppointmentLocation.BackColor = SystemColors.Window;
        }

        private void txtAppointmentAdress_KeyDown(object sender, KeyEventArgs e)
        {
            txtAppointmentAdress.BackColor = SystemColors.Window;
        }

        private void txtAppointmentAdressZipcode_KeyDown(object sender, KeyEventArgs e)
        {
            txtAppointmentAdressZipcode.BackColor = SystemColors.Window;
        }
    }
}
