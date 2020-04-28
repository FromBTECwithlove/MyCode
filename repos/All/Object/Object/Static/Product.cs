using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Static
{
    static class Product
    {
        static int productID;
        static double price;
        static Product()
        {
            productID = 10;
            price = 156.352;
        }
        public static void Display()
        {
            Console.WriteLine("Product ID\t||\t{0} ", productID);
            Console.WriteLine("Price     \t||\t{0} ", price);
        }
    }
}
