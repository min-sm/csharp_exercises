using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic4Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdClick_Click(object sender, EventArgs e)
        {
            int input;
            input = Int32.Parse(txtInput.Text);
            string ans = "";

            // Task 4 (long)
            /*
            int counter = 1;
            for (int i = 0; i < input; i++)
            {   
                for (int j = 0; j < counter; j++)
                {
                    ans += "*";
                }
                ans += "\n";
                counter++;
            }
            */

            // Task 4
            /*
            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    ans += "*";
                }
                ans += "\n";
            }
            */

            // Task 5
            /*
            for (int i = 1; i <= input - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    ans += "*";
                }
                ans += "\n";
            }
            
            for (int i = 0; i < input; i++)
            {
                ans += "*";
            }
            
            for (int i = input - 1; i > 0; i--)
            {
                ans += "\n";

                for (int j = 0; j < i; j++)
                {
                    ans += "*";
                }
            }
            */


            // Task 1
            /**/
            int total = 0;
            for (int i = 1; i <= input; i++)
            {
                total += i;
            }
            /*
            for (int i = input; i > 0; i--)
            {
                total += i;
            }
            */
            ans = total.ToString();
            
            lblDisplay.Text = ans;
        }
    }
}
