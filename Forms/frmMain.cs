using BankManagmentSystem_WinForms.Properties;
using System;
using LogicLayer;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BankManagmentSystem_WinForms.Forms;

namespace BankManagmentSystem_WinForms
{
    public partial class frmMain : Form
    {
        public enum enScreens
        {
            //Main Screens
            eDashboard = 0, eAccounts = 1, eTransactions = 2, eManageUsers = 3,
            eLoginRegister = 4, eCurrencyExchange = 5,

            //Sub-Screens / Accounts Screen
            eCustomersList = 6, eAccountsList = 7, eSearchAccount = 8,

            //Sub-Screens / Accounts Screen
            eWithdraw = 7, eDeposit = 8, eTransfer = 9, eTransactionsHistory = 10, eTotalBalances = 11, eCheckBalance = 12
        }


        public enScreens CurrentScreen = enScreens.eDashboard;


        clsUser user;

        //Dashboard Screen Functions/Procedures:
        private void _HideTabheader()
        {
            tbcScreens.Appearance = TabAppearance.FlatButtons;
            tbcScreens.ItemSize = new Size(0, 1);
            tbcScreens.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in tbcScreens.TabPages)
            {
                tab.Text = "";
            }
        }
        private void _SetDashboardInfo()
        {
            int TotalCapital = clsAccount.GetTotalBankCapital();
            int ActiveAccounts = clsAccount.GetNoOfActiveAccounts();
            int TodaysTransactions = clsTransaction.GetNumberOfTodaysTransactions();

            if (TotalCapital != -1)
                lblBankCapital.Text = TotalCapital.ToString() + "$";
            else
                lblBankCapital.Text = "Undefined";

            if (ActiveAccounts != -1)
                lblNoAccounts.Text = ActiveAccounts.ToString();
            else
                lblNoAccounts.Text = "Undefined";

            if (TodaysTransactions != -1)
                lblNoTransactions.Text = TodaysTransactions.ToString();
            else
                lblNoTransactions.Text = "Undefined";

            lblJODValue.Text = "1.41$";


            lblUsername.Text = user.username.ToString();
        }
        private void _ShowDasboardScreen()
        {
            CurrentScreen = enScreens.eDashboard;

            this.pbScreenImage.Image = new Bitmap(Resources.dashboard);
            lblScreenName.Text = "Dashboard Screen";
            lblDate.Text = DateTime.Today.ToLongDateString();

            //put the time code here...
            

            timer1.Enabled = true;
            timer1.Interval = 1000;




            tbcScreens.SelectedTab = tbcScreens.TabPages["tbDashboardScreen"];
            _SetDashboardInfo();
        }


        //Accounts Screen Functions/Procedures:
        private void _ShowAccountsScreen()
        {
            CurrentScreen = enScreens.eAccounts;

            this.pbScreenImage.Image = new Bitmap(Resources.multiple_users_silhouette);
            lblScreenName.Text = "Accounts Screen";
            
            btnCustomerListS.Image = new Bitmap(Resources.list, new Size(50,50));
            btnAccountListS.Image = new Bitmap(Resources.list, new Size(50, 50));
            btnSearchAccountS.Image = new Bitmap(Resources.search, new Size(50, 50));
            btnAddAccountS.Image = new Bitmap(Resources.add, new Size(50, 50));
            btnUpdateAccountS.Image = new Bitmap(Resources.refresh, new Size(50, 50));
            btnDeleteAccountS.Image = new Bitmap(Resources.bin, new Size(50, 50));

            tbcScreens.SelectedTab = tbcScreens.TabPages["tbAccounts"];
            
        }
        private void _ShowCustomersListScreen()
        {
            CurrentScreen = enScreens.eCustomersList;

            this.pbScreenImage.Image = new Bitmap(Resources.list);
            lblScreenName.Text = "Customers List Screen";

            btnReturnToAccountsScreen.Image = new Bitmap(Resources.back, new Size(30, 30));

            tbcScreens.SelectedTab = tbcScreens.TabPages["tbCustomersList"];

            dgvCustomersList.DataSource = clsCustomer.GetCustomersList();

        }
        private void _ShowAccountsListScreen()
        {
            CurrentScreen = enScreens.eAccountsList;

            this.pbScreenImage.Image = new Bitmap(Resources.list);
            lblScreenName.Text = "Accounts List Screen";

            btnReturnToAccountsScreen2.Image = new Bitmap(Resources.back, new Size(30, 30));

            tbcScreens.SelectedTab = tbcScreens.TabPages["tbAccountsList"];

            dgvAccountsList.DataSource = clsAccount.GetAccountsList();

        }
        private void _ShowSearchAccountScreen(enScreens ScreenType = enScreens.eSearchAccount)
        {
            btnReturnToAccountsScreen3.Image = new Bitmap(Resources.back, new Size(30, 30));
            tbcScreens.SelectedTab = tbcScreens.TabPages["tbSearchAccount"];
            lblFindStatus.Visible = false;

            if(ScreenType == enScreens.eSearchAccount)
            {
                CurrentScreen = enScreens.eSearchAccount;
                this.pbScreenImage.Image = new Bitmap(Resources.search);
                lblScreenName.Text = "Search Account Screen";

                pAccountInfo.Visible = false;
                txtAccountID.Text = string.Empty;
                btnUpdateAccS.Image = new Bitmap(Resources.refresh, new Size(20, 20));
                btnDeleteAccS.Image = new Bitmap(Resources.bin, new Size(20, 20));
                btnUpdateAccS.Visible = false;
                btnDeleteAccS.Visible = false;
            }
            else if (ScreenType == enScreens.eCheckBalance)
            {
                CurrentScreen = enScreens.eCheckBalance;
                this.pbScreenImage.Image = new Bitmap(Resources.check_balance);
                lblScreenName.Text = "Check Account Balance Screen";

                pCheckBalanceResult.Visible = false;

            }
        }
        private void _DeleteAccount(int AccountID)
        {
            if (MessageBox.Show("Are you sure you want to delete this account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (clsAccount.DeleteAccount(AccountID))
                {
                    MessageBox.Show("Account deleted syccessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Account deletion failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _ShowAccountsScreen();
            }
        }


        //Transactions Screen Functions/Procedures:
        private void _ShowTransactionsScreen()
        {
            CurrentScreen = enScreens.eTransactions;

            this.pbScreenImage.Image = new Bitmap(Resources.transactions);
            lblScreenName.Text = "Transactions Screen";

            btnDeposit.Image = new Bitmap(Resources.deposit, new Size(50, 50));
            btnWithdraw.Image = new Bitmap(Resources.withdrawal, new Size(50, 50));
            btnCheckBalance.Image = new Bitmap(Resources.check_balance, new Size(50, 50));
            btnTransfer.Image = new Bitmap(Resources.transfer, new Size(50, 50));
            btnTransactionsHistory.Image = new Bitmap(Resources.history, new Size(50, 50));
            btnTotalBalances.Image = new Bitmap(Resources.total_balances, new Size(50, 50));


            tbcScreens.SelectedTab = tbcScreens.TabPages["tbTransactions"];
        }
        private void _ShowTransactionsHistoryScreen()
        {
            CurrentScreen = enScreens.eTransactionsHistory;

            this.pbScreenImage.Image = new Bitmap(Resources.history);
            lblScreenName.Text = "Transactions History (Log) Screen";

            btnBackToAccountsScreen.Image = new Bitmap(Resources.back, new Size(30, 30));

            tbcScreens.SelectedTab = tbcScreens.TabPages["tbTransactionsHistory"];

            dgvTransactionsHistory.DataSource = clsTransaction.GetTransactionsHistory();

        }
        private void _ShowTotalBalancesScreen()
        {
            CurrentScreen = enScreens.eTotalBalances;

            this.pbScreenImage.Image = new Bitmap(Resources.total_balances);
            lblScreenName.Text = "Total Balances Screen";

            btnBackToAccountsScreen2.Image = new Bitmap(Resources.back, new Size(30, 30));

            tbcScreens.SelectedTab = tbcScreens.TabPages["tbTotalBalances"];

            dgvTotalBalances.DataSource = clsAccount.GetTotalBalances();

        }


        public frmMain(clsUser user)
        {
            this.user = user;


            InitializeComponent();
            btnDashboard.Image = new Bitmap(Resources.dashboard, new Size(30, 30));
            btnAccounts.Image = new Bitmap(Resources.multiple_users_silhouette, new Size(30, 30));
            btnTransactions.Image = new Bitmap(Resources.transactions, new Size(30, 30));
            _HideTabheader();
            _ShowDasboardScreen();

        }

        //buttons actions:

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if(CurrentScreen != enScreens.eDashboard)
                _ShowDasboardScreen();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            if (CurrentScreen != enScreens.eAccounts)
                _ShowAccountsScreen();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnReturnToAccountsScreen_Click(object sender, EventArgs e)
        {
            _ShowAccountsScreen();
        }

        private void btnCustomerListS_Click(object sender, EventArgs e)
        {
            if (CurrentScreen != enScreens.eCustomersList)
                _ShowCustomersListScreen();
        }

        private void btnAccountListS_Click(object sender, EventArgs e)
        {
            if (CurrentScreen != enScreens.eAccountsList)
                _ShowAccountsListScreen();
        }

        private void btnReturnToAccountsScreen2_Click(object sender, EventArgs e)
        {
            _ShowAccountsScreen();
        }

        private void btnReturnToAccountsScreen3_Click(object sender, EventArgs e)
        {
            if(CurrentScreen != enScreens.eCheckBalance)
                _ShowAccountsScreen();
            else
                _ShowTransactionsScreen();
        }

        private void btnSearchAccountS_Click(object sender, EventArgs e)
        {
            if (CurrentScreen != enScreens.eSearchAccount)
                _ShowSearchAccountScreen();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAccountID.Text.ToString(), out int id))
            {
                clsAccount account = clsAccount.FindAccountByID(id);
                if (account == null)
                {
                    pAccountInfo.Visible = false;
                    pCheckBalanceResult.Visible = false;
                    lblFindStatus.Visible = true;
                    btnUpdateAccS.Visible = false;
                    btnDeleteAccS.Visible = false;
                }
                else if (CurrentScreen == enScreens.eSearchAccount)
                {
                    lblFindStatus.Visible = false;
                    lblAccountID.Text = account.AccountID.ToString();
                    lblOwnerName.Text = clsCustomer.FindCustomerByID(account.CustomerID).CustomerName;
                    lblDateOpened.Text = account.DateOpened.ToShortDateString();
                    lblAccountType.Text = account.AccountType.ToString();
                    lblBalance.Text = account.Balance.ToString() + "$";
                    btnUpdateAccS.Visible = true;
                    btnDeleteAccS.Visible = true;
                    pAccountInfo.Visible = true;
                }
                else if (CurrentScreen == enScreens.eCheckBalance)
                {
                    lblFindStatus.Visible = false;
                    lblAccountID2.Text = account.AccountID.ToString();
                    lblBalance2.Text = account.Balance.ToString() + "$";

                    pCheckBalanceResult.Location = pAccountInfo.Location;
                    pCheckBalanceResult.Visible = true;


                }
            }
        }

        private void btnAddAccountS_Click(object sender, EventArgs e)
        {
            frmAddUpdateAccount fAdd = new frmAddUpdateAccount(-1);
            fAdd.ShowDialog();
        }

        private void btnUpdateAccS_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAccountID.Text, out int parsedID))
            {
                frmAddUpdateAccount fAdd = new frmAddUpdateAccount(parsedID);
                fAdd.ShowDialog();
                _ShowSearchAccountScreen();
            }
            else
                MessageBox.Show("Enter a valied number (ID)", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnUpdateAccountS_Click(object sender, EventArgs e)
        {
            _ShowSearchAccountScreen();
        }

        private void btnDeleteAccountS_Click(object sender, EventArgs e)
        {
            _ShowSearchAccountScreen();
        }

        private void btnDeleteAccS_Click(object sender, EventArgs e)
        {
            _DeleteAccount(Convert.ToInt32(txtAccountID.Text));
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if(CurrentScreen != enScreens.eTransactions)
                _ShowTransactionsScreen();
        }

        private void btnTransactionsHistory_Click(object sender, EventArgs e)
        {
            if (CurrentScreen != enScreens.eTransactionsHistory)
                _ShowTransactionsHistoryScreen();
        }

        private void btnBackToAccountsScreen_Click(object sender, EventArgs e)
        {
            _ShowTransactionsScreen();

        }

        private void btnBackToAccountsScreen2_Click(object sender, EventArgs e)
        {
            _ShowTransactionsScreen();
        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            if (CurrentScreen != enScreens.eTotalBalances)
                _ShowTotalBalancesScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CurrentScreen != enScreens.eDashboard)
                _ShowDasboardScreen();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {

            if (CurrentScreen != enScreens.eCheckBalance)
                _ShowSearchAccountScreen(enScreens.eCheckBalance);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            CurrentScreen = enScreens.eDeposit;
            frmDepositWithdraw frm = new frmDepositWithdraw(false);
            frm.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            CurrentScreen = enScreens.eWithdraw;
            frmDepositWithdraw frm = new frmDepositWithdraw(true);
            frm.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            CurrentScreen = enScreens.eTransfer;
            frmTransfer frm = new frmTransfer();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
