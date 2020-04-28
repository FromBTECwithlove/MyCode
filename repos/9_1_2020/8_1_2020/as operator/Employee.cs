using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_2020.as_operator
{
    interface ISet
    {
        void AcceptDetails(int valOne, string valTwo);
    }
    interface IGet
    {
        void Display();
    }
    class Employee: ISet
    {
        int empID;
        string empName;
        public void AcceptDetails(int valOne, string valTwo)
        {
            this.empID = valOne;
            this.empName = valTwo;
        }
        static void Main()
        {
            Employee emp = new Employee();
            emp.AcceptDetails(100,"Pico");
            IGet objGet = emp as IGet;
            if (objGet == null)
            {
                Console.WriteLine("Invalid casting occured");
            }
            else
            {
                objGet.Display();
            }
            Console.ReadLine();
        }
    }
}
