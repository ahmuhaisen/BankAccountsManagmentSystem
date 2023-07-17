using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

namespace DataAccessLayer
{
    public static class clsAccountsDataAccess
    {
        public static bool FindAccountByID(int AccountID, ref DateTime DateOpened, ref string AccountType, ref string PinCode,
            ref int Balance, ref int CustomerID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Accounts INNER JOIN Account_Types 
                            ON Accounts.Account_Types_Code = Account_Types.Account_Types_Code
                            WHERE Account_ID = @AccountID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                if (reader.Read())
                {
                    AccountType = (string)reader["Account_Types_Description"];
                    PinCode = (string)reader["PinCode"];
                    CustomerID = (int)reader["Customer_ID"];
                    if (reader["Balance"] == DBNull.Value)
                        Balance = 0;
                    else
                        Balance = (int)reader["Balance"];
                    if (reader["Date_Opened"] == DBNull.Value)
                        DateOpened = DateTime.MinValue;
                    else
                        DateOpened = (DateTime)reader["Date_Opened"];
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int GetTotalBankCapital()
        {
            int TotalCapital = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT SUM(Accounts.Balance) as BankCapital from Accounts;";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();            
                object result = command.ExecuteScalar();

                if(result != null && (int.TryParse(result.ToString(), out int parsedResult))) 
                {
                    TotalCapital = parsedResult;
                }

            }
            catch (Exception ex)
            {
                TotalCapital = -1;
            }
            finally { connection.Close(); }

            return TotalCapital;
        }

        public static int GetNoOfActiveAccounts()
        {
            int number = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT COUNT(Accounts.Account_ID) as ActiveAccounts from Accounts;";

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

        public static DataTable GetAccountsList()
        {
            DataTable datatable= new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM AccountsListShortInfo;";

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

        public static int AddNewAccount(DateTime DateOpened, int AccountType, string PinCode, int Balance,
            int CustomerID)
        {
            //this function will return the new Account id if succeeded and -1 if not.
            int AccountID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Accounts (Date_Opened, Customer_ID, Account_Types_Code, Balance, PinCode)
                             VALUES (@DateOpened, @CustomerID, @AccountType, @Balance, @PinCode);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DateOpened", DateOpened);
            command.Parameters.AddWithValue("@AccountType", AccountType);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AccountID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                AccountID = -1;
            }

            finally
            {
                connection.Close();
            }


            return AccountID;
        }

        public static bool UpdateAccount(int Account_ID, DateTime DateOpened, int AccountType, string PinCode, int Balance)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Accounts  
                            set Date_Opened = @DateOpened, 
                                Account_Types_Code = @AccountType, 
                                PinCode = @PinCode, 
                                Balance = @Balance
                            WHERE Account_ID = @AccountID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountID", Account_ID);
            command.Parameters.AddWithValue("@DateOpened", DateOpened);
            command.Parameters.AddWithValue("@AccountType", AccountType);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteAccount(int Account_ID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Accounts 
                             where Account_ID = @Account_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Account_ID", Account_ID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetTotalBalances()
        {
            DataTable datatable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM AccountsTotalBalances;";

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
