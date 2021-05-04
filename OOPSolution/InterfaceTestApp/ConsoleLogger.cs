using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"에러 : {error}"); 
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"로그 {DateTime.Now} : {message}");
        }
    }
}
