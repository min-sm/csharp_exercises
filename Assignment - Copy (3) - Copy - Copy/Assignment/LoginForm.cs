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
        StartingForm stFrm;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(StartingForm stFrm)
        {
            InitializeComponent();
            this.stFrm = stFrm;
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

        int errorCounter = 0;
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            int accIndex = accountList.Login(username, password);
            if (accIndex != -1)
            {
                if (accountList.isFirstTimeLogin(accIndex))
                {
                    openProfileSetUpForm(accountList, accIndex);
                }
                else
                {
                    MainForm mf = new MainForm(accountList, accIndex, this, stFrm);
                    mf.Show();
                }
                this.Hide();
                //MainForm mf = new MainForm(accountList, accIndex);
                //mf.Show();
            }
            else
            {
                if (errorCounter == 0)
                {
                    MessageBox.Show("You are allowed to enter invalid input for 5 times.", "Allowed Attempts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                errorCounter++;
                if (errorCounter == 5)
                {
                    MessageBox.Show("The program will be stopped now for you have tried your 5 attempts.", "Program shutting down.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    Application.Exit();
                    return;
                }
                MessageBox.Show("The program will stop after next " + (5 - errorCounter) + " failed attemps.", "" + errorCounter + " of 5", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openProfileSetUpForm(AccountList passedAccList, int passedAccIndex)
        {
            ProfileSetUpForm profileSetUpForm = new ProfileSetUpForm(passedAccList, passedAccIndex, stFrm, this);
            profileSetUpForm.Show();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(accountList, this, stFrm);
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
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            //Application.Exit();
            stFrm.Close();
        }
    }
}
