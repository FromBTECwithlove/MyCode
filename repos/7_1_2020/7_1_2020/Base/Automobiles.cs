using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_2020.Base
{
    class Automobiles: steelCompany
    {
        string part;
        public Automobiles(string part): base("CastIron")
        {
            this.part = part;
            Console.WriteLine("Part: "+ part);
        }
    }
}
