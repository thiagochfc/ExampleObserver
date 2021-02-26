using System.Collections.Generic;

namespace ExampleObserver
{
    public interface ISubject
    {
        void addObserver(IObserver observer);
        void removeObserver(IObserver observer); 
        void notifyObservers();
    }
}