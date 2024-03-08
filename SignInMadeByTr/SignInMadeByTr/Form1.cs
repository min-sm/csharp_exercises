using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInMadeByTr
{
    public partial class Form1 : Form
    {
        private List<User> newAccounts = new List<User>();

        public Form1(List<User> accounts)
        {
            InitializeComponent();
            newAccounts = accounts;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private User findAccount(string us)
        {
            for (int i = 0; i < newAccounts.Count; i++)
            {
                if (newAccounts[i].Username.ToLower() == us.ToLower())
                {
                    return newAccounts[i];
                }
            }

            return null;
        }

        private void cmdSignUp_Click(object sender, EventArgs e)
        {
            frmRegister fr = new frmRegister();
            fr.Show();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            User user;
            user = findAccount(txtName.Text);
            if (user == null)
            {
                MessageBox.Show("No such account.");
                return;
            }
            if (user.Password.Equals(txtPassword.Text))
            {
                MessageBox.Show("Access granted");
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
        }
    }
}
