using System;
using System.Threading;

namespace ThreadLockTestApp
{
    class Counter
    {
        public int counter = 1000;
        private object thisLock = new object();
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread th = new Thread(unsafeCalc);
                th.Start();
            }
        }
        public void unsafeCalc()
        {
            lock (thisLock)  // lock을 통해서 동기화, 다른 스레드가 접근하지 못하도록
            {
                counter++;
                Thread.Sleep(1);
                Console.WriteLine(counter);
            }
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter();
            Thread th1 = new Thread(count.Run);
            Thread th2 = new Thread(count.Run);

            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();

            Console.WriteLine(count.counter);
        }
    }
}
