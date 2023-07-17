using System;
using System.Data;
using DataAccessLayer;
using static LogicLayer.clsAccount;

namespace LogicLayer
{
    public class clsTransaction
    {
        
        public int TransactionID { get; set; }
        public DateTime DatePerformed { get; set; }
        public int AmountOfTransaaction { get; set; }
        public int AccountID { get; set; }
        public int TransactionTypeCode { get; set; }   // 1 --> Deposit, 2 --> Withdraw


        public clsTransaction()
        {
            TransactionID = -1;
            AmountOfTransaaction = -1;
            AccountID = -1;
            TransactionTypeCode = -1;
            DatePerformed = DateTime.Now;
        }

        public clsTransaction(int TransactionID, DateTime DatePerformed, int AmountOfTransaaction, int AccountID, int TransactionTypeCode)
        {
            this.TransactionID          = TransactionID       ;
            this.AmountOfTransaaction   = AmountOfTransaaction;
            this.AccountID              = AccountID           ;
            this.TransactionTypeCode    = TransactionTypeCode ;
            this.DatePerformed          = DatePerformed;
        }

        private bool _AddNewTransaction()
        {
            this.TransactionID = clsTransactionDataAccess.AddNewTransaction(DatePerformed, AmountOfTransaaction, AccountID, TransactionTypeCode);

            return (this.TransactionID != -1);
        }

        public bool Save()
        {
            if (_AddNewTransaction())
                return true;
            else
                return false;

        }


        public static int GetNumberOfTodaysTransactions()
        {
            return clsTransactionDataAccess.GetNumberOfTodaysTransactions();
        }

        public static DataTable GetTransactionsHistory()
        {
            return clsTransactionDataAccess.GetTransactionsHistory();
        }


    }
}
