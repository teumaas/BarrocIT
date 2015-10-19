﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIT
{
    public partial class frmMain : Form
    {
        DatabaseHandler SQLHandler;
        frmLogin Login;
        frmProjects AddProject;
        frmCalendar Calendar;
        frmAdd Add;
        frmEdit Edit;
        frmHelp Help;

        public frmMain()
        {
            InitializeComponent();
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calendar = new frmCalendar();
            Calendar.Show();
        }

        private void btnCustomersAdd_Click(object sender, EventArgs e)
        {
            AddEditForm(true);
        }

        private void btnInvoicesAdd_Click(object sender, EventArgs e)
        {
            AddEditForm(true);
        }

        private void btnProjectsView_Click(object sender, EventArgs e)
        {
            AddProject = new frmProjects();
            AddProject.Show();
        }

        private void btnCustomersEdit_Click(object sender, EventArgs e)
        {
            AddEditForm(false);
        }

        private void btnInvoicesEdit_Click(object sender, EventArgs e)
        {
            AddEditForm(false);
        }

        private void btnProjectsEdit_Click(object sender, EventArgs e)
        {
            AddEditForm(false);
        }

        private void itemSignout_Click(object sender, EventArgs e)
        {
            Login = new frmLogin();
            //SQLHandler.Close();
            this.Close();
            Application.Restart();
        }

        private void itemInfo_Click(object sender, EventArgs e)
        {
            Help = new frmHelp();
            Help.Show();
        }

        private void btnAppointmentsAdd_Click(object sender, EventArgs e)
        {
            AddEditForm(true);
        }

        private void btnAppointmentsEdit_Click(object sender, EventArgs e)
        {
            AddEditForm(false);
        }

        private bool AddEditForm(bool addedit)
        {
            if (addedit == true)
            {
                Add = new frmAdd();
                Add.Show();

            }
            else
            {
                Edit = new frmEdit();
                Edit.Show();
            }

            return addedit;
        }
    }
}
