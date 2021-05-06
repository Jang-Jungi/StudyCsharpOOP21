using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    class Derived : AbstractBase  // interface의 경우 : interface명 으로 상속?하면 interface에 빨간줄이 뜨지만 Abstract는 클래스에 빨간줄이 뜬다.
    {
        public override void AbstractMethodA()   // virtual, override 형태를 구현한다.  하지만 abstract에는 virtual을 구현하지 않음
        {
            Console.WriteLine("Derived.AbstractMethodA() 실행");
            base.ProtectedMethodA();  //base.은 생략해도 문제X  // base. --> 부모클래스를 지칭하는 키워드이다.
        }
    }
}
