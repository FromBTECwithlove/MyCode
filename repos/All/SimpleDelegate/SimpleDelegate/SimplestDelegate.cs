using System;

namespace SimpleDelegate
{
        public delegate int BinaryOP(int x, int y);
    class SimpleMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Substract(int x, int y)
        {
            return x - y;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*Simple delegate example*");
            BinaryOP op = new BinaryOP(SimpleMath.Add);
            Console.WriteLine("10+10={0}", op (10,10));
        }
    }
}
