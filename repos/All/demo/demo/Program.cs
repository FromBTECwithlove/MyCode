using System;
namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiem tra so nguyen to");
            int n;
            int bd = 0;
            Console.Write("Nhap vao n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    bd++;
            }
            if (bd == 1)
                Console.WriteLine("Day la so nguyen to");
            else
                Console.WriteLine("Day khong phai so nguyen to");
            Console.ReadKey();
        }
    }
}
