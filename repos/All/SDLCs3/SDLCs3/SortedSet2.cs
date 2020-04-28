using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCs3
{
    class SortedSet2
    {
        public static void Main(string[] args)
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
        {
            new Person {firstName="Balloon", lastName="Simpson", Age=47},
            new Person {firstName="Lava", lastName="Simpson", Age=35},
            new Person {firstName="Hong", lastName="Simpson", Age=10},
            new Person {firstName="Valkyrie", lastName="Simpson", Age=22}
        };
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            }
            setOfPeople.Add(new Person { firstName = "King", lastName = "Babarian", Age = 26 });
            setOfPeople.Add(new Person { firstName = "Queen", lastName = "Super", Age = 50 });
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }
    }
}
