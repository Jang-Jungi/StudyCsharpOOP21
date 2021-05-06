using System;
using System.Collections;

namespace QueueTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            #region 숨긴영역
            Console.WriteLine("Queue 테스트");
            
            Queue queue = new();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue("안녕");

            while (queue.Count>0)
            {
                Console.Write(queue.Dequeue()+"\t");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Stack 테스트");

            Stack stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push("안녕");


            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + "\t");
            }
            Console.WriteLine();

            #endregion

            Console.WriteLine("Hashtable 테스트");
            Hashtable dictionary = new();
            dictionary["book"] = "책";
            dictionary["cook"] = "요리사";
            dictionary["tweet"] = "지저귀다";
            dictionary["whale"] = "고래";
            dictionary[1] = "똥개";
            dictionary[2] = "멍청이";
            dictionary[3] = "바보";

            Console.WriteLine(dictionary["tweet"]);
            Console.WriteLine(dictionary[3]);
            

        }
    }
}
