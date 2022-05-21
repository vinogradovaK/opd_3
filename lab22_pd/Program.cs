using System;

namespace lab22
{
    public static class Program
    {
        static void Main()
        {
            Subscriber1 sub1 = new Subscriber1("User1");
            Subscriber2 sub2 = new Subscriber2("User2");
            Subscriber3 sub3 = new Subscriber3("User3");
            Subscriber3 sub4 = new Subscriber3("User4");

            Countdown countdown = new Countdown();

            countdown.subscribe(sub1);
            countdown.subscribe(sub2);
            countdown.subscribe(sub3);
            countdown.subscribe(sub4);

            Console.WriteLine("Введите время в ms: ");
            int time = Convert.ToInt32(Console.ReadLine());
            countdown.notifySubscribers(time);
        }
    }
}