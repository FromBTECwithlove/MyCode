using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_2020.Animal
{
    class Animal
    {
        string abc;
        public Animal()
        {
            Console.Write("Animal constructor without parameters\n");
        }
        public Animal(string name)
        {
            this.abc = name;
            Console.WriteLine("Animal constructor with a string parameters:{0} ", abc);
        }
    }
}
