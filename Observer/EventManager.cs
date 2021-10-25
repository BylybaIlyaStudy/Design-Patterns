using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class EventManager
    {
        private HashSet<ISubscribe> subscribers = new();

        public void Subscribe(ISubscribe subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscribe subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void Notify(EventType event_, string name)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update($"{name} was {event_}");
            }
        }
    }
}
