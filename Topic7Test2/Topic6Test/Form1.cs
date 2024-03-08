using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Topic6Test
{
    public partial class Form1 : Form
    {
        List<int> nums;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nums = new List<int>();
        }

        private void cmdAddNew_Click(object sender, EventArgs e)
        {
            /*
            int num = Int32.Parse(txtNum.Text);
            nums.Add(num);
            lblNum.Text = nums.Count + " number in array.";
            txtNum.Text = "";
            */
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                nums.Add(r.Next(100));
            }
            String output = "";
            for (int i = 0; i < 100; i++)
            {
                // output += nums[i].ToString() + " ";
                output += nums[i] + " ";
            }
            MessageBox.Show("All number is lists \n" + output);
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            int total = 0;
            int count = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > 5 && nums[i] < 10)
                {
                    count += 1;
                }
                
                total += nums[i];
            }
            MessageBox.Show("The average is " + total / nums.Count + "\n" + count + " numbers are in Range.");
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            int highest = nums[0];
            int lowest = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                if (nums[i] < lowest)
                {
                    lowest = nums[i];
                }
            }
            MessageBox.Show("The highest is " + highest + "\n The lowest is " + lowest);
        }
    }
}
