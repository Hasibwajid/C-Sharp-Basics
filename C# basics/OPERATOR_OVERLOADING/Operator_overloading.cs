using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATOR_OVERLOADING
{
    class Operator_overloading
    {
        public int num1;
        public int num2;
        public Operator_overloading(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }


        //Func to perform operation by changing sign of integers
       
        public static Operator_overloading operator -(Operator_overloading o)
        {
            o.num1 = -o.num1;
            o.num2 = -o.num2;
            return o;
        }

        public static Operator_overloading operator + (Operator_overloading o1 , Operator_overloading o2)
        {
            Operator_overloading o3 = new Operator_overloading(0, 0);
            o3.num1 = o1.num1 + o2.num2;
            o3.num2 = o1.num2 + o2.num1;

            return o3;
        }
}


    class Enter_Point { 
        static void Main(string[] args)
        {
            Operator_overloading o1 = new Operator_overloading(15, -5);
            o1 = -o1;

            Console.WriteLine(o1.num1 + " " + o1.num2);


            Operator_overloading o2 = new Operator_overloading(20, 10);
            Operator_overloading o3 = new Operator_overloading(0, 0);


            o3 = o1 + o2;


            Console.WriteLine($"o3.num1 ({o1.num1}+{o2.num2}) is : {o3.num1} and o3.num2 ({o1.num2}+{ o2.num1}) is : {o3.num2}");


            Console.ReadKey();
        }
    }
}
