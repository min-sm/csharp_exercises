using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RegisterForm : Form
    {
        // Variables Initialization
        string username = "";
        string password = "";
        string confirm_password = "";

        private AccountList accountList;
        StartingForm stFrm;

        // Constructor that takes an AccountList parameter
        //private LoginForm loginForm;

        // Constructor that takes an AccountList parameter
        //public RegisterForm(AccountList accountList, LoginForm loginForm, StartingForm stFrm)
        //{
        //    InitializeComponent();

        //    // Assign the passed AccountList to the local variable
        //    this.accountList = accountList;
        //    this.loginForm = loginForm;
        //    this.stFrm = stFrm;
        //}

        public RegisterForm(AccountList accountList, StartingForm stFrm)
        {
            InitializeComponent();

            // Assign the passed AccountList to the local variable
            this.accountList = accountList;
            this.stFrm = stFrm;
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            // first take the values in the textbox
            username = txtUsername.Text;
            password = txtPassword.Text;
            confirm_password = txtConfirmPassword.Text;

            // Checks if the username is not blank
            if (username.Length <= 0)
            {
                changeUsernameTxtBx("Username required.");
                MessageBox.Show("Please enter username.", "Username required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checks if the username matches with the format
            if (txtUsername.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Username can only contain letters and numbers.", "Username Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checks if the password matches with the format
            // This also checks for if the password is blank or not.
            // Pattern for password
            string pPattern = "^(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{12}$";
            Match pMatch = Regex.Match(password, pPattern);
            if (pMatch.Success)
            {
                // Checks if the confirm password isn't blank and confirm password not equal to text in the password
                // I can put only one condition though
                if (confirm_password.Length <= 0 || password != txtConfirmPassword.Text)
                {
                    txtConfirmPassword.BackColor = Color.IndianRed;
                    lblConfirmPasswordWarning.Visible = true;
                    MessageBox.Show("Passwords don't match. Please re-enter both passwords.", "Mismatched passwords!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Checks if the username is available
                bool yesAccountCreate = accountList.RegisterAccount(username, password);
                // If the username is availabe, RegisterForm will be closed and LoginForm will be shown
                if (yesAccountCreate)
                {
                    // Prompting message box to let user know that the account is successfully is handled in the AccountList.cs
                    //loginForm.Show();
                    LoginForm lgFrm = new LoginForm();
                    lgFrm.Show();
                    this.Close();
                }
                // Else case for if the username isn't available is handled in the AccountList.cs
            }
            // This will work if the password doesn't follow the format
            else
            {
                txtPassword.BackColor = Color.IndianRed;
                lblPasswordWarning.Visible = true;
                MessageBox.Show("Passwords must be 12 characters with 1 lowercase and uppercase letter.", "Password Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void changeUsernameTxtBx(string warning)
        {
            lblUsernameWarning.Text = warning;
            txtUsername.BackColor = Color.IndianRed;
            lblUsernameWarning.Visible = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            checkUsernameFormat();
        }

        public void checkUsernameFormat()
        {
            username = txtUsername.Text;
            // Checks if the username matches with the rules
            // pattern for username
            string uPattern = "^[a-zA-Z0-9]*$";
            Match uMatch = Regex.Match(username, uPattern);
            if (uMatch.Success)
            {
                txtUsername.BackColor = Color.White;
                lblUsernameWarning.Visible = false;
            }
            else
            {
                changeUsernameTxtBx("Username can only contain letters and numbers.");
            }
        }

        private void cmdRegister_MouseHover(object sender, EventArgs e)
        {
            cmdRegister.ForeColor = Color.Black;
        }

        private void cmdRegister_MouseLeave(object sender, EventArgs e)
        {
            cmdRegister.ForeColor = Color.White; // change text color back
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            lblPasswordWarning.Visible = false;
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            txtConfirmPassword.BackColor = Color.White;
            lblConfirmPasswordWarning.Visible = false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.cmdRegister.MouseHover += new System.EventHandler(this.cmdRegister_MouseHover);
            this.cmdRegister.MouseLeave += new System.EventHandler(this.cmdRegister_MouseLeave);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
        }

        private void chkBxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '⁕' && txtConfirmPassword.PasswordChar == '⁕')
            {
                txtPassword.PasswordChar = default(char);
                txtConfirmPassword.PasswordChar = default(char);
            }
            else
            {
                txtPassword.PasswordChar = '⁕';
                txtConfirmPassword.PasswordChar = '⁕';
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            //Application.Exit();
            stFrm.Close();
        }
    }
}
