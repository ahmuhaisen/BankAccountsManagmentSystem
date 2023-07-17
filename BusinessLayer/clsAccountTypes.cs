using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class clsAccountTypes
    {
        public int Code { get; set; }
        public string Name { get; set; }


        public clsAccountTypes()
        {
            Code = -1;
            Name = string.Empty;
        }
        public clsAccountTypes(int Code, string Name)
        {
            this.Code = Code;
            this.Name = Name;
        }

        public static clsAccountTypes Find(string AccountTypeName)
        {
            int _Code = -1;
            if(clsAccountTyepsDataAccess.GetAccountInfoByName(AccountTypeName, ref _Code))
                return new clsAccountTypes(_Code, AccountTypeName);
            else
                return new clsAccountTypes();

        }

        public static DataTable GetAccountTypes()
        {
            return clsAccountTyepsDataAccess.GetAccountTypes();
        }

    }
}
