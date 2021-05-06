using System;

namespace AbstractClassTestApp
{
    class MainApp //p315 이것이 C#이다.
    {
        static void Main(string[] args)
        {
            //AbstractBase obj = new AbstractBase(); abstract는 new 불가

            AbstractBase obj = new Derived(); // 부모는 자식을 품을 수 있다.
            obj.PublicMethodA(); // AbstractBase의 publicMethodA 실행 
            obj.AbstractMethodA(); // 자식클래스 Derived 도 실행되고 부모 클래스의 AbstractBase ProtectedMethod도 실행된다.
        }
    }
}
