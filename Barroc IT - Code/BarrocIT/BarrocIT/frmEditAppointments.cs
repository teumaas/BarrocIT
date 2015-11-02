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
    public partial class frmEditAppointments : Form
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

        public frmEditAppointments(int AID, int CID, string AS, DateTime AD, string AL, string AA, string AAZ, DateTime AT, frmAppointments frmappointments)
        {
            InitializeComponent();
            this.frmappointments = frmappointments;

            AppointmentID = AID;
            CustomerID = CID;
            AppointmentSubject = AS;
            AppointmentDate = AD;
            AppointmentLocation = AL;
            AppointmentAdress = AA;
            AppointmentAdressZipcode = AAZ;
            AppointmentTime = AT;

            try
            {
                txtAppointmentID.Text = Convert.ToString(AppointmentID);
                txtCustomerID.Text = Convert.ToString(CustomerID);
                txtAppointmentSubject.Text = Convert.ToString(AppointmentSubject);
                dtpAppointmentDate.Text = Convert.ToString(AppointmentDate);
                txtAppointmentLocation.Text = Convert.ToString(AppointmentLocation);
                txtAppointmentAdres.Text = Convert.ToString(AppointmentAdress);
                txtAppointmentAdressZipcode.Text = Convert.ToString(AppointmentAdressZipcode);
                dtpAppointmentTime.Text = Convert.ToString(AppointmentTime);
            }
            catch {}  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLHandler = new DatabaseHandler();
                SQLCommand = new SqlCommand("UPDATE tbl_appointments SET AppointmentSubject = @AppointmentSubject, AppointmentDate = @AppointmentDate, AppointmentLocation = @AppointmentLocation, AppointmentAdress = @AppointmentAdress, AppointmentAdressZipcode = @AppointmentAdressZipcode, AppointmentTime = @AppointmentTime WHERE @AppointmentID = AppointmentID", SQLHandler.getConnection());

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

        private void frmEditAppointments_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmappointments.Enabled = true;
        }
    }
}
