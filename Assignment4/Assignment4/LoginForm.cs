using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDraft
{
    public partial class LoginForm : Form
    {
        AccountList accountList;
        string username = "";
        string password = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            accountList.PrintAccountList();
            if (accountList.Login(username, password))
            {
                MessageBox.Show("Login successful!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(accountList, this);

            registerForm.Show();
            this.Hide();
        }

        private void cmdRegister_MouseHover(object sender, EventArgs e)
        {
            cmdRegister.ForeColor = Color.Black;
        }

        private void cmdRegister_MouseLeave(object sender, EventArgs e)
        {
            cmdRegister.ForeColor = Color.White; // change text color back
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            accountList = new AccountList();
            this.cmdRegister.MouseHover += new System.EventHandler(this.cmdRegister_MouseHover);
            this.cmdRegister.MouseLeave += new System.EventHandler(this.cmdRegister_MouseLeave);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
