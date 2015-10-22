using System;
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
    public partial class frmProjects : Form
    {
        DatabaseHandler SQLHandler;
        frmAdd Add;
        frmEdit Edit;

        public frmProjects()
        {
            InitializeComponent();

            SQLHandler = new DatabaseHandler();
        }

        private void btnProjectAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAdd();
            Add.Show();
        }

        private void btnProjectEdit_Click(object sender, EventArgs e)
        {
            Edit = new frmEdit();
            Edit.Show();
        }

        private void frmProjects_Load(object sender, EventArgs e)
        {
           
        }

        private void btnProjectRemove_Click(object sender, EventArgs e)
        {
            SQLHandler.SQLCommand("DELETE * FROM tbl_projects WHERE CustomerID = '1';");
        }
    }
}
