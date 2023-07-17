using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsCustomersDataAccess
    {
        public static DataTable GetCustomersList()
        {
            DataTable datatable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Customers;";

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

        public static bool FindCustomerByID(int CustomerID, ref string Name, ref string Phone,
            ref string Email, ref DateTime date)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Customers WHERE Customer_ID = @CustomerID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                if (reader.Read())
                {
                    Name = (string)reader["Customer_Name"];
                    Phone = (string)reader["Customer_Phone"];
                    if (reader["Customer_Email"] == DBNull.Value)
                        Email = string.Empty;
                    else
                        Email = (string)reader["Customer_Email"];
                    if (reader["Date_Become_Customer"] == DBNull.Value)
                        date = DateTime.MinValue;
                    else
                        date = (DateTime)reader["Date_Become_Customer"];
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Access Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
