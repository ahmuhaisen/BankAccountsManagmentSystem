using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsTransactionDataAccess
    {
        public static int AddNewTransaction(DateTime DatePerformed, int AmountOfTransaaction, int AccountID, int TransactionTypeCode)
        {
            //this function will return the new transaction id if succeeded and -1 if not.
            int TransactionID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Transactions (Date, Amount_Of_Transaction, Account_ID, Transaction_Types_Code)
                             VALUES (@DatePerformed, @AmountOfTransaaction, @AccountID, @TransactionTypeCode);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DatePerformed", DatePerformed);
            command.Parameters.AddWithValue("@AmountOfTransaaction", AmountOfTransaaction);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@TransactionTypeCode", TransactionTypeCode);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TransactionID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                TransactionID = -1;
            }

            finally
            {
                connection.Close();
            }


            return TransactionID;
        }


        public static int GetNumberOfTodaysTransactions()
        {
            int number = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT COUNT(Transactions.Transaction_ID) as TodaysTransactions FROM Transactions
                             WHERE CAST (Transactions.Date AS DATE) = CAST (GETDATE() AS DATE);";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && (int.TryParse(result.ToString(), out int parsedResult)))
                {
                    number = parsedResult;
                }

            }
            catch (Exception ex)
            {
                number = -1;
            }
            finally { connection.Close(); }

            return number;
        }

        public static DataTable GetTransactionsHistory()
        {
            DataTable datatable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TransactionsHistory;";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    datatable.Load(reader);
                }

            }
            catch (Exception ex)
            {
                datatable = null;
            }
            finally { connection.Close(); }

            return datatable;
        }


    }
}
