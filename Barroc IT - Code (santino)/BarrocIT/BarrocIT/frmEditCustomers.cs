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
    public partial class frmEditCustomers : Form
    {
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        frmMain frmmain;

        private int CustomerID;
        private string CustomerName;
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

        public frmEditCustomers(int CID, string CN, string CA1, string CA2, string CC1, string CC2, string CPN1, string CPN2, string CZC1, string CZC2, string CFXN, string CCP, string CE, string CBN, bool CCW, bool BRK, bool CP, frmMain frmmain)
        {
            InitializeComponent();
            this.frmmain = frmmain;

            CustomerID = CID;
            CustomerName = CN;
            CustomerAdress1 = CA1;
            CustomerAdress2 = CA2;
            CustomerCity1 = CC1;
            CustomerCity2 = CC2;
            CustomerPhoneNumber1 = CPN1;
            CustomerPhoneNumber2 = CPN2;
            CustomerZipCode1 = CZC1;
            CustomerZipCode2 = CZC2;
            CustomerFaxNumber = CFXN;
            CustomerContactPerson = CCP;
            CustomerEmail = CE;
            CustomerBankNumber = CBN;
            CustomerCreditWorthy = CCW;
            CustomerBKRCheck = BRK;
            CustomerPotential = CP;

            try
            {
                txtCustomerID.Text = Convert.ToString(CustomerID);
                txtCustomerName.Text = CustomerName;
                txtCustomerAdress1.Text = CustomerAdress1;
                txtCustomerAdress2.Text = CustomerAdress2;
                txtCustomerCity1.Text = CustomerCity1;
                txtCustomerCity2.Text = CustomerCity2;
                txtCustomerPhoneNumber1.Text = CustomerPhoneNumber1;
                txtCustomerPhoneNumber2.Text = CustomerPhoneNumber2;
                txtCustomerZipCode1.Text = CustomerZipCode1;
                txtCustomerZipCode2.Text = CustomerZipCode2;
                txtCustomerFaxNumber.Text = CustomerFaxNumber;
                txtCustomerContactPerson.Text = CustomerContactPerson;
                txtCustomerEmail.Text = CustomerEmail;
                txtCustomerBankNumber.Text = CustomerBankNumber;
                cmbCustomerCreditWorthy.SelectedIndex = int.Parse(Convert.ToString(CustomerCreditWorthy).Replace("False", "0").Replace("True", "1"));
                cmbCustomerBKRCheck.SelectedIndex = int.Parse(Convert.ToString(CustomerBKRCheck).Replace("False", "0").Replace("True", "1"));
                cmbCustomerPotential.SelectedIndex = int.Parse(Convert.ToString(CustomerPotential).Replace("False", "0").Replace("True", "1"));
            }
            catch {}       
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLHandler = new DatabaseHandler();
                SQLCommand = new SqlCommand("UPDATE tbl_customers SET CustomerID = @CustomerID, CustomerName = @CustomerName, Adress1 = @Adress1, Adress2 = @Adress2, City1 = @City1, City2 = @City2, PhoneNum1 = @PhoneNum1, PhoneNum2 = @PhoneNum2, ZipCode1 = @ZipCode1, ZipCode2 = @ZipCode2, FaxNum = @FaxNum, ContactPerson = @ContactPerson, Email = @Email, BankNum = @BankNum, CreditWorthy = @CreditWorthy, BKRCheck = @BKRCheck, PotentialCustomer = @PotentialCustomer WHERE @CustomerID = CustomerID", SQLHandler.getConnection());

                CustomerID = Convert.ToInt32(txtCustomerID.Text);
                CustomerName = Convert.ToString(txtCustomerName.Text);
                CustomerAdress1 = Convert.ToString(txtCustomerAdress1.Text);
                CustomerAdress2 = Convert.ToString(txtCustomerAdress2.Text);
                CustomerCity1 = Convert.ToString(txtCustomerCity1.Text);
                CustomerCity2 = Convert.ToString(txtCustomerCity2.Text);
                CustomerPhoneNumber1 = Convert.ToString(txtCustomerPhoneNumber1.Text);
                CustomerPhoneNumber2 = Convert.ToString(txtCustomerPhoneNumber2.Text);
                CustomerZipCode1 = Convert.ToString(txtCustomerZipCode1.Text);
                CustomerZipCode2 = Convert.ToString(txtCustomerZipCode2.Text);
                CustomerFaxNumber = Convert.ToString(txtCustomerFaxNumber.Text);
                CustomerContactPerson = Convert.ToString(txtCustomerContactPerson.Text);
                CustomerEmail = Convert.ToString(txtCustomerEmail.Text);
                CustomerBankNumber = Convert.ToString(txtCustomerBankNumber.Text);
                CustomerCreditWorthy = Convert.ToBoolean(cmbCustomerCreditWorthy.SelectedIndex);
                CustomerBKRCheck = Convert.ToBoolean(cmbCustomerBKRCheck.SelectedIndex);
                CustomerPotential = Convert.ToBoolean(cmbCustomerPotential.SelectedIndex);

                SQLCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                SQLCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
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

                frmmain.FillDataGrids();
                frmmain.Enabled = true;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please make sure everything is entered correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmain.Enabled = true;
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

        private void frmEditCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmain.Enabled = true;
        }
    }
}
