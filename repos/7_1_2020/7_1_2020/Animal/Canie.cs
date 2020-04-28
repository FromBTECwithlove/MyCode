using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_2020.Animal
{
    class Canie: Animal
    {
        //base() takes a string value called  "lion"
        public Canie() : base("Lion")
        {
            Console.WriteLine("DerivedCanie");
        }
    }
}
