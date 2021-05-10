using System;

namespace LambdaTestApp
{
    class Program
    {
        delegate void Dosomething();
        static void Main(string[] args)
        {
            Dosomething doIt = () =>  // delegate { };
            {
                Console.WriteLine("익명함수 람다로 표현");
            };

            doIt();

            Func<int> func1 = () => 3;

            var val = func1();
            Console.WriteLine($"var의 값은 {val}");

            //Func 대리자로 무명 함수 만들기 p.494  return 값이 있는 경우
            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3+5 = {plus(3, 5)}");

            //Action 대리자로 무명 함수 만들기  return 값이 없는 경우
            Action<float> area = (r) => { Console.WriteLine($"원의 넓이는 {r * r * Math.PI}"); };
            area(10);
        }
    }
}
