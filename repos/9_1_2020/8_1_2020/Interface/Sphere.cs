using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_2020.Interface
{
    interface IMath
    {
        void Area();
    }
    class Circle : IMath
    {
        public const float PI = 3.14F;
        protected float Radius;
        protected double AreaOfCircle;
        public virtual void Area()
        {
            AreaOfCircle = (PI * Radius * Radius);
        }
    }
    class Sphere: Circle
    {
        double areaOfSphere;
        public override void Area()
        {
            base.Area();
            areaOfSphere = (AreaOfCircle* 4);
        }
        static void Main()
        {
            Sphere Sp = new Sphere();
            Sp.Radius = 7;
            Sp.Area();
            Console.WriteLine("Area of Sphere: {0:F2}", Sp.areaOfSphere);
            Console.ReadLine();
        }
    }
}
