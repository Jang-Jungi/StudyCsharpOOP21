using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsinginterfaceTestApp
{
    class ExtendedMonitor
    {
        private ILogger logger;  // 실무에서는 Public -> 대문자  Private -> 소문자
        
        public ExtendedMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void PrintLog(string message)
        {
            this.logger.WriteLog(message);
        }
    }
}
