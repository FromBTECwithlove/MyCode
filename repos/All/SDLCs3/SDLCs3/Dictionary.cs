using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCs3
{
    class Dictionary
    {
        public static void Main (string[] args)
        {
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Balloon", new Person {firstName="Balloon", lastName="Simpson", Age=47 });
            peopleA.Add("Lava", new Person { firstName = "Lava", lastName = "Simpson", Age = 35 });
            peopleA.Add("Hong", new Person { firstName = "Hong", lastName = "Simpson", Age = 10 });
            Person Balloon = peopleA["Balloon"];
            Console.WriteLine(Balloon);
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                { "Balloon", new Person {firstName="Balloon", lastName="Simpson", Age=47 } },
                { "Lava", new Person { firstName = "Lava", lastName = "Simpson", Age = 35 } },
                { "Hong", new Person { firstName = "Hong", lastName = "Simpson", Age = 10 } }
            };
            Person lisa = peopleB["Hong"];
            Console.WriteLine(lisa);
        }
 
    }
    
}
