using System;

namespace GenericTestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic 사용 배열 카피");
            // 1.int 배열을 int로 복사
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // 5짜리 int 배열
                                                         // {0.0,0,0,0};으로 만들어졌을거임
            Console.WriteLine("복사 전 targetInt의 값");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray <int>(sourceInt, targetInt);
            Console.WriteLine("복사 후 targetInt의 값");

            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // 2.Float 배열을 Float으로 복사
            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];
            Console.WriteLine("복사 전 targetFloat 값");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<float>(sourceFloat, targetFloat);
            Console.WriteLine("복사 후 targetInt의 값");

            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // 3.String 배열을 String으로 복사
            String[] sourceString = { "하나", "둘", "셋", "넷", "다섯" };
            String[] targetString = new String[sourceString.Length];
            Console.WriteLine("복사 전 targetString 값");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<String>(sourceString, targetString);
            Console.WriteLine("복사 후 targetString 값");

            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        private static void CopyArray<T>(T[] source, T[] target)  // >>>>>>>>>>>>일반화 메소드 
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
