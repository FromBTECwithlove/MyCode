using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_AP.Inheritance
{
    class Animal
    {
        public void Swim()
        {
            Console.WriteLine("In the world have very many kind of animals can swim.");
        }
    }
    class Dog : Animal
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.Swim();
            Console.ReadKey();
        }
    }
}
