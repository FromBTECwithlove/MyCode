using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_2020.is_Operator
{
    interface ICalculate
    {
        double Area();
    }
    class Retangle: ICalculate
    {
        float Length;
        float breadth;
        public Retangle(float valOne, float valTwo)
        {
            this.Length = valOne;
            this.breadth = valTwo;
        }
        public double Area()
        {
            return Length * breadth;
        }
        static void Main()
        {
            Retangle retangle = new Retangle(10.2F, 20.3F);
            if (retangle is ICalculate)
            {
                Console.WriteLine("Area of retangle: {0:F2}", retangle.Area());
            }
            else
            {
                Console.WriteLine("Interface method is not implement");
            }
            Console.ReadLine();
        }
    }
}
