using System;
using System.Collections;
using System.Collections.Generic;

namespace IndexerTestApp
{
    class MainApp

    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList list = new();  
            for (int i = 0; i < 5; i++)
            {
                list[i] = i + 1; //1~5 this[index] set값
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]); //this[index] get값
            }
            
            Console.WriteLine("Foreach가 이렇게 사용하기 힘듭니다");

            foreach (var item in list)
            {
                Console.WriteLine(item); 
            }
        }
    }
}
