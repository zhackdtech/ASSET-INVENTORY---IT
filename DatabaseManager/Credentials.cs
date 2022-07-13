using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Asset_Inventory.DatabaseManager
{
    internal class Credentials
    {
        private static string username,password;

        public static string db_user
        {
            get => username;
            set => username = value;
        }
        public static string db_password
        {
            get => password;
            set => password = value;
        }
    }
}
