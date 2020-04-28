using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Caculation
{
    class Slide18Mains
    {
        static void QueryOverInts()
        {
            int[] numbers = {1000,100,10,1,50,3,79,2,6,11};
            var subset = from i in numbers where i > 10 select i;
            Console.WriteLine("Evaluate+++++++++");
            foreach (var i in subset)
            {
                Console.WriteLine("{0}>10",i,"\n");
                Console.WriteLine("------------");
            }
            Console.WriteLine("Change some data");
            numbers[0] = 99;
            Console.WriteLine("Evaluate again, without having to run this query");
            foreach (var j in subset)
            {
                Console.WriteLine("{0}>10", j, "\n");
                Console.WriteLine("-----------------");
            } ;

        }
        public static void Main(string []args)
        {
            Console.WriteLine("Truong Van T?nh++++");
            QueryOverInts();
            Console.ReadLine();
        }
    }
}
