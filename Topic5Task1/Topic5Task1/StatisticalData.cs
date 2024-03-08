using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic5Task1
{
    internal class StatisticalData
    {
        int num1, num2, num3;

        public StatisticalData() { }
        public StatisticalData(int n1, int n2, int n3)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;
        }

        public int findLargest()
        {
            int largest = 0;
            if (num1 > num2 && num1 > num3) 
            {
                largest = num1;
            } else if (num2 > num3 && num2 > num1) 
            {
                largest = num2;
            } else if (num3 > num1 && num3 > num2)
            {
                largest = num3;
            }
            return largest;
        }

        public int findSmallest()
        {
            int smallest = 0;
            if (num1 < num2 && num1 < num3)
            {
                smallest = num1;
            } 
            else if (num2 < num1 && num2 < num3)
            {
                smallest = num2;
            }
            else if (num3 < num1 && num3 < num2)
            {
                smallest = num3;
            }
            return smallest;
        }

        public float findAverage()
        {
            return ((num1 + num2 + num3) / 3);
        }

        public int Num1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }

        public int Num2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }

        public int Num3
        {
            get
            {
                return num3;
            }
            set
            {
                num3 = value;
            }
        }


    }
}
