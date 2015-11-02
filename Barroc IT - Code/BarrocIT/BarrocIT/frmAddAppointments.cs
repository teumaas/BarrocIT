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

namespace BarrocIT
{
    public partial class frmAddAppointments : Form
    {
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        frmAppointments frmappointments;

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
            try
            {
                SQLCommand = new SqlCommand("INSERT INTO tbl_appointments (CustomerID, AppointmentSubject, AppointmentDate, AppointmentLocation, AppointmentAdress, AppointmentAdressZipcode, AppointmentTime) VALUES (@CustomerID, @AppointmentSubject, @AppointmentDate, @AppointmentLocation, @AppointmentAdress, @AppointmentAdressZipcode, @AppointmentTime)", SQLHandler.getConnection());

                AppointmentID = Convert.ToInt32(txtAppointmentID.Text);
                CustomerID = Convert.ToInt32(txtCustomerID.Text);
                AppointmentSubject = txtAppointmentSubject.Text;
                AppointmentDate = Convert.ToDateTime(dtpAppointmentDate.Text);
                AppointmentLocation = txtAppointmentLocation.Text;
                AppointmentAdress = txtAppointmentAdres.Text;
                AppointmentAdressZipcode = txtAppointmentAdressZipcode.Text;
                AppointmentTime = Convert.ToDateTime(dtpAppointmentTime.Text);

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
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please make sure everything is entered correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmappointments.Enabled = true;
            this.Close();
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
            frmappointments.Enabled = true;
        }
    }
}
