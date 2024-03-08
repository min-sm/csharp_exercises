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
    public partial class frmRegister : Form
    {
        private List<User> accounts;
        public frmRegister()
        {
            InitializeComponent();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            User u;
            u = new User();
            u.Username = txtUsername.Text;
            u.Password = txtPassword.Text;
            accounts.Add(u);

            Form f1 = new Form1(accounts);
            f1.Show();
        }

        private void cmdShowPwd_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = default(char);
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            accounts = new List<User>();
        }

        private void cmdShowConfirmPwd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test TEst test");
           //this.BackColor = Color.Black;
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}
