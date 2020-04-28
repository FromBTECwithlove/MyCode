using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_AP.Abstraction
{
    class ExecuteAnimal
    {
        public static void Main(string[] args)
        {
            Animal pig = new Pig();
            Pig pig1 =new Pig();
            Dog dog = new Dog();
            pig.AnimalSound();
            pig.Eat();
            dog.AnimalSound();
            dog.Eat();
            pig.Run();
            pig1.Run();
            dog.Run();
            Console.ReadLine();
        }
    }
}
