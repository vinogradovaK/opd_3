using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22
{
    public class Subscriber1 : IEventSubscribers
    {
        private string login;
        public Subscriber1(string login)
        {
            this.login = login;
        }

        public string Login { get { return login; } }

        public void actionForSub(string mess)
        {
            Console.WriteLine("Subscriber1(" + login + "): " + mess);
        }
    }
}
