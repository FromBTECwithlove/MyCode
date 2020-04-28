using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Student
    {
        int id;
        string name;
        public Student()
        {
            id = 0;
            name = "Bui Duy Huan";
        }
        public void Display()
        {
            Console.WriteLine("Id: {0}\tname: {1}",id, name);
        }

    }
}
