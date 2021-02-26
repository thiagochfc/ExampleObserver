using System;

namespace ExampleObserver
{
    public class Observer : IObserver
    {
        public void update(int value)
        {
            Console.WriteLine($"Valor informado é: {value}!");
        }
    }
}