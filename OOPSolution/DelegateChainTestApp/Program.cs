using System;

namespace DelegateChainTestApp
{
    class Program
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {

            Calculate calc;
            //무명 함수를 표현하는 방법
            //calc = (int a, int b) => a + b; 람다식으로 간단하게 표현
            calc = delegate (int a, int b)  {return a + b;};  

            Console.WriteLine($"a+b={calc(3,5)}"); // 익명 메소드 

            FireStation fireStation = new FireStation();
            ThereIsFire fireHouse = new ThereIsFire(fireStation.Call119);
            fireHouse += new ThereIsFire(fireStation.ShoutOut);
            fireHouse += new ThereIsFire(fireStation.Escape);
            // 대리자 실행
            fireHouse("우리집");
            Console.WriteLine("\n 대리자를 사용하면 원하는 것만 call할 수 있지롱\n");
            ThereIsFire fireWoorim = new ThereIsFire(fireStation.Call119);
            fireWoorim += new ThereIsFire(fireStation.Escape);
            fireWoorim("우림라인온스밸리");
        }
    }
}
