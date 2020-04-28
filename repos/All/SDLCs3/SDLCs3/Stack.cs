using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCs3
{
    class Stack
    {
        public static void Main(string[] args)
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { firstName = "Balloon", lastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { firstName = "Lava", lastName = "Simpson", Age = 35 });
            stackOfPeople.Push(new Person { firstName = "Hong", lastName = "Simpson", Age = 10 });
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Pop ped off; {0}", stackOfPeople.Pop());
            Console.WriteLine("\n\n First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Pop ped off; {0}", stackOfPeople.Pop());
            Console.WriteLine("\n\n First person items is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Pop ped off; {0}", stackOfPeople.Pop());
            try
            {
                Console.WriteLine("\n First person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off; {0}", stackOfPeople.Pop());
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("\n----------Error!! {0}---------", ex.Message);
            }
        }
    }
}
