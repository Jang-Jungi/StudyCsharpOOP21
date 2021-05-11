using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            //1. 일반적 방식
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {i}");
            }
            TimeSpan procTime = DateTime.Now - startTime;
            Console.WriteLine($"처리에 걸린 시간은 {procTime.TotalSeconds}");
            Console.ReadLine();


            //2. Parallel(병렬처리) 처리속도가 빨라진다.
            DateTime pStartTime = DateTime.Now;
            Parallel.For(0, 10000, (i) => {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
            });
            TimeSpan pProcTime = DateTime.Now - pStartTime;
            Console.WriteLine($"{pProcTime.TotalSeconds}");
            Console.ReadLine();
        }
    }
}
