using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath,FileMode.Open));
            while(sr.EndOfStream==false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            //텍스트 파일 읽어오는 부분
            Console.WriteLine("텍스트파일 읽기완료");


            string wirtePath = @"C:\Test\Help\jjg.txt";
            StreamWriter sw = new StreamWriter(new FileStream(wirtePath, FileMode.Create));

            sw.Write("Hello, World\n");
            sw.Write("Hi\n");
            sw.Write(3.141592);
            sw.Close();

            Console.WriteLine("텍스트파일 작성완료");
        }
    }
}
