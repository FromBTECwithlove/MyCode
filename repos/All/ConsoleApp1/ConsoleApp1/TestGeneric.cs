using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestGeneric<T>
    {
        T value;
        public TestGeneric(T t)
        {
            value = t;
        }
        public void write()
        {
            Console.WriteLine(value);
        }
    }
    class testGeneric
    {
        static void Main()
        {
            TestGeneric<int> test1 = new TestGeneric<int>(100);
            test1.write();
            TestGeneric<string> test2 = new TestGeneric<string>("I'm TinhTV");
            test2.write();
            Console.Read();
        }
    }
}
