using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Programing
{
    class Class1
    {
        public static void Main()
        {
            Console.WriteLine("*==============================*");
            Console.WriteLine("*Kiem tra so nguyen to trong c#*");
            Console.WriteLine("*==============================*");
            int bien_dem = 0;
            int n;
            Console.WriteLine("Nhap vao so nguyen n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (n % i == 0)
                {
                    bien_dem++;
                }
                else if (bien_dem == 2)
                {
                    Console.WriteLine("So vua nhap la so nguyen to");
                }
                else
                {
                    Console.WriteLine("So vua nhap khong phai la so nguyen to");
                }
                Console.ReadKey();
            }
        }
    }
}
