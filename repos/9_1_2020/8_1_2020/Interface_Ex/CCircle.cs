using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_2020.Interface_Ex
{
    interface IAnimal
    {
        string Eat();
    }
    interface I2Animal
    {
        string Eat();
    }
    class CCircle: IAnimal, I2Animal
    {
        // explicit interface
        string IAnimal.Eat()
        {
            string Terrestrial = "Terrestrials animal eats other animal.";
            return Terrestrial;
        }
        // explicit interface
        string I2Animal.Eat()
        {
            string Marine = "Marines animal eats fish and marine aniaml.";
            return Marine;
        }
        public string eatTerrestrial()
        {
            IAnimal objTer;
            objTer = this;
            return objTer.Eat();
        }
        public string eatMarine()
        {
            I2Animal objMar;
            objMar = this;
            return objMar.Eat();
        }
        public static void Main()
        {
            // Declare an instance of class Cr
            CCircle objCr = new CCircle();
            // The method is successfully called from an interface instance.
            string ter = objCr.eatTerrestrial();
            Console.WriteLine(ter);
            string mar = objCr.eatMarine();
            Console.WriteLine(mar);
            Console.ReadLine();
        }
    }
}
