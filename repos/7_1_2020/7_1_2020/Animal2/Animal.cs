using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_2020.Animal2
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
        protected void DoSomething()
        {
            Console.WriteLine("Every animal dose something");
        }
    }
    class cat: Animal
    {
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Cat loves to eat the mouse");
        }
        static void Main()
        {
            cat objC = new cat();
            objC.Eat();
            Console.ReadLine();
        }
    }
}
