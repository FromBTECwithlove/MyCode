using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCs3
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public Person()
        {
        }
        public Person(string FirstName, string LastName, int age)
        {
            firstName =FirstName ;
            lastName =LastName ;
            Age = age;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}, {2}", firstName, lastName, Age);
        }
    }
}
