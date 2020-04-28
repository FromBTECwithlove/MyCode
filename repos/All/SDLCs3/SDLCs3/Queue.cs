using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCs3
{
    class Queue
    {
        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.firstName);
        }
        public static void Main(string[] args)
        {
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { firstName = "Balloon", lastName = "Simpson", Age = 47 });

            peopleQ.Enqueue(new Person { firstName = "Lava", lastName = "Simpson", Age = 35 });

            peopleQ.Enqueue(new Person { firstName = "Hong", lastName = "Simpson", Age = 10 });
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().firstName);
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch(InvalidOperationException e) {
                Console.WriteLine("Error! {0}", e.Message);
            }
            Console.ReadLine();
        }
    }
}
