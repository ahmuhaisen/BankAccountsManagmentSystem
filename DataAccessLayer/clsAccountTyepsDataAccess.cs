using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsAccountTyepsDataAccess
    {

        public static bool GetAccountInfoByName(string AccountTypeName, ref int _Code)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Account_Types WHERE Account_Types_Description = @AccountTypeName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountTypeName", AccountTypeName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    _Code = (int)reader["Account_Types_Code"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static DataTable GetAccountTypes()
        {
            DataTable datatable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Account_Types;";

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
