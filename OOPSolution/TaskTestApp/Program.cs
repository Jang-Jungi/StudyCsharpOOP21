using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTask = Task.Run(() =>
            {// Task로 비동기 처리할 내용
                Thread.Sleep(1000); // 컴퓨터의 1초는 대규모 작업으로 정의된다.
                Console.WriteLine("비동기 처리 완료");
            });
            var sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"메인스레드 동기처리 : {sum}");
            myTask.Wait(); // 비동기 호출이 완료될때까지 대기
        }
    }
}
