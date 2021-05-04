using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    // Interface는 약속이다. ILogger를 구현(상속)하게되면 아래의 액션을 무조건(!) 구현한다.
    interface ILogger
    {
        void WriteLog(string message);  // 하나의 메시지를 받아서 처리할 것
        void WriteError(string error); // 메서드 추가 (약속 추가), WriteLog, WriteError 둘다 구현해 주어야한다.
    }
}
