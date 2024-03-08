using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic7Test3
{
    internal class Person
    {
        private String name;
        private int age;

        public Person() { }

        public Person(String n, int a)
        {
            name = n;
            age = a;
        }

        public void adjustAge(int amount)
        {
            age = age + amount;
        }



        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
