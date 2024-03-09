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
    public partial class MainForm : Form
    {
        AccountList accountList;
        int currentIndex;
        Account acc;
        public MainForm()
        {
            InitializeComponent();
        }

        // To delete 
        public MainForm(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        public MainForm(AccountList accountList, int currentIndex)
        {
            InitializeComponent();
            this.accountList = accountList;
            acc = this.accountList.returnSelectedAccountObj(currentIndex);
            this.currentIndex = currentIndex;
        }

        double bodyWeight, target, result, total;

        private Double calorieBurnCalculate(double weight, double metVal)
        {
            double calorieBurn;
            calorieBurn = (metVal * weight * 3.5) / 200;
            return calorieBurn;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            lblWelcome.Text = "Welcome, " + acc.FirstName;
            lblTargetCalories.Text = "Your target calories: " + acc.TargetCalories;
            lblYourWeight.Text = "Your weight: " + acc.BodyWeight;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void chkBxWalking_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxWalking.Checked)
            {
                gpBxWalking.Visible = true;
            }
            else
            {
                gpBxWalking.Visible = false;
            }
        }

        private void chkBxSwimming_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxSwimming.Checked)
            {
                gpBxSwimming.Visible = true;
            }
            else
            {
                gpBxSwimming.Visible = false;
            }
        }

        private void chkBxBicycling_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxBicycling.Visible)
            {
                gpBxBicycle.Visible = true;
            }
            else
            {
                gpBxBicycle.Visible = false;
            }
        }

        private void chkBxTennis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxTennis.Checked)
            {
                gpBxTennis.Visible = true;
            }
            else
            {
                gpBxTennis.Visible = false;
            }
        }



        private void chkBxBasketball_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxBasketball.Checked)
            {
                gpBxBasketball.Visible = true;
            }
            else
            {
                gpBxBasketball.Visible = false;
            }
        }

        private void chkBxWrestling_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxWrestling.Checked)
            {
                gpBxWrestling.Visible = true;
            }
            else
            {
                gpBxWrestling.Visible = false;
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            string bodyWeightText = txtNewWeight.Text;
            string targetCaloriesText = txtNewTargetCalories.Text;

            // Check if any of the text boxes is blank
            if (string.IsNullOrWhiteSpace(bodyWeightText) || string.IsNullOrWhiteSpace(targetCaloriesText))
            {
                MessageBox.Show("Please fill in all the required fields.", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the function if any text box is blank
            }
            float bodyWeight;
            try
            {
                bodyWeight = float.Parse(bodyWeightText);
                if (bodyWeight < 0)
                {
                    MessageBox.Show("Please enter a non-negative number");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for body weight.");
                return;
            }

            float targetCalories;
            try
            {
                targetCalories = float.Parse(targetCaloriesText);
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

            accountList.updateBodyWeightAndTargetChange(currentIndex, bodyWeight, targetCalories);
            MainForm_Load(sender, e);
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            total = 0;
            bodyWeight = acc.BodyWeight;
            target = acc.TargetCalories;
            double Wstep, Wdistance, Wtime;
            double Slap, Sheart, Stime;

            if (chkBxWalking.Checked == true)
            {
                if (txtWalkingSteps.Text == "")
                {
                    if (txtWalkingDistance.Text == "")
                    {
                        if (txtWalkingTimeTaken.Text == "")
                        {
                            MessageBox.Show("Please enter a least one information");
                        }
                        else
                        {
                            Wtime = double.Parse(txtWalkingTimeTaken.Text);
                            result = calorieBurnCalculate(bodyWeight, 5) * Wtime;
                            total += result;
                            lblResult.Text = "You reach" + total.ToString("#.00") + "Calories";
                        }
                    }
                    else
                    {
                        Wdistance = Double.Parse(txtWalkingDistance.Text);
                        result = calorieBurnCalculate(bodyWeight, 5) * (Wdistance / 96);
                        total += result;
                        lblResult.Text = "You reach" + total.ToString("#.00") + "Calories";
                    }
                }
                else
                {
                    Wstep = Double.Parse(txtWalkingSteps.Text);
                    result = calorieBurnCalculate(bodyWeight, 5) * (Wstep / 101);
                    total += result;
                    lblResult.Text = "You reach" + total.ToString("#.00") + "Calories";
                }
            }

            if (chkBxSwimming.Checked == true)
            {
                if (txtSwimmingHeartRate.Text == "")
                {
                    if (txtSwimmingNumOfLap.Text == "")
                    {
                        if (txtSwimmingTimeTaken.Text == "")
                        {
                            MessageBox.Show("Please enter a least one information");
                        }
                        else
                        {
                            Stime = Double.Parse(txtSwimmingTimeTaken.Text);
                            result = calorieBurnCalculate(bodyWeight, 6) * Stime;
                            total += result;
                            lblResult.Text = "You reach" + total.ToString("#.00") + "Calories";
                        }
                    }
                    else
                    {
                        Slap = Double.Parse(txtSwimmingNumOfLap.Text);
                        result = calorieBurnCalculate(bodyWeight, 6) * Slap;
                        total += result;
                        lblResult.Text = "You reach" + total.ToString("#.00") + "Calories";
                    }
                }
                else
                {
                    if (txtSwimmingTimeTaken.Text == "")
                    {
                        MessageBox.Show(" You must enter the Time for to calculate the heart-rate for the Swimming");
                    }
                    else
                    {
                        Sheart = Double.Parse(txtSwimmingHeartRate.Text);
                        Stime = Double.Parse(txtSwimmingTimeTaken.Text);
                        result = calorieBurnCalculate(bodyWeight, 6) * (Sheart / 82);
                        result = result * Stime;
                        total += result;
                        lblResult.Text = "You reach" + total.ToString("#.00") + "Calories";
                    }
                }
            }

            
        }

    }
}