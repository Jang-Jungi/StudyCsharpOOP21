using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsinginterfaceTestApp
{
    class FileLogger : ILogger
    {

        private StreamWriter writer;  

        public FileLogger(string path)
        {
            writer = File.CreateText(path); //file을 만드는 작업
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"FileLog {DateTime.Now}\t >>>>> {message}");
        }
    }
}

