using System;
using System.Collections.Generic;

namespace GenericCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반화 컬렉션 테스트");

            List<int> List = new();
            for (int i = 0; i <= 100; i++)
            {
                List.Add(i);
            }
            var sum = 0;
            foreach (var item in List)
            {
                sum += item;
            }
            Console.WriteLine($"1~100까지의 합은 {sum} 이다.");

            List.RemoveAt(1);
            List.RemoveAt(2);
            List.RemoveAt(3);
            List.Insert(1, 5213432);
            var index60 = List.IndexOf(60);
            Console.WriteLine($"60의 위치는 {index60}");
            foreach (var item in List)
            {
                Console.Write($"{item}\t");
            }

            Queue<string> Queue = new();
            Queue.Enqueue("첫번째 손님");
            Queue.Enqueue("두번째 손님");
            Queue.Enqueue("세번째 손님");
            Queue.Enqueue("네번째 손님");
            Queue.Enqueue("다섯번째 손님");

            while(Queue.Count>0)
            {
                Console.WriteLine(Queue.Dequeue());
            }


            //중요 실무에서 사용
            Dictionary<string, int> Dics = new();
            Dics["하나"] = 1;
            Dics["둘"] = 2;
            Dics["셋"] = 3;
            Dics["넷"] = 4;
            Dics["다섯"] = 5;

            Console.WriteLine(Dics["하나"]);
            Console.WriteLine (Dics["둘"]);
            Console.WriteLine(Dics["셋"]);
            Console.WriteLine(Dics["넷"]);
            Console.WriteLine(Dics["다섯"]);

            foreach (var item in Dics)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
                Console.WriteLine();
            }
        }
    }
}
