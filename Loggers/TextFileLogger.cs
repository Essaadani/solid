using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidSample
{
    public class TextFileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter writer = File.AppendText("logFile.txt"))
            {
                writer.WriteLine(message);
            }
        }
    }
}
