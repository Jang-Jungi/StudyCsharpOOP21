﻿using System;

namespace EventHandlerTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EventHandler 책은 476페이지!");
            Console.WriteLine("3,6,9 3,6,9");

            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);
            for (int i = 1; i < 100; i++)
            {
                notifier.DoSomething(i);
            }
        }

        private static void MyHandler(string message)
        {
            Console.Write($"{message}\t") ;
        }
    }
}
