using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsinginterfaceTestApp
{
    class ConsoleLogger : ILogger
    {
        public DateTime currentDate { get; set; }
     
        public ConsoleLogger(DateTime currentDate) // Alt Enter를 치면 생성자가 바로 나오넹...ㅇㅅㅇ??
        {
            this.currentDate = currentDate;
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"콘솔로그 : {this.currentDate} ---> {message}");
        }
    }
}
