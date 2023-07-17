using BankManagmentSystem_WinForms.Properties;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagmentSystem_WinForms.Forms
{
    public partial class frmAddUpdateAccount : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        clsAccount _Account;
        int _AccountID;


        private void _FillAccountTypes()
        {
            DataTable dataTable = clsAccountTypes.GetAccountTypes();

            foreach(DataRow row in dataTable.Rows)
            {
                cbAccountTypes.Items.Add(row["Account_Types_Description"]);
            }
        }

        private void _LoadData()
        {
            _FillAccountTypes();
            cbAccountTypes.SelectedIndex = 0;


            if (_Mode == enMode.AddNew)
            {
                pbAddUpdateIcon.Image = new Bitmap(Resources.add, new Size(25, 25));
                lblScreenName.Text = "Add New Account Screen";
                _Account = new clsAccount();
                return;
            }

            pbAddUpdateIcon.Image = new Bitmap(Resources.refresh, new Size(25, 25));
            lblScreenName.Text = $"Update Account with ID ({_AccountID})";
            _Account = clsAccount.FindAccountByID(_AccountID);

            if (_Account == null)
            {
                MessageBox.Show("This screen will be closed because No Contact with ID = " + _AccountID);
                this.Close();

                return;
            }
            lblAccountID.Text = _Account.AccountID.ToString();

            txtCustomerID.Enabled = false;
            txtCustomerID.Text = _Account.CustomerID.ToString();

            dtpDateOpened.Text = _Account.DateOpened.ToString();

            cbAccountTypes.SelectedIndex = cbAccountTypes.FindString(clsAccountTypes.Find(_Account.AccountType).Name);

            txtBalance.Text = _Account.Balance.ToString();
            txtPinCode.Text = _Account.PinCode.ToString();

        }


        public frmAddUpdateAccount(int AccountID)
        {
            InitializeComponent();
            _AccountID = AccountID;

            if (_AccountID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void frmAddUpdateAccount_Load(object sender, EventArgs e)
        {
            btnSave.Image = new Bitmap(Resources.save, new Size(25, 25));
            btnCancel.Image = new Bitmap(Resources.cancel, new Size(21, 21));

            _LoadData();    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you wnat to cancel this operation?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.AddNew)
            {
                int CustomerID = -1;
                if (int.TryParse(txtCustomerID.Text, out int parsedID))
                {
                    CustomerID = clsCustomer.FindCustomerByID(parsedID).CustomerID;
                    if (CustomerID == -1)
                    {
                        MessageBox.Show("The Customer dosen't exist,\nEnter a valid one.", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            
            int AccCode = clsAccountTypes.Find(cbAccountTypes.Text).Code;
            if (AccCode == -1)
            {
                MessageBox.Show("The Account Type dosen't exist,\nEnter a valid one.", "", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            _Account.DateOpened = dtpDateOpened.Value;

            _Account.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            txtCustomerID.Enabled = false;

            _Account.AccountType = cbAccountTypes.Text;

            if(string.IsNullOrEmpty(txtBalance.Text))
                _Account.Balance = 0;
            else
                _Account.Balance = Convert.ToInt32(txtBalance.Text);

            _Account.PinCode = txtPinCode.Text;

            if (_Account.Save())
            {
                MessageBox.Show("Account saved Successfully", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();

            }
            else
                MessageBox.Show("Save Failed, Try Again", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            _Mode = enMode.Update;

        }
    }
}
