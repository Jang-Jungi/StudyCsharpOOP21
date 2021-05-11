using System;
using System.Threading;

namespace ThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 아래와는 상관없이 여기 순서에 따라서 출력된다. sth->other
            //DoSomething();
            Thread th1 = new Thread(new ThreadStart(DoSomething)); // 대리자 만들때와 비슷 메서드이름을 대입, new Thread(DoSomething)  --> 요렇게 생략 가능
            th1.Start();                                           // thread를 만들고 나면 other->sth으로 출력된다.
            //th1.Interrupt(); // 얘도 안씀
            //th1.Join(); // 스레드 종료 대기 생략가능 잘 안씀
            //th1.Abort();// 더이상 사용안함
            DoOtherthing();
        }

        private static void DoOtherthing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherthing : {i}");
                Thread.Sleep(10);  // 10ms 대기
                
            }
        }

        private static void DoSomething()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"Dosomething : {i}");
                Thread.Sleep(10);
            }
        }
    }
}
