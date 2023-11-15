using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPERTIES
{
    class ValidationProp
    {
        private int voter_age;
        

        public int Voter_Age
        {
            set
            {
                if(value >= 18)
                {
                    voter_age = value;
                    Console.WriteLine($"as you're {voter_age} year old , you're eligible");
                }
                else
                {
                    Console.WriteLine($"as you're {voter_age} year old , you're Not - Eligible For Vote");
                }
            }

            get
            {
                return voter_age;
            }
        }
    }


    class Voter
    {

        public static void Main(String [] args)
        {
            ValidationProp v = new ValidationProp();
            Console.WriteLine("Enter your age: ");
            v.Voter_Age = Convert.ToInt32(Console.ReadLine()); // setting age

            Console.WriteLine($"Your age is {v.Voter_Age}"); //getting age


            Console.ReadKey();
        }
    }
}
