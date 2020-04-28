using System;
using System.Linq;
using System.Collections.Generic;

namespace linqOverArray
{
    class MainClass
    {
        static void QueryOverString()
        {
            string[] currentVideoGames = { "TinhTaoTau", "HuanBD", "DatLV", "Daxter", "System Shock2" };
            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Contains("")
                                         orderby g
                                         select g;
            foreach (string s in subset)
                Console.WriteLine("Item: {0}",s);
        }
        public static void Main(string [] args)
        {
            Console.WriteLine("--Fun with LinQ--");
            QueryOverString();
            Console.ReadLine();
        }
    }
}
