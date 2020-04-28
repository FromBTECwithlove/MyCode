using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_2020.Interface_interface
{
    interface IAnimal
    {
        void Drink();
    }
    interface ICarni
    {
        void Eat();
    }
    interface IReptile : IAnimal, ICarni
    {
        void Habit();
    }
    class Crocodile: IReptile
    {
        public void Drink()
        {
            Console.WriteLine("Drinks fresh water");
        }
        public void Habit()
        {
            Console.WriteLine("Can stay in water and Land.");
        }
        public void Eat()
        {
            Console.WriteLine("Eats Flesh");
        }
        static void Main()
        {
            Crocodile objCor = new Crocodile();
            Console.WriteLine(objCor.GetType().Name);
            objCor.Eat();
            objCor.Drink();
            objCor.Habit();
            Console.ReadLine();
        }
    }
}
