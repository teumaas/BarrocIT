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
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace BarrocIT
{
    public partial class frmAddCustomers : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmMain frmmain;
        private Regex Validator;

        private int CustomerID;
        private string CustomerName;
        private string CustomerCompany;
        private string CustomerAdress1;
        private string CustomerAdress2;
        private string CustomerCity1;
        private string CustomerCity2;
        private string CustomerPhoneNumber1;
        private string CustomerPhoneNumber2;
        private string CustomerZipCode1;
        private string CustomerZipCode2;
        private string CustomerFaxNumber;
        private string CustomerContactPerson;
        private string CustomerEmail;
        private string CustomerBankNumber;
        private bool CustomerCreditWorthy;
        private bool CustomerBKRCheck;
        private bool CustomerPotential;

        public frmAddCustomers(frmMain frmmain)
        {
            InitializeComponent();
            this.frmmain = frmmain;
            CustomerID = 0;

            SQLHandler = new DatabaseHandler();
            Validator = new Regex(@"[(a-z)(A-Z)(0-9)\s]");

            int CID;
            int.TryParse(SQLHandler.GetFirstValue("SELECT MAX(CustomerID) FROM tbl_customers").ToString(), out CID);
            CID++;

            txtCustomerID.Text = CID.ToString();

            SQLHandler.closeConnection();          
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!Validator.Match(txtCustomerName.Text).Success)
            {
                txtCustomerName.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtCustomerAdress1.Text).Success)
            {
                txtCustomerAdress1.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtCustomerCity1.Text).Success)
            {
                txtCustomerCity1.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtCustomerPhoneNumber1.Text).Success)
            {
                txtCustomerPhoneNumber1.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtCustomerZipCode1.Text).Success)
            {
                txtCustomerZipCode1.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtCustomerContactPerson.Text).Success)
            {
                txtCustomerContactPerson.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtCustomerEmail.Text).Success)
            {
                txtCustomerEmail.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtCustomerBankNumber.Text).Success)
            {
                txtCustomerBankNumber.BackColor = Color.IndianRed;
            }
            if (Validator.Match(txtCustomerName.Text).Success && Validator.Match(txtCustomerAdress1.Text).Success && Validator.Match(txtCustomerCity1.Text).Success && Validator.Match(txtCustomerPhoneNumber1.Text).Success && Validator.Match(txtCustomerZipCode1.Text).Success && Validator.Match(txtCustomerContactPerson.Text).Success && Validator.Match(txtCustomerEmail.Text).Success && Validator.Match(txtCustomerBankNumber.Text).Success)
            {
                SQLCommand = new SqlCommand("INSERT INTO tbl_customers (CustomerID, CustomerName, Company, Adress1, Adress2, City1, City2, PhoneNum1, PhoneNum2, ZipCode1, ZipCode2, FaxNum, ContactPerson, Email, BankNum, CreditWorthy, BKRCheck, PotentialCustomer) VALUES (@CustomerID, @CustomerName, @Company, @Adress1, @Adress2, @City1, @City2, @PhoneNum1, @PhoneNum2, @ZipCode1, @ZipCode2, @FaxNum, @ContactPerson, @Email, @BankNum, @CreditWorthy, @BKRCheck, @PotentialCustomer)", SQLHandler.getConnection());

                CustomerID = Convert.ToInt32(txtCustomerID.Text);
                CustomerName = txtCustomerName.Text;
                CustomerCompany = txtComany.Text;
                CustomerAdress1 = txtCustomerAdress1.Text;
                if (txtCustomerAdress2.Text == "")
                {
                    CustomerAdress2 = string.Empty;
                }
                else
                {
                    CustomerAdress2 = txtCustomerAdress2.Text;
                }
                CustomerCity1 = txtCustomerCity1.Text;
                if (txtCustomerCity2.Text == "")
                {
                    CustomerCity2 = string.Empty;
                }
                else
                {
                    CustomerCity2 = txtCustomerCity2.Text;
                }
                CustomerPhoneNumber1 = txtCustomerPhoneNumber1.Text;
                if (txtCustomerPhoneNumber2.Text == "")
                {
                    CustomerPhoneNumber2 = string.Empty;
                }
                else
                {
                    CustomerPhoneNumber2 = txtCustomerPhoneNumber2.Text;
                }
                CustomerZipCode1 = txtCustomerZipCode1.Text;
                if (txtCustomerZipCode2.Text == "")
                {
                    CustomerZipCode2 = string.Empty;
                }
                else
                {
                    CustomerZipCode2 = txtCustomerZipCode2.Text;
                }
                if (txtCustomerFaxNumber.Text == "")
                {
                    CustomerFaxNumber = string.Empty;
                }
                else
                {
                    CustomerFaxNumber = txtCustomerFaxNumber.Text;
                }
                CustomerContactPerson = txtCustomerContactPerson.Text;
                CustomerEmail = txtCustomerEmail.Text;
                CustomerBankNumber = txtCustomerBankNumber.Text;
                CustomerCreditWorthy = Convert.ToBoolean(cmbCustomerCreditWorthy.SelectedIndex);
                CustomerBKRCheck = Convert.ToBoolean(cmbCustomerBKRCheck.SelectedIndex);
                CustomerPotential = Convert.ToBoolean(cmbCustomerPotential.SelectedIndex);

                SQLCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                SQLCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
                SQLCommand.Parameters.AddWithValue("@Company", CustomerCompany);
                SQLCommand.Parameters.AddWithValue("@Adress1", CustomerAdress1);
                SQLCommand.Parameters.AddWithValue("@Adress2", CustomerAdress2);
                SQLCommand.Parameters.AddWithValue("@City1", CustomerCity1);
                SQLCommand.Parameters.AddWithValue("@City2", CustomerCity2);
                SQLCommand.Parameters.AddWithValue("@PhoneNum1", CustomerPhoneNumber1);
                SQLCommand.Parameters.AddWithValue("@PhoneNum2", CustomerPhoneNumber2);
                SQLCommand.Parameters.AddWithValue("@ZipCode1", CustomerZipCode1);
                SQLCommand.Parameters.AddWithValue("@ZipCode2", CustomerZipCode2);
                SQLCommand.Parameters.AddWithValue("@FaxNum", CustomerFaxNumber);
                SQLCommand.Parameters.AddWithValue("@ContactPerson", CustomerContactPerson);
                SQLCommand.Parameters.AddWithValue("@Email", CustomerEmail);
                SQLCommand.Parameters.AddWithValue("@BankNum", CustomerBankNumber);
                SQLCommand.Parameters.AddWithValue("@CreditWorthy", CustomerCreditWorthy);
                SQLCommand.Parameters.AddWithValue("@BKRCheck", CustomerBKRCheck);
                SQLCommand.Parameters.AddWithValue("@PotentialCustomer", CustomerPotential);

                SQLHandler.openConnection();
                SQLCommand.ExecuteNonQuery();
                SQLHandler.closeConnection();

                frmmain.FillDataGrids("*", "tbl_customers");
                frmmain.Enabled = true;
                Dispose();
                frmmain.Activate();
                frmmain.checkifDataGridisEmpty();
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really wish to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                frmmain.Enabled = true;
                Dispose();
                frmmain.Activate();
            }
        }

        private void frmAddCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really wish to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.Cancel)
            {
                e.Cancel = true; 
            }
            else if (exit == DialogResult.OK)
            {
                e.Cancel = false;
                frmmain.Enabled = true;
            }
        }

        private void cmbCustomerCreditWorthy_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbCustomerBKRCheck_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbCustomerPotential_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbCustomerCreditWorthy_Click(object sender, EventArgs e)
        {
            cmbCustomerCreditWorthy.DroppedDown = true;
        }
        private void cmbCustomerBKRCheck_Click(object sender, EventArgs e)
        {
            cmbCustomerBKRCheck.DroppedDown = true;
        }

        private void cmbCustomerPotential_Click(object sender, EventArgs e)
        {
            cmbCustomerPotential.DroppedDown = true;
        }
        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }

        private void txtCustomerAdress1_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerAdress1.BackColor = SystemColors.Window;
        }

        private void txtCustomerCity1_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerCity1.BackColor = SystemColors.Window;
        }

        private void txtCustomerPhoneNumber1_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerPhoneNumber1.BackColor = SystemColors.Window;
        }

        private void txtCustomerZipCode1_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerZipCode1.BackColor = SystemColors.Window;
        }

        private void txtCustomerContactPerson_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerContactPerson.BackColor = SystemColors.Window;
        }

        private void txtCustomerEmail_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerEmail.BackColor = SystemColors.Window;
        }

        private void txtCustomerBankNumber_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerBankNumber.BackColor = SystemColors.Window;
        }

        private void frmAddCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
