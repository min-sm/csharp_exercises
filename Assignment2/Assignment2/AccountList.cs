using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDraft
{
    public class AccountList
    {
        private List<Account> allAccounts;

        public AccountList()
        {
            allAccounts = new List<Account>();
        }

        public void RegisterAccount(string username, string password)
        {
            // Check if the username is unique before adding a new account
            if (!UsernameExists(username))
            {
                Account newAccount = new Account { Username = username, Password = password };
                allAccounts.Add(newAccount);
                MessageBox.Show("Account registered successfully!", "Account Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // if possible, automatically close the registerform 
            }
            else
            {
                //MessageBox.Show("Username already exists. Choose a different username.", "Account Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Username already exists. Please try a different one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public bool Login(string username, string password)
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
                        return true;
                    }
                    else
                    {
                        // Incorrect password
                        return false;
                    }
                }
            }
            // if username isn't found
            // Tell him we can't find his username or he hasn't created the account
            return false;
        }

        private bool UsernameExists(string username)
        {
            // I can use a normal for loop and also return if number I found it
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
            //foreach (Account acc in allAccounts)
            //{
            //    Console.WriteLine($"Username: {acc.Username}, Password: {acc.Password}");
            //}

            StringBuilder message = new StringBuilder();

            foreach (Account acc in allAccounts)
            {
                message.AppendLine($"Username: {acc.Username}, Password: {acc.Password}");
            }

            MessageBox.Show(message.ToString(), "Account List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
