using System;

namespace ExampleObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observer = new Observer();
            var observer1 = new Observer();
            var observer2 = new Observer();
            subject.addObserver(observer);
            subject.addObserver(observer1);
            subject.addObserver(observer2);
            subject.removeObserver(observer2);

            while (true) {
                Console.Write("Escreva algum valor: ");
                var value = int.Parse(Console.ReadLine());
                subject.id = value;
                subject.notifyObservers();
            }
        }
    }
}
