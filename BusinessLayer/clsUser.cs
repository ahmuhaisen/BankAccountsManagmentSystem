using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class clsUser
    {
    
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

       


        public int UserID { get; set; }
        public string username { get; set; }
        public int permissions { get; set; }
        public string password { get; set; }


        public clsUser()
        {
            UserID = -1;
            username = string.Empty;
            permissions = 0;
            password = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, string username, string password, int permissions)
        {
            this.UserID = UserID;
            this.username = username;
            this.password = password;
            this.permissions = permissions;

            Mode = enMode.Update;
        }

        public static clsUser FindUserByUsername(string username)
        {
            int userID = -1;
            int permissions = 0;
            string password = string.Empty;

            if (clsUsersDataAccess.FindUserByUsername(username, ref userID, ref password, ref permissions))
            {
                return new clsUser(userID, username, password, permissions);
            }

            return null;
        }



        public static DataTable GetUsersList()
        {
            return clsUsersDataAccess.GetUserssList();
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUsersDataAccess.AddNewUser(username, password, permissions);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUsersDataAccess.UpdateUser(username, password, permissions);
        }

        public static bool DeleteAccount(string username)
        {
            return clsUsersDataAccess.DeleteUser(username);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }


        





    }




}
