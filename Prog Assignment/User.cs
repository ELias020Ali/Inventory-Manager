using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Assignment
{
    internal class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getUsername()
        {
            return username;
        }

        public bool checkPassword(string pass)
        {
            if (password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
