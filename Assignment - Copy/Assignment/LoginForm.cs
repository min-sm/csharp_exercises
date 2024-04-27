using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
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

        public LoginForm(RegisterForm passedRegisterForm)
        {
            InitializeComponent();
        }

        private void cmdRegister_MouseHover(object sender, EventArgs e)
        {
            cmdRegister.ForeColor = Color.Black;
        }

        private void cmdRegister_MouseLeave(object sender, EventArgs e)
        {
            cmdRegister.ForeColor = Color.White; // change text color back
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            accountList = new AccountList();
            this.cmdRegister.MouseHover += new System.EventHandler(this.cmdRegister_MouseHover);
            this.cmdRegister.MouseLeave += new System.EventHandler(this.cmdRegister_MouseLeave);
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            bool isLogIn = accountList.Login(username, password);
            if (isLogIn)
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
                //this.Close();
            }
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(accountList, this);

            registerForm.Show();
            this.Hide();
        }

        private void chkBxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '⁕')
            {
                txtPassword.PasswordChar = default(char);
            }
            else
            {
                txtPassword.PasswordChar = '⁕';
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
