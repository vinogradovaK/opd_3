using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22
{
    public class Subscriber3 : IEventSubscribers
    {
        private string login;
        public Subscriber3(string login)
        {
            this.login = login;
        }

        public string Login { get { return login; } }

        public void actionForSub(string mess)
        {
            Console.WriteLine("Subscriber3(" + login + "): " + mess);
        }
    }
}
