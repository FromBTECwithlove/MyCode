using System;
using System.Collections.Generic;
using System.Text;

namespace Caculation
{
    class MainClass
    {
        static void QueryOverStringLongHand()
        {
            string[] currentVideoGames = { "1", "2", "3", "4", "5" };
            string[] gamesWithSpaces = new string[5];
            for (int i = 0; i < currentVideoGames.Length; i++)
            {
                if (currentVideoGames[i].Contains(""))
                {
                    gamesWithSpaces[i] = currentVideoGames[i];
                }
            }
            Array.Sort(gamesWithSpaces);
            foreach (string s in gamesWithSpaces)
            {
                if (s!=null)
                {
                    Console.WriteLine("Item: {0}",s);
                }
                Console.WriteLine("hiii^^");
            }
        }
        public static void Main(string [] args)
            {
            Console.WriteLine("Welcome to with LinQ-----------");
            QueryOverStringLongHand();
            Console.ReadLine();
            }
    }
}
