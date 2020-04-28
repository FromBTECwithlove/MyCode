using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.OverLoading
{
    class Program
    {
        static void Main()
        {
            Student std1 = new Student();
            Student std2 = new Student("Truong Van Tinh", "Tinhtvbhaf180186@gmail.com");
            std1.Display();
            std2.Display(std2);
            Console.ReadLine();
        }
    }
}
