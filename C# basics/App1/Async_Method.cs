using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace App1
{
    class Async_Method
    {
        static  void Main(String[] arg)
        {
            AsyncMethod();

            Console.ReadKey();
        }
        //THIS IS ASYNC METHOD
        private static async  void AsyncMethod()
        {         
            Task<DateTime> task_A = Task.Run(() => Helper());
            Console.WriteLine("I am Responding while task_A is progressing..");
            //BECAUSE TASK_A is running in another thread
            await task_A.ContinueWith(antecedent => Console.WriteLine($"Today is {antecedent.Result}."));
        }
        private static DateTime Helper()
        {          
            Thread.Sleep(10000);
            return DateTime.Now;
        }
    }
}
