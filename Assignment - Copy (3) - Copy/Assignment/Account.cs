using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Account
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private double bodyWeight;
        private double targetCalories;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password { get { return password; } set { password = value; } }

        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

        public double BodyWeight { get { return bodyWeight; } set { bodyWeight = value; } }

        public double TargetCalories { get { return targetCalories; } set { targetCalories = value; } }
    }
}
