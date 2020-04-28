using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_AP.Polymorphism.Overriding
{
    class Program
    { 
        public virtual void Print()
        {
            Console.WriteLine("Printing from class Program");
        }
    }
    class Execute: Program
    {
        public override void Print()
        {
            Console.WriteLine("Printing from class Execute");
        }
        static void Main()
        {
            Execute objEx = new Execute();
            objEx.Print();
            Console.ReadLine();
        }
    }
}
