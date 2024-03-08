using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic6Test
{
    public partial class Form1 : Form
    {

        int[] nums;
        int currentIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nums = new int[10];
            currentIndex = 0;
        }

        private void cmdAddNew_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(txtNum.Text);
            if (currentIndex == nums.Length)
            {
                MessageBox.Show("You have filled the array. Press Calculate.");
                return;
            }
            nums[currentIndex] = num;
            currentIndex++;
            lblNum.Text = currentIndex + " numbers in array.";
            txtNum.Text = "";
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i< currentIndex; i++)
            {
                total += nums[i];
            }
            MessageBox.Show("The average is " + (total / currentIndex));
        }
    }
}
