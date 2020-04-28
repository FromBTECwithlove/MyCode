using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Calculate
{
    class Methods
    {
        static void Main()
        {
            Calculate.Addition(1, 98);
            Calculate objCal = new Calculate();
            objCal.Multiply(10, 100);
            Console.ReadKey();
        }
    }
}
