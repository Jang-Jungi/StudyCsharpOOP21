using System;
using System.Threading.Tasks;

namespace AsyncTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Caller();
            Console.ReadLine();
        }

        private static void Caller()
        {
            Console.WriteLine("Caller A");
            Console.WriteLine("Caller B");
            MyMethodAsync(3);  // 비동기 처리

            Console.WriteLine("Caller E");
            Console.WriteLine("Caller F");

        }

        private async static void MyMethodAsync(int count)
        {
            Console.WriteLine("My C");
            Console.WriteLine("My D");

            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{i}/{count}...");
                    await Task.Delay(100);
                }
            });
            
            Console.WriteLine("My G");
            Console.WriteLine("My H");
        }
    }
}
