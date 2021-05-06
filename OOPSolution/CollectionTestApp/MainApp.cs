using System;
using System.Collections;

namespace CollectionTestApp // p 381
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 123;
            object obj = a; // 박싱 obj로 포장한다.
            int b = (int)obj; // 언박싱 int라고 지칭한다.

            Console.WriteLine($"a의 값" + a);
            Console.WriteLine($"obj의 값" + obj);
            Console.WriteLine($"b의 값" + b);

            Console.WriteLine();

            String str = "문자열임";
            obj = str;
            Console.WriteLine($"str의 값 :" + str);
            Console.WriteLine($"obj의 값 :" + obj);
            Console.WriteLine();



            Console.WriteLine("ArrayList 예제.\n"); // ArrayList는 용량을 지정하지 않아도 된다. 추가는 Add 메소드, 삭제는 Removeat 메소드, 끼어들기는 Insert 메소드를 사용한다.

            ArrayList list = new ArrayList(); // 추가하고 싶을 때 Resize가 필요없음
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add("여기냐?\t");
            list.Add(6);
            list.Add(7);
            list.Add(3.141592);

            //list.Sort();  sorting,reverse를 하기 위해서는 자료들이 전부 같은 타입이어야한다.

            foreach (var item in list)  // item의 형식이 object이다. 객체지향에서 가장 최상위 조상 클래스가 object이다.
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.RemoveAt(4); // [5]의 object를 제거한다.

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();


            list.Insert(4, "여기다"); // index[4]에 "" 값을 추가한다.
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");

            int index3 = list.IndexOf(3); // 3이라는 숫자의  index 위치를 알 수 있다.
            Console.WriteLine($"3의 위치 : { index3}");
            Console.WriteLine();

            list.Remove(5); // 5라는 숫자를 제거
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(1);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index1 = list.IndexOf(1); // 중복되는 값의 첫번째 인덱스 위치를 알려준다.
            Console.WriteLine($"1의 위치 : {index1}");

            int LastIndex1 = list.LastIndexOf(1); // 중복되는 값의 마지막 인덱스 위치를 알려준다.
            Console.WriteLine($"마지막 1의 위치 : {LastIndex1}\n");

            Console.WriteLine($"인덱스 총 갯수는 : { list.Count }");           
            Console.WriteLine($"리스트 마지막값 : { list[list.Count -1]}");

        }
    }
}
