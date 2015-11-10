// Made by Tom Smits..

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIT
{
    public partial class frmCalendar : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmMain Main;

        public frmCalendar(frmMain Main)
        {
            InitializeComponent();

            SQLCommand = new SqlCommand();

            this.Main = Main;
            SelectCalendar(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            SelectCalendar(e.Start.Year, e.Start.Month, e.Start.Day);
        }

        private void SelectCalendar(int Year, int Month, int Day)
        {
            SQLHandler = new DatabaseHandler();

            DataTable table;
            string query = " Select tbl_customers.CustomerName AS 'Name', tbl_appointments.AppointmentSubject AS 'Subject', tbl_appointments.AppointmentDate AS 'Date', tbl_appointments.AppointmentLocation AS 'Location', tbl_appointments.AppointmentAdress AS 'Adress' FROM tbl_appointments INNER JOIN tbl_customers ON tbl_appointments.CustomerID = tbl_customers.CustomerID where tbl_Appointments.AppointmentDate BETWEEN '";
            string date = Year + "-" + Month + "-" + Day;
            query += date + " 00:00:00' AND '" + date + " 23:59:59'";
            table = SQLHandler.SQLCommand(query);
            dataGridViewCalendar.DataSource = table;

            for (int i = 0; i <= 4; i++)
            {
                dataGridViewCalendar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main.Enabled = true;
            this.Close();
        }

        private void frmCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
