using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Person : ISubscribe, IDisposable
    {
        public string Name { get; set; }

        public EventManager EventManager { get; set; }

        public Person(string name, EventManager eventManager)
        {
            Name = name;
            EventManager = eventManager;

            eventManager.Notify(EventType.Born, name);
            EventManager.Subscribe(this);
        }

        public void Update(string event_)
        {
            Console.WriteLine($"I am {Name} and i heard {event_}");
        }

        public void Dispose()
        {
            EventManager.Unsubscribe(this);
            EventManager.Notify(EventType.Dead, Name);
        }
    }
}
