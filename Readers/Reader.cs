using System;
using System.Collections.Generic;
using System.Text;

namespace SolidSample
{
    public class Reader:IReader
    {
        public Reader(ILogger logger)
        {
            Logger = logger;
        }

        public ILogger Logger { get; }

        public int ReadInteger()
        {
            try
            {
            string value = Console.ReadLine();
                return int.Parse(value);
            }
            catch (Exception)
            {
                Logger.Log("The entered value is invalid.");
                return 0;
            }
            
        }
    }
}
