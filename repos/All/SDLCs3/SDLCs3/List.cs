using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCs3
{
    class List
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person{ firstName="Balloon", lastName="Simpson", Age=47},
                new Person{ firstName="Lava", lastName="Simpson", Age=35},
                new Person{ firstName="Hong", lastName="Simpson", Age=10},
                new Person{ firstName="Valkyrie", lastName="Simpson", Age=22}
            };
            Console.WriteLine("Items in list: {0}", people.Count);
            foreach (Person p in people)
            {
                Console.Write(p + "\n");
                Console.WriteLine("\t ==> Inserting new person...");
                people.Insert(2, new Person { firstName = "Mganga", lastName = "simpson", Age = 5 });
                Console.WriteLine("Items in list {0}", people.Count);
                Person[] arrayOfPeople = people.ToArray();
                for (int i = 0; i < arrayOfPeople.Length; i++)
                {
                    Console.WriteLine("First Name: {0}", arrayOfPeople[i].firstName);
                }
            }
        }
    }
}
