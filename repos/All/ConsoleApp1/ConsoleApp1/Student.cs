using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public class Huan
        {
            private string name;
            private string gender;
            public Huan()
            {
                this.name = "HuanBD";
                this.gender = "Male";
            }
            public Huan(string name, string gender)
            {
                this.name = name;
                this.gender = gender;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Gender
            {
                get { return gender; }
                set { gender = value; }
            }
            public void Operation()
            {
                Console.WriteLine("{0} said: TAO HUAN SKY, kHONG DAN EM THANG NAO, MOT MINH TAO CHAP HET", name);
            }
            public void display()
            {
                Operation();
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            string hNname;
            string hOperation;
            Console.Write("Enter the first name's here, pls: \t");
            hNname = Console.ReadLine();
            Console.Write("Enter the last name's here, pls:  \t");
            hOperation = Console.ReadLine();

            Huan firstHuan = new Huan(hNname,hOperation);
            Huan secondHuan = new Huan();
            Console.Write("Enter the second name's here, pls: \t");
            hNname = Console.ReadLine();
            Console.Write("Enter the second name's here, pls: \t");
            hOperation = Console.ReadLine();

            secondHuan.Name = hNname;
            secondHuan.Name = hOperation;
            Console.Write("Full name is: ",hNname, hOperation);
            Console.ReadKey();
        }
    }
}
