using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTestApp
{
    class LambdaEX
    {
        delegate void Dosomething1(string name);
        delegate string Concatenate(string[]arr);
        //return; void이기 때문에 생략 가능

        static void Main1(string[] args)
        {
            static void DoIt(object name)
            {
                Console.WriteLine($"{name}");
                Console.WriteLine($"{name}");
            }
            string name = "hugo";
            DoIt(name);
        }

        Concatenate concat = (arr) =>
        {
            string result = "";
            foreach (var s in arr)
            {
                result += s;
            }
            return result;
        };
        
    } 
}
