using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_2020.Abstract_Animal
{
    abstract class Animal
    {
        public void Swim()
        {
            Console.WriteLine("In the world have very many kind of animals can swim");
        }
        public abstract void AnimalSound();
    }
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            base.Swim();
            Console.WriteLine("Dog's barking");
        }
        static void Main()
        {
            Dog dog = new Dog();
            dog.AnimalSound();
            Console.ReadLine();
        }
    }
}
