using System;

namespace GT
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, giai_thua = 1, n;

            Console.Write("\n");
            Console.Write("Tim giai thua trong C#:\n");
            Console.Write("------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                giai_thua = giai_thua * i;
            }
            Console.Write("Giai thua cua {0} la: {1}\n", n, giai_thua);
            Console.ReadKey();
        }
    }
}
