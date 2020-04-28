using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_2020.Base
{
    class Metals
    {
        string MetalType;
        public Metals(string type)
        {
            this.MetalType = type;
            Console.WriteLine("Metal: "+ MetalType);
        }
    }
}
