using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06_02_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Addess, Email, Gender;
            int Phone;
            DateTime DoB;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào tên sinh viên: \t");
            Name = Console.ReadLine();
            Console.WriteLine("Nhập vào địa chỉ sinh viên: \t");
            Addess = Console.ReadLine();
            Console.WriteLine("Nhập vào Email sinh viên: \t");
            Email = Console.ReadLine();
            Console.WriteLine("Nhập vào giới tính sinh viên: \t");
            Gender = Console.ReadLine();
            Console.WriteLine("Nhập vào Sđt sinh viên: \t");
            Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào DoB sinh viên: \t");
            DoB = DateTime.Parse(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
