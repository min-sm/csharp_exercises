using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic6Task
{
    public partial class FrmCashMachine : Form
    {

        String enterText;
        Boolean inputPermitted;
        Account acc1, acc2, acc3, acc4;
        Account current;
        Boolean receipt, withdrawing;

        public FrmCashMachine()
        {
            InitializeComponent();
        }

        private void updateDisplay()
        {
            txtText.Text = enterText;
        }

        private Account findAccount(String p)
        {
            if (acc1.checkPIN(p))
            {
                return acc1;
            }
            if (acc2.checkPIN(p))
            {
                return acc2;
            }
            if (acc3.checkPIN(p))
            {
                return acc3;
            }
            if (acc4.checkPIN(p))
            {
                return acc4;
            }
            return null;
        }

        private void FrmCashMachine_Load(object sender, EventArgs e)
        {
            enterText = "";
            inputPermitted = true;
            acc1 = new Account("1234", 10000);
            acc2 = new Account("4321", 55000);
            acc3 = new Account("5555", 200000);
            acc4 = new Account("9966", 150000);
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "1";
            updateDisplay();
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "2";
            updateDisplay();
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "3";
            updateDisplay();
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "4";
            updateDisplay();
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "5";
            updateDisplay();
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "6";
            updateDisplay();
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "7";
            updateDisplay();

        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "8";
            updateDisplay();
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "9";
            updateDisplay();
        }

        private void cmdReceipt_Click(object sender, EventArgs e)
        {
            if (current == null)
            {
                lblOutput.Text = "Enter PIN";
                return;
            }

            lblOutput.Text = "Enter amount";
            inputPermitted = true;
            withdrawing = true;
            receipt = true;
        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            Boolean ret;
            if (current == null)
            {
                current = findAccount(enterText);
            }

            if (current != null)
            {
                if (withdrawing)
                {
                    ret = current.withdraw(Int32.Parse(enterText));
                    if (ret == true)
                    {
                        lblOutput.Text = "Transaction successful";
                        if (receipt)
                        {
                            lblOutput.Text = lblOutput.Text + "\nLast Transaction: " + current.getLastTransaction();
                        }
                    }
                    else
                    {
                        lblOutput.Text = "Insufficient funds.";
                    }
                    enterText = "";
                    withdrawing = false;
                    inputPermitted = false;
                }
                else
                {
                    lblOutput.Text = "Logged in - choose transaction";
                    enterText = "";
                }
            }
            else
            {
                lblOutput.Text = "Invalid PIN";
                enterText = "";
                inputPermitted = true;
                updateDisplay();
            }
        }

        private void cmdDeny_Click(object sender, EventArgs e)
        {
            enterText = "";
            withdrawing = false;
            if (current != null)
            {
                lblOutput.Text = "Choose transaction ";
            }
            else
            {
                lblOutput.Text = "Enter PIN";
            }

        }

        private void cmdWithdrawl_Click(object sender, EventArgs e)
        {
            if (current == null)
            {
                lblOutput.Text = "Enter PIN";
                return;
            }
            lblOutput.Text = "Enter amount";
            inputPermitted = true;
            withdrawing = true;
            receipt = true;
        }

        private void cmdC_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = "";
            updateDisplay();
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enterText = enterText + "0";
            updateDisplay();
        }

        private void cmdBalance_Click(object sender, EventArgs e)
        {
            // String pin = txtText.Text;
            // Account whichOne;
            // whichOne = findAccount(pin);
            // lblDisplay.Text = whichOne.getBalance().ToString();

            if (current != null)
            {
                lblOutput.Text = "Balance is " + current.getBalance();
            }
            else
            {
                current = findAccount(enterText);
                lblOutput.Text = "Balance is " + current.getBalance();
            }
        }
    }
}
