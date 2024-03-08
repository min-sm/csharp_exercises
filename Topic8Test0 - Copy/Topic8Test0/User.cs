using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic8Test0
{
    internal class User
    {
        private String realname;
        private String username;
        private String password;

        public virtual Boolean checkPassword(string pass)
        {
            if (pass.ToLower().Equals(password.ToLower()))
            {
                return true;
            }

            return false;
        }

        public String Realname { get { return realname; }   set { realname = value; }}
        public String Username { get { return username; } set { username = value; } }
        public String Password { get { return password; } set { password = value;} }
    }
}
