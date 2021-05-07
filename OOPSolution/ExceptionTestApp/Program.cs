using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("예외 발생");
            int[] array = new int[5];
            try
            {
                for (int i = 0; i <= 5; i++)  // 흔한 예시
                {
                    array[i] = (i + 1); //1,2,3,4,5
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error-{ ex.Message} 관리자에게 문의하세요 : Main(15~)");
            }
            Console.WriteLine("다른 로직 수행");

            // ....

            int[] list = { 107, 108, 109 };

            try
            {
                string message = null;
                Console.WriteLine(message.Length);
                    var result = list[1] / 10;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            /*catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : { ex.Message}");
                // IndexOutOfRangeException 예외시 다른 일 처리
                Console.WriteLine($"IndexOutOfRangeException 이후 처리!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : { ex.Message}");
                Console.WriteLine($"DivideByZeroException 이후 처리!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : { ex.Message}");
                Console.WriteLine($"NullReferenceException 이후 처리!");
                Console.WriteLine($"제대로 값을 입력하세요(진지함)");
            }*/
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : { ex.Message}");  // 모든 예외사항 포함
            }
            finally
            {
                Console.WriteLine("Finally, 언제든지 실행됨");

            }

            Console.WriteLine("프로그램 종료");
        }
    }
}
