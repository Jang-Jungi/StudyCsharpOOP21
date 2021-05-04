using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class ClimateLogger : ILogger
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException(); // climate에서는 Writelog 안쓸거야 --> 이상태로 놔두면 된다. 약속을 꼭 지켜야한다.!!!!
        }

        public void WriteLog(string weather) // message=weather why?-- 컴퓨터는 string 타입만 인지하기 때문에 message가 아니어도 된다.
        {
            Console.WriteLine($"날씨로그 [{DateTime.Now.ToShortDateString()}] : 현재날씨 {weather}");
        }
    }
}
