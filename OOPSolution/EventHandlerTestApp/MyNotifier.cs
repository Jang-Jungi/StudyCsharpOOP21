using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTestApp
{
    delegate void EventHandler(string message); // EventHandler라는 대리자를 선언한 것이다
    class MyNotifier
    {
        public event EventHandler SomethingHappened; // event 이름이 SomethingHanppened
        public void DoSomething(int Number) 
        { 
            if (Number/10 ==3 || Number / 10 == 6 || Number / 10 == 3
                ||Number % 10 == 3|| Number % 10 == 6|| Number % 10 == 9)
            {
                SomethingHappened(string.Format($"{Number}: 짝"));
        }
            else
            {
                SomethingHappened($"{Number}\t");
            }
       
    }
    }
}