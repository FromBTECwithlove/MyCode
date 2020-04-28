using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_2020.Interface_Animal
{
    interface IAnimal
    {
        void Habit();
    }
    class Dog : IAnimal
    {
        public void Habit()
        {
            Console.WriteLine("Can be hourse with human beings");
        }
        static void Main()
        {
            Dog objDog = new Dog();
            Console.Write(objDog.GetType().Name + ":\t");
            objDog.Habit();
            Console.ReadLine();
        }
    }
}
