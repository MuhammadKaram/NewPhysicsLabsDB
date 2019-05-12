using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsLabsDB
{
    public static class LoggedUser
    {
        public static string UserName { get; set; }
        public static string UserPassword { get; set; }
        public static int ResponID { get; set; }
        public static string Respon { get; set; }
        public static int AccountTypeID { get; set; }
        public static string AccountType { get; set; }

        public static void FillLoggedUser(account loggedUser)
        {
            UserName = loggedUser.UserName;
            UserPassword = loggedUser.UserPassword;
            ResponID = loggedUser.Respon;
            Respon = loggedUser.respon1.name;
            AccountTypeID = loggedUser.AccountType;
            AccountType = loggedUser.account_types.AccountType;
        }
    }
}
