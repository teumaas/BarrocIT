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
        frmAdd Add;
        frmEdit Edit;

        public frmProjects()
        {
            InitializeComponent();
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
    }
}
