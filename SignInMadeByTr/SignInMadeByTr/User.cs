using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInMadeByTr
{
    public class User
    {
        private string username;
        private string password;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public Boolean checkPassword(string pass)
        {
            if (pass.Equals(password))
            {
                return true;
            }
            return false;
        }
    }
}
