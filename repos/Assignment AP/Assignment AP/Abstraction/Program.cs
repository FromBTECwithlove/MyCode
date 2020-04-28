using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_AP.Abstraction
{
    abstract class Book
    {
        public virtual string Describle()
        {
            return "Description of the book";
        }
    }
    class Comic : Book
    {
        public override string Describle()
        {
           return"Description of the book is now Comic";
        }
    }
    class Program
    {
        static void Main()
        {
            Comic comic = new Comic();
            string descp= comic.Describle();
            Console.WriteLine(descp);
            Console.ReadLine();
        }
    }
}
