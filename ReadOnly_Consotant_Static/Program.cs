using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly_Consotant_Static
{
    class Program
    {
        readonly int Readonly;
        const int Constant = 10;
        static int Static=5;
        int Integer = 15;
        public static void Example(){
            //Constant++;
         //  Static= 5;
            Static++;
            Console.WriteLine(Static);
        }
        static void Main(string[] args)
        {
           Example();
           Example();
           Example();
            
            Console.ReadKey();
        }
    }
}
