using System;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class clsAccount
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int AccountID { get; set; }
        public string PinCode { get; set; }
        public int Balance { get; set; }
        public string AccountType { get; set; }
        public DateTime DateOpened { get; set; }

       // public clsCustomer Owner = new clsCustomer();

        public int CustomerID { get; set; }


        public clsAccount() 
        {
            AccountID = -1;
            PinCode = string.Empty;
            AccountType = string.Empty;
            Balance = -1;
            DateOpened = DateTime.MinValue;
            CustomerID = -1;

            Mode = enMode.AddNew;
        }

        private clsAccount (int AccountID, DateTime DateOpened, string AccountType, string PinCode, int Balance,
            int CustomerID) 
        {
            this.AccountID = AccountID;
            this.PinCode = PinCode;
            this.AccountType = AccountType;
            this.Balance = Balance;
            this.DateOpened = DateOpened;
            this.CustomerID = CustomerID;

            Mode = enMode.Update;
        }

        public static clsAccount FindAccountByID(int ID)
        {
            string pincode = "";
            int balance = -1;
            string accounttype = "";
            DateTime dateopened = DateTime.MinValue;
            int customerID = -1;

            if (clsAccountsDataAccess.FindAccountByID(ID, ref dateopened, ref accounttype, ref pincode, ref balance,
                ref customerID))
            {
                return new clsAccount(ID, dateopened, accounttype, pincode, balance, customerID);
            }

            return null;
        }

        public static int GetTotalBankCapital()
        {
            return clsAccountsDataAccess.GetTotalBankCapital();
        }

        public static int GetNoOfActiveAccounts()
        {
            return clsAccountsDataAccess.GetNoOfActiveAccounts();
        }

        public static DataTable GetAccountsList()
        {
            return clsAccountsDataAccess.GetAccountsList();
        }

        private bool _AddNewAccount()
        {
            this.AccountID = clsAccountsDataAccess.AddNewAccount(DateOpened, clsAccountTypes.Find(AccountType).Code, PinCode, Balance, CustomerID);

            return (this.AccountID != -1);
        }

        private bool _UpdateContact()
        {
            return clsAccountsDataAccess.UpdateAccount(this.AccountID, DateOpened, clsAccountTypes.Find(AccountType).Code, PinCode, Balance);
        }

        public static bool DeleteAccount(int AccountID)
        {
            return clsAccountsDataAccess.DeleteAccount(AccountID);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAccount())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateContact();
            }
            return false;
        }


        public static DataTable GetTotalBalances()
        {
            return clsAccountsDataAccess.GetTotalBalances();
        }

    }
}
