using System;

namespace GenericTestApp
{
    class Program
    {
        static void Main(string[] args)
        { // 1.int 배열을 int로 복사
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int [ sourceInt.Length ]; // 5짜리 int 배열
                                                            // {0.0,0,0,0};으로 만들어졌을거임
            Console.WriteLine("복사 전 targetInt의 값");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourceInt, targetInt);
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

            CopyArray(sourceFloat, targetFloat);
            Console.WriteLine("복사 후 targetInt의 값");

            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // 3.String 배열을 String으로 복사
            String[] sourceString = { "하나", "둘", "셋", "넷", "다섯}" };
            String[] targetString = new String[sourceString.Length];
            Console.WriteLine("복사 전 targetString 값");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourceString, targetString);
            Console.WriteLine("복사 후 targetString 값");

            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        private static void CopyArray(string[] source, string[] target) // 모양이 똑같은데 타입이 다르다고 또 만들어야함  long, double, 등등등등..... 모양이 똑같음--->>>>>>일반화 Parameter의 등장
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    

        private static void CopyArray(float[] source, float[] target)  
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
