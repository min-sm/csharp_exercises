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

        public LoginForm(AccountList accListPassedObj)
        {
            InitializeComponent();
            accountList = accListPassedObj;
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
            //
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(accountList, this);

            registerForm.Show();
            MessageBox.Show("This works 2");
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //if (accountList == null)
            //{
            //    accountList = new AccountList();
            //}
            accountList = new AccountList();
        }
    }
}
