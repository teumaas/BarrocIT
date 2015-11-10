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
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmAddAppointments Add;
        private frmEditAppointments Edit;
        private frmMain Main;

        private int CustomerID;
        private string Username;

        public frmAppointments(string User, int CID, frmMain Main)
        {
            InitializeComponent();
            CustomerID = CID;
            Username = User;
            this.Main = Main;

            SQLCommand = new SqlCommand();
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

        private void btnAppointmentsAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAddAppointments(CustomerID, this);
            this.Enabled = false;
            Add.Show();
        }

        private void btnAppointmentsRemove_Click(object sender, EventArgs e)
        {
            DialogResult remove = MessageBox.Show("Do you really wish to remove this appointment?", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (remove == DialogResult.Cancel)
            {
            }
            else if (remove == DialogResult.OK)
            {
                object AppointmentID = dataGridAddAppointment.CurrentRow.Cells[0].Value;

                SQLHandler.deleteFROMbyObject(AppointmentID, "AppointmentID", "tbl_appointments");
                refreshDataGridView();
            }
        }

        private void btnAppointmentsEdit_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dataGridAddAppointment.CurrentRow.Cells[0].Value;
            int CustomerID = (int)dataGridAddAppointment.CurrentRow.Cells[1].Value;
            string AppointmentSubject = (string)dataGridAddAppointment.CurrentRow.Cells[2].Value;
            DateTime AppointmentDate = (DateTime)dataGridAddAppointment.CurrentRow.Cells[3].Value;
            string AppointmentLocation = (string)dataGridAddAppointment.CurrentRow.Cells[4].Value;
            string AppointmentAdress = (string)dataGridAddAppointment.CurrentRow.Cells[5].Value;
            string AppointmentAdressZipcode = (string)dataGridAddAppointment.CurrentRow.Cells[6].Value;
            DateTime AppointmentTime = (DateTime)dataGridAddAppointment.CurrentRow.Cells[7].Value;

            Edit = new frmEditAppointments(AppointmentID, CustomerID, AppointmentSubject, AppointmentDate, AppointmentLocation, AppointmentAdress, AppointmentAdressZipcode, AppointmentTime, this);
            this.Enabled = false;
            Edit.Show();
        }

        public void refreshDataGridView()
        {
            dataGridAddAppointment.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_appointments WHERE CustomerID = '" + CustomerID + "';");
            checkifDataGridisEmpty();
        }

        public void checkifDataGridisEmpty()
        {
            if (dataGridAddAppointment.Rows.Count == 0)
            {
                btnAppointmentsEdit.Enabled = false;
                btnAppointmentsRemove.Enabled = false;
            }
            else
            {
                btnAppointmentsEdit.Enabled = true;
                btnAppointmentsRemove.Enabled = true;
            }
        }

        private void frmAppointments_Validated(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void frmAppointments_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
