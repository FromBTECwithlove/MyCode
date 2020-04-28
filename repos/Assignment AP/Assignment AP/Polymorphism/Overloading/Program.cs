using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_AP.Polymorphism.Overloading
{
    class Program
    {
        void Print(int x, int y)
        {
            //Print sum of (x + y)
            Console.WriteLine("Print int: {0}",(x+y));
        }
        void Print(string x, string y)
        {
            //Print a string
            Console.WriteLine("Print string: {0}", (x+y));
        }
        static void Main()
        {
            Program objPrg = new Program();
            //Call print for sum of intergers;
            objPrg.Print(25, 75);

            //Call to concatenate strings
            objPrg.Print("Hello ","World");
            Console.ReadKey();
        }
    }
}
