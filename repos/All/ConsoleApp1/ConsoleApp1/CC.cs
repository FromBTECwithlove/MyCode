using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CC
    {
        static int Compare<K>(K first, K second)
        {
            if (first.Equals(second))
            {
                return 1;
            }
            return 0;
        }
        static void Main()
        {
            int result1 = Compare(2,2);
            int result2 = Compare("abc", "aff");
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadKey();
        }

    }
}
