using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AssignmentDraft
{
    public partial class RegisterForm : Form
    {
        // Variables Initialization
        string username = "";
        string password = "";

        private AccountList accountList;
        private LoginForm loginForm;

        // Constructor that takes an AccountList parameter
        public RegisterForm(AccountList accountList, LoginForm loginForm)
        {
            InitializeComponent();

            // Assign the passed AccountList to the local variable
            this.accountList = accountList;
            this.loginForm = loginForm;

        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            // first take the values in the textbox
            username = txtUsername.Text;
            password = txtPassword.Text;
            // checks if the username is not blank
            lblDebug1.Text = username.Length.ToString();
            if (username.Length <= 0)
            {
                changeUsernameTxtBx("\nUsername can't be left blank.");
                return;
            }
            // checks if the username matches with the format
            if (txtUsername.BackColor == Color.IndianRed)
            {
                lblDebug.Text = "Entered TT";
                return;
            }

            //if (!checkUsernameFormat())
            //{
            //    lblDebug.Text = "Entered";
            //    return;
            //};
            lblDebug1.Text = "Entered";

            // checks if the password matches with the format
            // pattern for password
            string pPattern = "^(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{12}$";
            Match pMatch = Regex.Match(password, pPattern);
            if (pMatch.Success)
            {
                MessageBox.Show("password works.");
                accountList.RegisterAccount(username, password);
                accountList.PrintAccountList();
                loginForm.Show();
                MessageBox.Show("This works.");
                this.Close();
            }
            else
            {
                MessageBox.Show("password not work.");
                txtPassword.BackColor = Color.IndianRed;
                lblPasswordWarning.Visible = true;
                return;
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
        
        // Will return true if the username is valid, not return false if it isn't
        public void checkUsernameFormat()

        //public Boolean checkUsernameFormat()
        {
            username = txtUsername.Text;
            lblDebug1.Text = txtUsername.Text;
            // checks if the username matches with the rules
            // pattern for username
            string uPattern = "^[a-zA-Z0-9]*$";
            Match uMatch = Regex.Match(username, uPattern);
            if (uMatch.Success)
            {
                //MessageBox.Show("username has only letters and numbers.");
                lblDebug.Text = "username has only letters and numbers.";
                txtUsername.BackColor = Color.White;
                lblUsernameWarning.Visible = false;
                //return true;
            }
            else
            {
                //MessageBox.Show("username has special letters.");
                lblDebug.Text = "username has special letters.";
                changeUsernameTxtBx("Username can only contain letters and numbes.");
                //return false;
            }
        }

        public void changeUsernameTxtBx(string warning)
        {
            lblUsernameWarning.Text = warning;
            txtUsername.BackColor = Color.IndianRed;
            lblUsernameWarning.Visible = true;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            lblPasswordWarning.Visible = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            checkUsernameFormat();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.cmdRegister.MouseHover += new System.EventHandler(this.cmdRegister_MouseHover);
            this.cmdRegister.MouseLeave += new System.EventHandler(this.cmdRegister_MouseLeave);
        }
    }
}
