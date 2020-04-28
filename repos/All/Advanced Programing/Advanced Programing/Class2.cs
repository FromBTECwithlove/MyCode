using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Programing
{
    class Class2
    {
        public static Boolean songuyento(int n)
        {
            bool check = true;
            for (int i = 2; i < n; i++)
                if (n % i == 0) check = false;
            if (check) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            {

                Console.Write("Moi Ban Nhap vao N =");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] mang = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Phan tu thu {0}: ", i + 1);
                    mang[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("So nguyen to la : ");
                for (int i = 0; i < n; i++)
                {
                    if (songuyento(mang[i])) Console.Write(mang[i]);
                    Console.Write(" ");
                }
            }
            Console.ReadLine();
        }
    }
}
