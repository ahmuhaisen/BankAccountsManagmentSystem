using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagmentSystem_WinForms.Forms
{
    public partial class frmTransfer : Form
    {
        clsAccount senderAcc;
        clsAccount reciverAcc;
       // clsTransaction tranferTransaction;



        public frmTransfer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel this operation", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnFindSender_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSenderAccountID.Text.ToString());

            senderAcc = new clsAccount();
            senderAcc = clsAccount.FindAccountByID(id);

            if(sender == null)
            {
                //pEnterSenderAccountNumber.Enabled = true;
                txtSenderAccountID.Text = string.Empty;
                lblSenderFindStatus.Visible = true;
            }
            else
            {
                lblSenderFindStatus.Visible = false;
                pictureBox1.Visible= true;
                //pEnterSenderAccountNumber.Enabled = false;
                pEnterReciverAccountNumber.Visible = true;
            }

        }

        private void btnFindReciver_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtReciverAccountID.Text.ToString());

            reciverAcc = new clsAccount();
            reciverAcc = clsAccount.FindAccountByID(id);

            if (reciverAcc == null)
            {
                txtReciverAccountID.Text = string.Empty;
                lblReciverFindStatus.Visible = true;
            }
            else
            {
                lblReciverFindStatus.Visible = false;
                pTransferAmount.Visible = true;
                pSenderBalance.Visible = true;  
                lblSenderAvailablebalance.Text = senderAcc.Balance.ToString() + "$";
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtTransferAmount.Text.ToString());

            if(amount > 0 && (amount % 5 == 0))
            {
                lblAmountStatus.Visible = false;
                if (amount <= senderAcc.Balance)
                {
                    senderAcc.Balance -= amount;
                    reciverAcc.Balance += amount;

                    clsTransaction tranferTransaction = new clsTransaction();
                    tranferTransaction.AccountID = senderAcc.AccountID;
                    tranferTransaction.AmountOfTransaaction = amount;
                    tranferTransaction.DatePerformed = DateTime.Now;
                    tranferTransaction.TransactionTypeCode = 5;

                    if(senderAcc.Save() && reciverAcc.Save() && tranferTransaction.Save())
                        MessageBox.Show($"Transaction performed successfully, \nSender New Balance: {senderAcc.Balance}, \nReciver New Balance: {reciverAcc.Balance}", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Transfer failed!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cannot perform this operation, Insuffecient balance!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransferAmount.Text = string.Empty;
                }

            }
            else
            {
                lblAmountStatus.Visible = true;
            }

        }
    }
}
