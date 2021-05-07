using System;

namespace DelegateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate는 대리자");
            // 일반적 호출
            Calculator calc = new();
            Console.WriteLine($"3+5={calc.Plus(3, 5)}"); //일반적인 형식의 계산기 사용법 Delegate 사용 X
            // 값을 전달받아 계산, 간단하게 나타낼 수 있지만 정적.

            //대리자 호출
            CalcDelegate callback;
            callback = new CalcDelegate(calc.Plus);
            Console.WriteLine($"3+5={callback(3, 5)}");
            Console.WriteLine(callback(3423, 4213));

            callback = new CalcDelegate(calc.Multiple);
            Console.WriteLine($"3*5={callback(3, 5)}");
            Console.WriteLine(callback(23, 42));
        }
    }
}

