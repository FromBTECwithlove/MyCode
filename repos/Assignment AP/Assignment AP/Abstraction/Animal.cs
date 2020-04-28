using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_AP.Abstraction
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public virtual void Eat()
        {
            Console.WriteLine("All animals eat");
        }
        public void Run()
        {
            Console.WriteLine("Every animals can run");
        }
    }
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Pig: uninuninuninunin");
        }
        public override void Eat()
        {
            Console.WriteLine("Pigs eat bran");
        }
    }
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog is barkingggg");
        }
    }
     
}
