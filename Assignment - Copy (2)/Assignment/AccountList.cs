using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class AccountList
    {
        private List<Account> allAccounts;

        public AccountList()
        {
            allAccounts = new List<Account>();
        }

        public AccountList(Account acc)
        {
            allAccounts = new List<Account>();
            allAccounts.Add(acc);
        }

        public bool RegisterAccount(string username, string password)
        {
            // Check if the username is unique before adding a new account
            if (!UsernameExists(username))
            {
                Account newAccount = new Account { Username = username, Password = password };
                allAccounts.Add(newAccount);
                
                MessageBox.Show("Account registered successfully!", "Account Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Username already exists. Please try a different one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public int Login(string username, string password)
        {
            for (int i = 0; i < allAccounts.Count; i++)
            {
                // Found the username
                if (allAccounts[i].Username == username)
                {
                    // Check if the password is correct
                    if (allAccounts[i].Password == password)
                    {
                        // Log In
                        MessageBox.Show("Login successful!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return i;
                    }
                    else
                    {
                        // Incorrect password
                        MessageBox.Show("Please check your password and try again.", "Missing Required Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
            // if username isn't found
            // Tell him we can't find his username or he hasn't created the account
            MessageBox.Show("Account not found. \nPlease verify your input or create a new account.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }

        private bool UsernameExists(string username)
        {
            foreach (Account acc in allAccounts)
            {
                if (acc.Username == username)
                {
                    return true;
                }
            }
            return false;
        }

        // To debug and to output items in the list
        public void PrintAccountList()
        {
            foreach (Account acc in allAccounts)
            {
                Console.WriteLine($"Username: {acc.Username}, Password: {acc.Password}");
            }

            StringBuilder message = new StringBuilder();

            foreach (Account acc in allAccounts)
            {
                message.AppendLine($"Username: {acc.Username}, Password: {acc.Password}");
            }

            MessageBox.Show(message.ToString(), "Account List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool isFirstTimeLogin(int accIndex)
        {
            // this is the first time, since there is no value for bodyWeight & targetCalories
            if (allAccounts[accIndex].BodyWeight == 0 || allAccounts[accIndex].TargetCalories == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
    
        public void profileSetup(string fName, string lName, double bWeight, double tCal, int currentIndex)
        {
            allAccounts[currentIndex].FirstName = fName;
            allAccounts[currentIndex].LastName = lName;
            allAccounts[currentIndex].BodyWeight = bWeight;
            allAccounts[currentIndex].TargetCalories = tCal;
        }

        public Account returnSelectedAccountObj(int currentIndex)
        {
            return allAccounts[currentIndex];
        }

        public void updateBodyWeightAndTargetChange (int currentIndex, float bWeight, float tCal)
        {
            allAccounts[currentIndex].BodyWeight = bWeight;
            allAccounts[currentIndex].TargetCalories = tCal;
        }
    }
}
