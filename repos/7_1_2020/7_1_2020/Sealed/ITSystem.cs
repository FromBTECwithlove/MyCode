using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_2020.Sealed
{
    class ITSystem
    {
        public virtual void Print()
        {
            Console.WriteLine("The system should be handled carefully");
        }

    }
    class CompanySystem: ITSystem
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("The System information is confidential");
            Console.WriteLine("This information should not be overriden");
        }
    }
    class SealedSystem : CompanySystem
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("This Statement won't get executed");
        }
        static void Main()
        {
            SealedSystem ss = new SealedSystem();
            ss.Print();
            Console.ReadLine();
        }
    }
}
