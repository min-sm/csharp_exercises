using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic3._4Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String getGrade(int mark)
        {
            String grade = "";
            if (mark > 70)
            {
                // MessageBox.Show("A", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grade = "A";
            }
            else if (mark > 60 && mark <= 70)
            {
                // MessageBox.Show("B", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grade = "B";
            }
            else if (mark > 50 && mark <= 60)
            {
                // MessageBox.Show("C", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grade = "C";
            }
            else if (mark > 40 && mark <= 50)
            {
                // MessageBox.Show("D", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grade = "D";
            }
            else if (mark > 30 && mark <= 40)
            {
                // MessageBox.Show("E", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grade = "E";
            }
            else
            {
                // MessageBox.Show("F", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grade = "F";
            }

            return grade;
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            int input;
            input = Int32.Parse(txtBx.Text);

            int input1;
            input1 = Int32.Parse(txtBx1.Text);

            int input2;
            input2 = Int32.Parse(txtBx2.Text);

            int highestMark = 0;

            String m1 = "", m2 = "", m3 = "";
            if (input < 0 || input > 100 || input1 < 0 || input1 > 100 || input2 < 0 || input2 > 100)
            {
                MessageBox.Show("The number you entered is more than 100 or less than 0", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  
                /*
                if (input > 70)
                {
                    // MessageBox.Show("A", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m1 = "A";
                }
                else if (input > 60 && input <= 70)
                {
                    // MessageBox.Show("B", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m1 = "B";
                }
                else if (input > 50 && input <= 60)
                {
                    // MessageBox.Show("C", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m1 = "C";
                }
                else if (input > 40 && input <= 50)
                {
                    // MessageBox.Show("D", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m1 = "D";
                }
                else if (input > 30 && input <= 40)
                {
                    // MessageBox.Show("E", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m1 = "E";
                }
                else 
                {
                    // MessageBox.Show("F", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m1 = "F";
                }
                */
                m1 = getGrade(input);

                /*
                if (input1 > 70)
                {
                    // MessageBox.Show("A", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m2 = "A";
                }
                else if (input1 > 60 && input1 <= 70)
                {
                    // MessageBox.Show("B", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m2 = "B";
                }
                else if (input1 > 50 && input1 <= 60)
                {
                    // MessageBox.Show("C", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m2 = "C";
                }
                else if (input1 > 40 && input1 <= 50)
                {
                    // MessageBox.Show("D", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m2 = "D";
                }
                else if (input1 > 30 && input1 <= 40)
                {
                    // MessageBox.Show("E", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m2 = "E";
                }
                else
                {
                    // MessageBox.Show("F", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m2 = "F";
                }


                */
                m2 = getGrade(input1);

                /*
                if (input2 > 70)
                {
                    // MessageBox.Show("A", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m3 = "A";
                }
                else if (input2 > 60 && input2 <= 70)
                {
                    // MessageBox.Show("B", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m3 = "B";
                }
                else if (input2 > 50 && input2 <= 60)
                {
                    // MessageBox.Show("C", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m3 = "C";
                }
                else if (input2 > 40 && input2 <= 50)
                {
                    // MessageBox.Show("D", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m3 = "D";
                }
                else if (input2 > 30 && input2 <= 40)
                {
                    // MessageBox.Show("E", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m3 = "E";
                }
                else
                {
                    // MessageBox.Show("F", "Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m3 = "F";
                }
                */
                m3 = getGrade(input2);

                if (input > input1 && input > input2)
                {
                    highestMark = input;
                } else if (input1 > input && input1 > input2)
                {
                    highestMark = input1;
                } else if (input2 > input && input2 > input1)
                {
                    highestMark = input2;
                }

                lblHighestMark.Text = "Highest Mark is " + highestMark;
                lblSub1Mark.Text = "Subject 1 Mark is " + m1;
                lblSub2Mark.Text = "Subject 2 Mark is " + m2;
                lblSub3Mark.Text = "Subject 3 Mark is " + m3;
            }


        }
    }
}
