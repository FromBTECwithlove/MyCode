using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _11_02_2020.Creational.Singleton
{
    class Singleton
    {
        private String state = "Initial state";
        private volatile static Singleton instance = null;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                Mutex mutex = new Mutex();
                mutex.WaitOne();

                if (instance == null)
                {
                    instance = new Singleton();

                    mutex.Close();
                }
            }
            return instance;
        }
        public void printState()
        {
            //
        }
        public void nextState()
        {
            switch (state)
            {
                case "Initial state": state = "second state"; break;
                case "second state": state = "third state"; break;
                case "third state": state = "Initial state"; break;
                default: break;
            }
        }
    }
}
namespace clients
{
    using _11_02_2020.Creational.Singleton;
    class singletonClients
    {
        public static void Main()
        {
            Singleton theSingleton = Singleton.GetInstance();
            theSingleton.printState(); //1    1
            theSingleton.nextState();
            theSingleton.printState(); //2    2

            Singleton anotherSingleton = Singleton.GetInstance();
            anotherSingleton.printState();//2   1
            theSingleton.printState();    //2   2
            anotherSingleton.nextState();
            anotherSingleton.printState();//3   2
            theSingleton.printState();    //3   2
            Console.ReadKey();
        }
    }
}
