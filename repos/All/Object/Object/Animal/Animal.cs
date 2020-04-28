using System;

namespace Object.Animal
{
    class Animal
    {
        string name = "Animal";
        public Animal()
        {
            Console.WriteLine();
        }
        public void Eat()
        {
            Console.WriteLine("All {0} eats something", name);
        }
    }
}
