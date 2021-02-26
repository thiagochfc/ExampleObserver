using System;
using System.Collections.Generic;

namespace ExampleObserver
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> Observers;
        public int id { get; set; }

        public Subject()
        {
            Observers = new List<IObserver>();
        }

        public void addObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (var obserser in Observers)
            {
                obserser.update(id);
            }
        }
    }
}