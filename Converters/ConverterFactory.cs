using System;
using System.Collections.Generic;
using System.Text;

namespace SolidSample
{
    public class ConverterFactory
    {
        public static Converter Create(BaseType baseType, int decimalNumber)
        {
            try
            {
                return (Converter)
                       Activator.CreateInstance(
                           Type.GetType($"SolidSample.{baseType.ToString()}Converter"),
                           new object[] { decimalNumber });

            }
            catch (Exception)
            {

                return new InvalidBaseConverter(decimalNumber);
            }
        }
    }
}
