using BankManagmentSystem_WinForms.Properties;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagmentSystem_WinForms.Forms
{
    public partial class frmDepositWithdraw : Form
    {
        enum enOperationType
        {
            eWithdraw = 1 , eDeposit = 2
        }
        enOperationType TransactionType;

        clsAccount acc;
        clsTransaction transaction;

        private void _ShowScreenDetailes()
        {
            if(TransactionType == enOperationType.eWithdraw)
            {
                pTitle.BackColor = Color.OrangeRed;
                lblScreenName.Text = "Withdraw Screen";
                pbScreenIcon.Image = new Bitmap(Resources.withdrawal);
            }
            else
            {
                pTitle.BackColor = Color.GreenYellow;
                lblScreenName.Text = "Deposit Screen";
                pbScreenIcon.Image = new Bitmap(Resources.deposit);
            }

            btnCancel.Image = new Bitmap(Resources.cancel, new Size(20,20));
        }

        private void _FillAccountInfo()
        {
            lblAccountID.Text = acc.AccountID.ToString();
            lblAccountOwner.Text = acc.CustomerID.ToString();
            lblAccountType.Text = acc.AccountType.ToString();
            lblAccountBalance.Text = acc.Balance.ToString() + "$";
        }

        private void _PerformWithdrawOperation(int amount)
        {
            if (amount > acc.Balance)
            {
                MessageBox.Show("Cannot perform this operation, Insuffecient balance!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Text = string.Empty;
            }
            else
            {
                if (MessageBox.Show("Do you want to perform this operation?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    transaction = new clsTransaction();
                    transaction.AmountOfTransaaction = amount;
                    transaction.AccountID = acc.AccountID;
                    transaction.DatePerformed = DateTime.Now;
                    transaction.TransactionTypeCode = 2;
                    acc.Balance -= amount;

                    if (transaction.Save() && acc.Save())
                    {
                        MessageBox.Show($"Transaction performed successfully, \nNew Balance: {acc.Balance}", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblAccountBalance.ForeColor = Color.Red;
                        lblAccountBalance.Text = acc.Balance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Transaction failed!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void _PerformDipositeOperation(int amount)
        {
            if (MessageBox.Show("Do you want to perform this operation?", "",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                transaction = new clsTransaction();
                transaction.AmountOfTransaaction = amount;
                transaction.AccountID = acc.AccountID;
                transaction.DatePerformed = DateTime.Now;
                transaction.TransactionTypeCode = 1;
                acc.Balance += amount;

                if (transaction.Save() && acc.Save())
                {
                    MessageBox.Show($"Transaction performed successfully, \nNew Balance: {acc.Balance}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAccountBalance.ForeColor = Color.Red;
                    lblAccountBalance.Text = acc.Balance.ToString();
                }
                else
                {
                    MessageBox.Show("Transaction failed!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        public frmDepositWithdraw(bool isWithdraw = true)
        {
            InitializeComponent();

            if (isWithdraw)
                TransactionType = enOperationType.eWithdraw;
            else
                TransactionType = enOperationType.eDeposit;
            
            _ShowScreenDetailes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAccountID.Text.ToString(), out int id))
            {
                acc = clsAccount.FindAccountByID(id);
                if (acc == null)
                {
                    pCurrentAccountInfo.Visible = false;
                    lblFindStatus.Visible = true;
                    pAmount.Visible = false;
                }
                else
                {
                    _FillAccountInfo();
                    pCurrentAccountInfo.Visible = true;
                    pAmount.Visible = true;
                    lblFindStatus.Visible = false;
                    txtAmount.Text = string.Empty;

                    if (TransactionType == enOperationType.eDeposit)
                    {
                        label7.Text = "Enter Deposit Amount...";

                    }
                    else
                    {
                        label7.Text = "Enter Withdraw Amount...";

                    }
                }
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);
            
            if(TransactionType == enOperationType.eWithdraw)
                _PerformWithdrawOperation(amount);

            else if (TransactionType == enOperationType.eDeposit)
                _PerformDipositeOperation(amount);

        }
    }
}
