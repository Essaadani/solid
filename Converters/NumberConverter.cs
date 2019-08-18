using System;
using System.Collections.Generic;
using System.Text;

namespace SolidSample
{
    public class NumberConverter
    {
        public int DecimalNumber { get; set; }
        public int ToBase { get; set; }

        public BaseType Base;
        public string Result { get; set; }
        public ILogger Logger { get; set; }
        public IReader Reader { get; set; }
        public ILogger Writer { get; set; }

        public NumberConverter(ILogger logger, IReader reader, ILogger writer)
        {
            Logger = logger;
            Reader = reader;
            Writer = writer;
        }
        public void Convert()
        {
            Logger.Log("Program is starting...");

            Writer.Log("Enter the number to convert:");
            DecimalNumber = Reader.ReadInteger();

            if (string.IsNullOrEmpty(DecimalNumber.ToString()))
            {
                Writer.Log("You entered an invalid integer value.");
            }

            Logger.Log($"The number to convert is: {DecimalNumber}");

            Writer.Log("Enter the base type (Ex: 2,8,16):");
            Base = (BaseType)Reader.ReadInteger();
            Logger.Log($"The selected base type is: {Base.ToString() }");

            var type = ConverterFactory.Create(Base, DecimalNumber);

            Logger.Log($"using the converter: {type.GetType() }");

            Result = type.Convert();

            Writer.Log(Result);

            Logger.Log($"The result is: {Result} ");

            Logger.Log("Program is ending..");

        }
    }

    public enum BaseType
    {
        Binary = 2,
        Octal = 8,
        Hexadecimal = 16,
        None = 0
    }
}
