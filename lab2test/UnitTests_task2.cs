using NUnit.Framework;

namespace lab22
{
    public class UnitTests_task2
    {
        [Test]
        public void Subscriber1Login()
        {
            Subscriber1 subscriber = new Subscriber1("Katya");
            string login = subscriber.Login;

            string res = "Katya";

            Assert.AreEqual(res, login);
        }

        [Test]
        public void Subscribe2Login()
        {
            Subscriber2 subscriber = new Subscriber2("Katya");
            string login = subscriber.Login;

            string res = "Katya";

            Assert.AreEqual(res, login);
        }

        [Test]
        public void Subscriber3Login()
        {
            Subscriber3 subscriber = new Subscriber3("Katya");
            string login = subscriber.Login;

            string res = "Katya";

            Assert.AreEqual(res, login);
        }
    }
}
