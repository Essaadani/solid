using System;

namespace SolidSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new Logger();

            var converter = new NumberConverter(new TextFileLogger(),
                                                new Reader(consoleLogger),
                                                consoleLogger);

            converter.Convert();
        }
    }
}
