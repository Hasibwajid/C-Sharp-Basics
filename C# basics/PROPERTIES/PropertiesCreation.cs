//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PROPERTIES
//{
//    class PropertiesCreation
//    {
//        private String pname;
//        private int pid;

//        public String Name //Property
//        {
//            set
//            {
//                pname = value; //set method
//            }
//            get
//            {
//                return pname; //get method
//            }
//        }

//        public int Id
//        {
//            set
//            {
//                pid = value;
//            }
//            get
//            {
//                return pid;
//            }
//        }
//    }

//        class program2 { 

//        static void Main(string[] args)
//        {
//            PropertiesCreation p = new PropertiesCreation();
//            Console.WriteLine("Enter name: ");
//            p.Name = Console.ReadLine(); //access and assign val to private field pname
            
//            Console.WriteLine("Enter id: ");
//            p.Id = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine($"Name is : {p.Name}"); //get private field pname

//            Console.WriteLine($"Id is {p.Id}");
            
//            Console.ReadKey();
//        }
//    }
//}
