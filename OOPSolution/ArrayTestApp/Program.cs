using System;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("대성마이맥 수학점수");

            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 94;
            scores[4] = 100;
            //추가로 데이터를 추가하고 싶을 때는 용량값과, 점수값을 직접 입력해줘야한다.

            // 점수 총합
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            foreach (var item in scores) // 단순 반복문일 때는 foreach구문이 더 간단하다.
            {
                sum += item;
            }

            // 평균
            float average = (float) sum / scores.Length;
            Console.WriteLine($"수학 점수 총합은 {sum}, 평균은 {average} 입니다.");
        }
    }
}
