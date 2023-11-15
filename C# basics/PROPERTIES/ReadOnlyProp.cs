//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PROPERTIES
//{
//    class ReadOnlyProp
//    {
//        private int readOnly;
//        private int writeOnly;

//        public int ReadOnly
//        {
//            get
//            {
//                return 2; // can only return _not set accessor
//            }
//        }


//        public int WriteOnly
//        {
//            set
//            {
//                writeOnly = value;
//            }
//        }
//    }


//    class ROP
//    {
//        public static void Main(String[] args)
//        {
//            ReadOnlyProp rop = new ReadOnlyProp();
//            // rop.A = 4;  this will show error bcz read only
//            Console.WriteLine(rop.ReadOnly);

//            rop.WriteOnly = 45;

//            //Console.WriteLine(rop.WriteOnly); // will show error, cann't be get cz write only
//        }

//    }
//}
