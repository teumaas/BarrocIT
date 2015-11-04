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
    public partial class frmAppointments : Form
    {
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        frmAddAppointments Add;
        frmEditAppointments Edit;
        frmCalendar Calendar;
        frmMain Main;

        private int CustomerID;
        private int ProjectID;
        private string Username;

        public frmAppointments(string User, int CID, frmMain Main)
        {
            InitializeComponent();
            CustomerID = CID;
            Username = User;
            this.Main = Main;

            SQLHandler = new DatabaseHandler();

            refreshDataGridView();

            for (int i = 0; i <= 7; i++)
            {
                dataGridAddAppointment.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (Username == "Finance")
            {
                btnAppointmentsAdd.Enabled = false;
                btnAppointmentsEdit.Enabled = false;
                btnAppointmentsRemove.Enabled = false;
            }
            if (Username == "Development")
            {
                btnAppointmentsAdd.Enabled = false;
                btnAppointmentsEdit.Enabled = false;
                btnAppointmentsRemove.Enabled = false;
            }
        }
        private void frmAppointments_Validated(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
        public void refreshDataGridView()
        {
            dataGridAddAppointment.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_appointments WHERE CustomerID = '" + CustomerID + "';");
        }
        private void btnAppointmentsAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAddAppointments(CustomerID, this);
            this.Enabled = false;
            Add.Show();
        }

        private void btnAppointmentsRemove_Click(object sender, EventArgs e)
        {
            try
            {
                object AppointmentID = dataGridAddAppointment.CurrentRow.Cells[0].Value;

                SQLCommand = new SqlCommand("DELETE FROM tbl_appointments WHERE AppointmentID = @AppointmentID", SQLHandler.getConnection());
                
                SQLCommand.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                SQLCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

                SQLHandler.openConnection();
                SQLCommand.ExecuteNonQuery();
                SQLHandler.closeConnection();

                refreshDataGridView();
            }
            catch
            {
            }
        }

        private void btnAppointmentsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int AppointmentID = (int) dataGridAddAppointment.CurrentRow.Cells[0].Value;
                int CustomerID = (int) dataGridAddAppointment.CurrentRow.Cells[1].Value;
                string AppointmentSubject = (string) dataGridAddAppointment.CurrentRow.Cells[2].Value;
                DateTime AppointmentDate = (DateTime) dataGridAddAppointment.CurrentRow.Cells[3].Value;
                string AppointmentLocation = (string) dataGridAddAppointment.CurrentRow.Cells[4].Value;
                string AppointmentAdress = (string) dataGridAddAppointment.CurrentRow.Cells[5].Value;
                string AppointmentAdressZipcode = (string) dataGridAddAppointment.CurrentRow.Cells[6].Value;
                DateTime AppointmentTime = (DateTime) dataGridAddAppointment.CurrentRow.Cells[7].Value;

                Edit = new frmEditAppointments(AppointmentID, CustomerID, AppointmentSubject, AppointmentDate, AppointmentLocation, AppointmentAdress, AppointmentAdressZipcode, AppointmentTime, this);
                this.Enabled = false;
                Edit.Show();
            }
            catch
            {
            }

        }

        private void btnAppointmentsCalendar_Click(object sender, EventArgs e)
        {
            Calendar = new frmCalendar(this);
            this.Enabled = false;
            Calendar.Show();
        }

        private void frmAppointments_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
