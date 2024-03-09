using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class ProfileSetUpForm : Form
    {
        AccountList accountList;
        int accIndex;
        string firstName;
        string lastName;
        string bodyWeightText;
        string targetCaloriesText;
        StartingForm stFrm;
        public ProfileSetUpForm()
        {
            InitializeComponent();
        }

        public ProfileSetUpForm(AccountList passedAccList, int passedAccIndex, StartingForm stFrm)
        {
            InitializeComponent();
            accountList = passedAccList;
            accIndex = passedAccIndex;
            this.stFrm = stFrm;
        }

        private void cmdContinue_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            bodyWeightText = txtBodyWeight.Text;
            targetCaloriesText = txtTargetCalories.Text;

            // Check if any of the text boxes is blank
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(bodyWeightText) || string.IsNullOrWhiteSpace(targetCaloriesText))
            {
                MessageBox.Show("Please fill in all the required fields.", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the function if any text box is blank
            }
            double bodyWeight;
            try
            {
                bodyWeight = double.Parse(bodyWeightText);
                if (bodyWeight < 0)
                {
                    MessageBox.Show("Please enter a non-negative number", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for body weight.");
                return;
            }

            double targetCalories;
            try
            {
                targetCalories = double.Parse(targetCaloriesText);
                if (targetCalories < 0)
                {
                    MessageBox.Show("Please enter a non-negative number");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for tager calories.");
                return;
            }

            accountList.profileSetup(firstName, lastName, bodyWeight, targetCalories, accIndex);
            accountList.changingToNotFirstTime(accIndex);
            this.Close();
            MainForm mf = new MainForm(accountList, accIndex);
            mf.Show();
        }


        private void ProfileSetUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            //Application.Exit();
            stFrm.Close();
        }
    }
}
