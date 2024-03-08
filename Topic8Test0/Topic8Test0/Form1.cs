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
        List<NormalUser> accounts;

        public frmInheritance()
        {
            InitializeComponent();
        }

        public void addAccount(String name, String user, String pass)
        {
            NormalUser u;
            u = new NormalUser();

            u.Realname = name;
            u.Username = user;
            u.Password = pass;

            accounts.Add(u);
        }

        private void frmInheritance_Load(object sender, EventArgs e)
        {
            accounts = new List<NormalUser>();
            addAccount("Michael Heron", "mjh", "bing1");
            addAccount("Alan Moon", "am1", "ticket");
            addAccount("Aoife Lockhart", "awl", "euro");
        }

        private NormalUser findAccount(String us)
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
            NormalUser user;
            user = findAccount(txtLogin.Text);
            if (user == null)
            {
                MessageBox.Show("No such account");
                return;
            }

            if (user.checkPassword(txtPassword.Text))
            {
                MessageBox.Show("Access granted\nWelcome " + user.Realname);
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
        }

        
    }
}
