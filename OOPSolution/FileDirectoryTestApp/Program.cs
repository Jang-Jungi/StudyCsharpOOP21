using System;
using System.IO;

namespace FileDirectoryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string path = @"C:\Users\admin\Desktop\수업 스크린샷\1주차\3일차"; // verbatim string
            var dirs = Directory.GetDirectories(path);
            foreach (var item in dirs)
            {
                Console.WriteLine(item);
                var dirInfo = new DirectoryInfo(item);
                Console.WriteLine($"{dirInfo.Name}/{dirInfo.Attributes}/{dirInfo.CreationTime}");
            }
            var files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                Console.WriteLine(item);
                var fileInfo = new FileInfo(item);
                Console.WriteLine($"{fileInfo.Name}{fileInfo.Attributes}{fileInfo.CreationTime}{fileInfo.Length }");
            }*/
            string newPath = @"C:\Test\Help";//디렉토리 파일을 생성할 위치
            int dirNum = 0;  // 생성될 디렉토리의 중복을 피하기 
            while (true)
            {
                Console.WriteLine("file/dir로 입력하세요(종료버튼 X)");
                var input = Console.ReadLine();
                if (input == "X")
                {
                    break;
                }
                else
                {
                    //파일, 폴더 만드는 로직
                    if(input=="file")
                    {
                        var fileName = $"SampleFile_{ DateTime.Now.ToString("yyMMddHHmmss")}.txt";
                            var fullPath = $@"{newPath}\{fileName}";
                            File.Create(fullPath);
                    }
                    else if(input == "dir")
                    {
                        //Console.WriteLine("dir생성");
                        var dirName = $"SampleDirectory{dirNum}";
                        var fullPath = @$"{newPath}\{dirName}";
                        if(!Directory.Exists(fullPath))
                        {
                            Directory.CreateDirectory(fullPath);
                        }
                        else
                        {
                            dirNum++;
                            fullPath = $@"{newPath}\{dirName}\{dirNum}";
                            Directory.CreateDirectory(fullPath);
                        }
                    }
                    else
                    {
                        Console.WriteLine("file/dir로 입력하세요");
                    }
                }
                Console.WriteLine("프로그램 종료");
            }
        }
    }
}
