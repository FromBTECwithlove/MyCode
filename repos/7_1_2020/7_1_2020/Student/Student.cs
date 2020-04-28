using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_2020.Student
{
    class Student
    {
        string studentName = "Bui Duy Huan";
        string address = "Viet Nam";
        public virtual void PrintDetails()
        {
            Console.WriteLine("Name of this student is: "+ studentName+ "\n"+ "Address of this student is: "+ address);
        }
    }
    class Grade: Student
    {
        string classes ="Ten";
        float percent = 15.25F;
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Class: "+ classes+"\n"+ "Percentage: "+ percent);
        }
    }
}
