using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab22
{
    public class Countdown
    {
        private List<IEventSubscribers> subscribers;

        public Countdown()
        {
            subscribers = new List<IEventSubscribers>();
        }

        public List<IEventSubscribers> Subscribers
        {
            
            get {return subscribers; }
        }

        public void subscribe(IEventSubscribers subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void unsubscribe(IEventSubscribers subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void notifySubscribers(int time)
        {
            foreach (IEventSubscribers subscriber in subscribers)
            {
                Thread.Sleep(time);
                Console.WriteLine(time.ToString() + " ms");
                subscriber.actionForSub("Message");
            }
        }

         
    }


}
