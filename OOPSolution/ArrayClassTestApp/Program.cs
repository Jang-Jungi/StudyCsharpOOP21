using System;

namespace ArrayClassTestApp //p.365
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Class 사용");

            int[] array = new int[] {5,7,3,1,9,10,4,8,2,6 };

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Array.Sort(array); // sort -> 오름차순 정렬

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            
            Array.Reverse(array); // Reverse -> 내림차순 정렬

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index7 = Array.IndexOf(array,7);  // 배열 중에 7의 위치를 찾기
            Console.WriteLine($"7의 위치는 {index7}");

            Array.Resize<int>(ref array,11); // 11번째 수를 추가하기
            array[10] = 100;

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");

            //P.372 2차원 배열
            int[,] array1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(0); j++)
                {
                    Console.Write($"[{i},{j}] : {array1[i,j]}\t\n");
                }
                Console.WriteLine();
            }

        }
    }
}
