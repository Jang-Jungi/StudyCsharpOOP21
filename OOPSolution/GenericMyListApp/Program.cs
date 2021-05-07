using System;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1;
            }
           
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"{list[i]}\t");
            }
           
            MyList<string> strlist = new();
          
            for(int i = 0; i < strlist.Length; i++)
            {
                strlist[i] = "hello"+(i + 1);
            }

            for (int i = 0; i < strlist.Length; i++)
            {
                Console.WriteLine($"{strlist[i]}\t");
            }

            MyList<object> objlist = new();
            objlist[0] = 213;
            objlist[1] = 2.13f;
            objlist[2] = "이일삼";

            for (int i = 0; i < objlist.Length; i++)
            {
                Console.WriteLine($"{objlist[i]}\t");
            }
        }
    }
}
