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
        private void cmdUserGuide_Click(object sender, EventArgs e)
        {
            if (lblUserGuide.Visible)
            {
                lblUserGuide.Visible = false;
            }
            else
            {
                lblUserGuide.Visible = true;
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
            // average MET values of the activities, according to the internet
            double metWalk = 5;
            double metSwim = 6;
            double metBicycle = 8;
            double metTennis = 7;
            double metBasketball = 8;
            double metWrestling = 6;

            double wStep, wDistance, wTime;
            double sLap, sHeart, sTime;
            double bHeart, bTime, bDistance;
            double tHeart, tTime, tNumOfServes;
            double basketballHeart, basketballTime, basketballNumOfShots;
            double wrestleHeart, wrestleTimeTaken, wrestleTakedown;

            if (chkBxWalking.Checked)
            {
                if (txtWalkingSteps.Text == "")
                {
                    if (txtWalkingDistance.Text == "")
                    {
                        if (txtWalkingTimeTaken.Text == "")
                        {
                            MessageBox.Show("Please enter at least one metric in walking");
                            return;
                        }
                        else
                        {
                            wTime = double.Parse(txtWalkingTimeTaken.Text);
                            result = calorieBurnCalculate(bodyWeight, metWalk) * wTime;
                            total += result;
                            lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                        }
                    }
                    else
                    {
                        wDistance = Double.Parse(txtWalkingDistance.Text);
                        result = calorieBurnCalculate(bodyWeight, metWalk) * (wDistance / 96);
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }
                else
                {
                    wStep = Double.Parse(txtWalkingSteps.Text);
                    result = calorieBurnCalculate(bodyWeight, metWalk) * (wStep / 101);
                    total += result;
                    lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                }
            }

            if (chkBxSwimming.Checked)
            {
                if (txtSwimmingHeartRate.Text == "")
                {
                    if (txtSwimmingNumOfLap.Text == "")
                    {
                        if (txtSwimmingTimeTaken.Text == "")
                        {
                            MessageBox.Show("Please enter at least one information in swimming");
                            return;
                        }
                        else
                        {
                            sTime = Double.Parse(txtSwimmingTimeTaken.Text);
                            result = calorieBurnCalculate(bodyWeight, metSwim) * sTime;
                            total += result;
                            lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                        }
                    }
                    else
                    {
                        sLap = Double.Parse(txtSwimmingNumOfLap.Text);
                        result = calorieBurnCalculate(bodyWeight, metSwim) * sLap;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
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
                        sHeart = Double.Parse(txtSwimmingHeartRate.Text);
                        sTime = Double.Parse(txtSwimmingTimeTaken.Text);
                        result = calorieBurnCalculate(bodyWeight, metSwim) * (sHeart / 82);
                        result = result * sTime;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }
            }

            if (chkBxBicycling.Checked)
            {
                if (txtBicyclingHeartRate.Text == "")
                {
                    if (txtBicyclingTimeTaken.Text == "")
                    {
                        if (txtBicycleDistance.Text == "")
                        {
                            MessageBox.Show("Please enter at least one information in bicycling");
                            return;
                        }
                        else
                        {
                            bDistance = Double.Parse(txtBicycleDistance.Text);
                            result = calorieBurnCalculate(bodyWeight, metBicycle) * (bDistance / 120); // 120 is number of distance reached by bicycling in general based on internet results
                            total += result;
                            lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                        }
                    }
                    else
                    {
                        bTime = Double.Parse(txtBicyclingTimeTaken.Text);
                        result = calorieBurnCalculate(bodyWeight, metBicycle) * bTime;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }
                else
                {
                    if (txtBicyclingTimeTaken.Text == "")
                    {
                        MessageBox.Show(" You must enter the Time for to calculate the heart-rate for the Bicycling");
                    }
                    else
                    {
                        bHeart = Double.Parse(txtBicyclingHeartRate.Text);
                        bTime = Double.Parse(txtBicyclingTimeTaken.Text);
                        result = calorieBurnCalculate(bodyWeight, metBicycle) * (bHeart / 100); // 100 is num of heart beat reached in a minute in general based on internet results
                        result = result * bTime;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }

            }

            if (chkBxTennis.Checked)
            {
                if (txtTennisHeartRate.Text == "")
                {
                    if (txtTennisTime.Text == "")
                    {
                        if (txtBxTennisNumOfServes.Text == "")
                        {
                            MessageBox.Show("Please enter at least one information in tennis.");
                            return;
                        }
                        else
                        {
                            tNumOfServes = Double.Parse(txtBxTennisNumOfServes.Text);
                            result = calorieBurnCalculate(bodyWeight, metTennis) * (tNumOfServes / 100); // 100 is num of serves doable in a minute in general based on internet results
                            total += result;
                            lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                        }
                    }
                    else
                    {
                        tTime = Double.Parse(txtTennisTime.Text);
                        result = calorieBurnCalculate(bodyWeight, metTennis) * tTime;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }
                else
                {
                    if (txtTennisTime.Text == "")
                    {
                        MessageBox.Show(" You must enter the Time for to calculate the heart-rate for the Tennis");
                    }
                    else
                    {
                        tHeart = Double.Parse(txtTennisHeartRate.Text);
                        tTime = Double.Parse(txtTennisTime.Text);
                        result = calorieBurnCalculate(bodyWeight, metTennis) * (tHeart / 99); // 99 is num of heart beats reached in a minute during playing tennis in general based on internet results
                        result = result * tTime;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }

            }

            if (chkBxBasketball.Checked)
            {
                if (txtBxBasketballHeartRate.Text == "")
                {
                    if (txtBxBasketballTimeTaken.Text == "")
                    {
                        if (txtBxBasketballNumOfShots.Text == "")
                        {
                            MessageBox.Show("Please enter at least one information in Basketball.");
                        }
                        else
                        {
                            basketballNumOfShots = Double.Parse(txtBxBasketballNumOfShots.Text);
                            result = calorieBurnCalculate(bodyWeight, metBasketball) * (basketballNumOfShots / 115); // 115 is the num of shots made in a basketball match in a minute in general based on internet results
                            total += result;
                            lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                        }
                    }
                    else
                    {
                        basketballTime = Double.Parse(txtBxBasketballTimeTaken.Text);
                        result = calorieBurnCalculate(bodyWeight, metBasketball) * basketballTime;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }
                else
                {
                    if (txtBxBasketballTimeTaken.Text == "")
                    {
                        MessageBox.Show(" You must enter the Time for to calculate the heart-rate for the Basketball");
                    }
                    else
                    {
                        basketballHeart = Double.Parse(txtBxBasketballHeartRate.Text);
                        basketballTime = Double.Parse(txtBxBasketballTimeTaken.Text);
                        result = calorieBurnCalculate(bodyWeight, metBasketball) * (basketballHeart / 113); // 113 is the heart beats reached in a minute during basketball in general based on internet results
                        result = result * basketballTime;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }

            }

            if (chkBxWrestling.Checked)
            {
                if (txtBxWrestlingHeartRate.Text == "")
                {
                    if (txtBxWrestlingTimeTaken.Text == "")
                    {
                        if (txtBxWrestlingNumOfTakeDown.Text == "")
                        {
                            MessageBox.Show("Please enter at least one information in wrestling.");
                        }
                        else
                        {
                            wrestleTakedown = Double.Parse(txtBxWrestlingNumOfTakeDown.Text);
                            result = calorieBurnCalculate(bodyWeight, metWrestling) * (wrestleTakedown / 120); // 120 is the num of takedown doable in a minute in a wrestle in general based on internet results
                            total += result;
                            lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                        }
                    }
                    else
                    {
                        wrestleTimeTaken = Double.Parse(txtBxWrestlingTimeTaken.Text);
                        result = calorieBurnCalculate(bodyWeight, metWrestling) * wrestleTimeTaken;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }
                else
                {
                    if (txtBxWrestlingTimeTaken.Text == "")
                    {
                        MessageBox.Show(" You must enter the Time for to calculate the heart-rate for the Wrestling");
                    }
                    else
                    {
                        wrestleHeart = Double.Parse(txtBxWrestlingHeartRate.Text);
                        wrestleTimeTaken = Double.Parse(txtBxWrestlingTimeTaken.Text);
                        result = calorieBurnCalculate(bodyWeight, metWrestling) * (wrestleHeart / 136); // 136 is the heart beat made in a minute in wrestling  in general based on internet results
                        result = result * wrestleTimeTaken;
                        total += result;
                        lblResult.Text = "You reach " + total.ToString("#.00") + " Calories";
                    }
                }
            }

            if (total >= target)
            {
                lblResult.Text += "\nYou have reached your target. ";
            }
        }

    }
}
