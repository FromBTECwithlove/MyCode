﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_2020.Behavioral.Observer
{
    abstract class Observer

    {
        public abstract void Update();
    }
    abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
    }
    class ConcreteSubject : Subject

    {
        private string subjectState;

        // Gets or sets subject state

        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
    class ConcreteObserver : Observer

    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        // Constructor

        public ConcreteObserver(
          ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",
              name, observerState);
        }

        // Gets or sets subject

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
    class MainOb
    {
        static void Main()
        {
            // Configure Observer pattern

            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers

            s.SubjectState = "ABC";
            s.Notify();

            // Wait for user

            Console.ReadKey();
        }
    }
}
