using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    abstract class AbstractBase  // class 앞에  abstract를 선언한다.
    {
        protected void ProtectedMethodA()
        {
            Console.WriteLine("AbstactBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstactBase.PublicMethodA()");
        }
        public abstract void AbstractMethodA(); // 인터페이스 선언과 동일하다.
    }
}
