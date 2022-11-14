using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationWindow.Model
{
    public static class UserAuthorizator
    {
        
        public static bool CheckingUser(string login, string password)
        {
            foreach (var user in GetUserList())
            {
                if (user.Login == login && user.Password == password)
                    return true;
            }
            return false;
        }
    }
}
