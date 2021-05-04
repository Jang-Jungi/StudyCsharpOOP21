using System;

namespace UsinginterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var monitor1 = new ExtendedMonitor(new ConsoleLogger(DateTime.Now));
            monitor1.PrintLog("콘솔로그입니다!");

            var monitor = new ExtendedMonitor(new FileLogger("210504.log"));
            monitor.PrintLog("로그내용입니다!");

            System.Threading.Thread.Sleep(5000); // 시간 딜레이

            monitor.PrintLog("이하 오류가 발생했습니다.");

            Console.WriteLine("프로그램 종료");

        }
    }
}
