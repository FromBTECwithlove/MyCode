using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.OptionalParameterExample
{
    class OptionalParameterExample
    {
        void printMessage(string message = "Bui Duy Huan")
        {
            Console.Write("{0}", message);
        }
        static void Main()
        {
            OptionalParameterExample opExample = new OptionalParameterExample();
            opExample.printMessage("Welcome User: \t");
            opExample.printMessage();
            Console.ReadKey();
        }
    }
}
