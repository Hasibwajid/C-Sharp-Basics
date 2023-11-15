using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    class indexercreation
    {
        private int[] arr;

        public indexercreation(int size)
        {
            this.arr = new int[size];
        }
        

        public int this[int index]
        {
            set
            {
                arr[index] = value;
            }
            get
            {
                return arr[index];
            }
        }

    }


    class another
    {
        static void Main(string[] args)
        {
            indexercreation p = new indexercreation(5);

            //p[0] = 2;
            //console.writeline($"value at 0 : {p[0]}");


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"enter at {i}: ");
                p[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("entered");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(p[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
