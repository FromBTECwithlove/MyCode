using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Animal
{
    class Mammal: Animal
    {
        public Mammal()
        {
            Console.WriteLine();
        }
        public void Feature()
        {
            Console.WriteLine("Mammals give birth to young ones");
        }
    }
}
