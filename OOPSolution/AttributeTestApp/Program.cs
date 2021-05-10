using System;

namespace AttributeTestApp
{
    public class MyClass
    {
        //Properties
        [Obsolete("이 메서드는 폐기되었습니다. NewMethod를 이용하세요.")]
        public void OldMethod() { Console.WriteLine("뭔가를 한다."); }
        public void NewMethod() { Console.WriteLine("새로운 뭔가를 한다."); }

        public int Plus(int a, int b) { return a + b; }
        public int Divide(int a, int b) { return a / b; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass mine = new MyClass();
            //mine.OldMethod();
            mine.NewMethod();

            //실제로 어떻게 사용되는지 알려주신답니다
            var result = mine.Plus(3, 5);
            Console.WriteLine(result);

        }
    }
}
