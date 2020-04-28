using System;

namespace demo
{
    class Count_prime
    {
        public static Boolean soNguyenTo(int n)
        {
            bool ck = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) ck = false;
            }
            if (ck) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so phan tu cua mang:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu {0} cua mang:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("So nguyen to la:");
            for (int i = 0; i < n; i++)
            {
                if (soNguyenTo(arr[i]))
                {
                    Console.Write(arr[i]);
                    Console.Write("-");
                }
            }
            Console.ReadLine();
        }
    }
}
