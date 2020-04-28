using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Book
{
    class kk
    {
        static void Main()
        {
            Book book = new Book();
            int choice;
            Console.WriteLine("===Menu of Book===");
            Console.WriteLine("1.Add new book");
            Console.WriteLine("2.Display all book");
            Console.WriteLine("3.Edit book");
            Console.WriteLine("4.Delete one book");
            Console.WriteLine("5.Search book by name");
            Console.WriteLine("6.Print book by name");
            Console.WriteLine("7.Exit");
            Console.Write("Enter your choice here:\t");
            choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    default:
                        break;
                }
            } while (choice);
        }
    }
}
