using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            Person person1 = new Person("Tom", eventManager);
            Person person2 = new Person("Tim", eventManager);
            person1.Dispose();
            person2.Dispose();
        }
    }
}
