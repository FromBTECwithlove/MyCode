using System;
using System.Collections;
using System.Text;

namespace SDLCs3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });
            Console.WriteLine("This collections has {0} items.", strArray.Count);
            Console.Write("\n");
            strArray.Add("Four");
            Console.WriteLine("This collections has {0} items.", strArray.Count);
            foreach (string s in strArray)
            {
                Console.Write("Entry: {0}", s, "\n");
            }
            Console.WriteLine("\n\n");
        }
    }
}
