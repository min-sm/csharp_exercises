using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic8Test0
{
    public partial class frmInheritance : Form
    {
        List<User> accounts;

        public frmInheritance()
        {
            InitializeComponent();
        }

        public void addAccount(String name, String user, String pass, Boolean admin)
        {
            User u;
            if (admin == true)
            {
                u = new AdminUser();
            }
            else
            {
                u = new NormalUser();

            }

            u.Realname = name;
            u.Username = user;
            u.Password = pass;

            accounts.Add(u);
        }

        private void frmInheritance_Load(object sender, EventArgs e)
        {
            accounts = new List<User>();
            addAccount("Michael Heron", "mjh", "bing1", true);
            addAccount("Alan Moon", "am1", "ticket", false);
            addAccount("Aoife Lockhart", "awl", "euro", true);
        }

        private User findAccount(String us)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username.ToLower() == us.ToLower())
                {
                    return accounts[i];
                }
            }
            return null;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            User user;
            user = findAccount(txtLogin.Text);
            if (user == null)
            {
                MessageBox.Show("No such account");
                return;
            }

            if (user.checkPassword(txtPassword.Text))
            {
                //string accType = "";
                //if (user is AdminUser)
                //{
                //    accType = "an admin";
                //} else
                //{
                //    accType = "a normal user.";
                //}
                //MessageBox.Show("Access granted\nWelcome " + user.Realname + ". You are " + accType);
                MessageBox.Show("Access granted\nWelcome " + user.Realname + ". You are " + (user is AdminUser ? "an admin" : "a normal user."));

            }
            else
            {
                if (user is AdminUser && ((AdminUser)user).Locked == true)
                {
                    MessageBox.Show("Admin account locked.");
                }
                else
                {
                    MessageBox.Show("Access Denied");

                }
            }
        }

        
    }
}
