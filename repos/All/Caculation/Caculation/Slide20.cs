using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Caculation
{
    class Slide20
    {
        static void ImmediatExecution()
        {
            int[] numbers = {10,20,30,40,50,60,70,1,2,3,4,5,6,7,8,9 };
            int[] subsetAsIntArray = (from i in numbers where i < 10 select i).ToArray<int>();

            List<int> subsetAsListOfInts = (from i in numbers where i < 10 select i).ToList<int>();

        }
        public static void Main(string [] args0)
        {
            Console.WriteLine("I'm Lion");
            ImmediatExecution();
            Console.ReadLine();
        }
    }
}
