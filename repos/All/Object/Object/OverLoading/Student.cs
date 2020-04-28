using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.OverLoading
{
    class Student
    {
        string name;
        string Email;
        public Student()
        {
            name = "Bui Duy Huan";
            Email = "Huanbd@gmail.com";
        }
        public Student(string name, string email)
        {
            this.name = name;
            this.Email = email;
        }
        public void Display()
        {
            Console.WriteLine("Name: "+ name+"\t\t" +"Email: "+Email);
        }
        public void Display(Student obj)
        {
            Console.WriteLine("Name: " + obj.name +"\t\t"+ "Email: " + obj.Email);
        }
        public void Display(string demo)
        {

        }
    }
}
