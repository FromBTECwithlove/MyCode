using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caculation
{
    class Slide15Main
    {
        static void QueryOverInts()
        {
            int[] numbers = {10,20,30,40,1,2,3,8 };
            var subset = from i in numbers where i < 10 select i;
            foreach (var i in subset)
            {
                Console.WriteLine("TINHTV: {0}",i);
            }        
        }
        public static void Main(string [] args)
        {
            Console.WriteLine("We're a team");
            QueryOverInts();
            Console.ReadLine();
        }
    }
}
