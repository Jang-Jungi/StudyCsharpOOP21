using System;
using System.Collections;
using System.Collections.Generic;

namespace IndexerTestApp
{
    class MainAppr : IEquatable,IEnumerator

    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList mylist = new();
            for (int i = 0; i < 5; i++)
            {
                mylist[i] = i + 1; //1~5
            }

            for (int i = 0; i < mylist.Length; i++)
            {
                Console.WriteLine(mylist[i]);
            }
           
        }
    }
}
