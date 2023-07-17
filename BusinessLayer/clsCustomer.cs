using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogicLayer
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime DateBecomeCustomer { get; set; }

        public clsCustomer()
        {
            CustomerID = -1;
            CustomerName = string.Empty;
            CustomerPhone = string.Empty;
            CustomerEmail = string.Empty;
            DateBecomeCustomer = DateTime.MinValue;
        }

        public clsCustomer(int ID, string Name, string Phone, string Email, DateTime date)
        {
            CustomerID = ID;
            CustomerName = Name;
            CustomerPhone = Phone;
            CustomerEmail = Email;
            DateBecomeCustomer = date;
        }

        public static clsCustomer FindCustomerByID(int ID)
        {
            string Name = "", Phone = "", Email = "";
            DateTime date = DateTime.MinValue;

            if(clsCustomersDataAccess.FindCustomerByID(ID, ref Name, ref Phone, ref Email, ref date))
            {
                return new clsCustomer(ID, Name, Phone, Email, date);
            }

            return new clsCustomer();
        }

        public static DataTable GetCustomersList()
        {
            return clsCustomersDataAccess.GetCustomersList();

        }

        
    }
}
