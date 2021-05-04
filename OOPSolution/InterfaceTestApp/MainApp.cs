using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("콘솔로거 사용합니다!");

            ILogger logger = new ConsoleLogger();  // ILogger 인터페이스를 쓰는 이유는 1가지로 간단하게 하여 쉽게 다른 변수들을 통제하기 위함
            logger.WriteLog("기본 콘솔 로거입니다.");
            logger.WriteError("에러메세지!!!!!");

            ILogger logger2 = new ClimateLogger();
            logger2.WriteLog("흐림//");
            //logger2.WriteError("!!!!");  구현을 안했으니 이상한거 나오징

            ILogger clmLogger = new ClimateLogger();  // ILogger로 사용했기 때문에 ClimateLogger-> FileLogger로 바꾸면 바로 바꿀 수 있다.
            clmLogger.WriteLog("맑음");               // ver 1.0 ClimateLogger --> 1.2 FileLogger 변경
            clmLogger.WriteError("문제발생");

        }
    }
}
