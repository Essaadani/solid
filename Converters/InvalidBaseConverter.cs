using System;
using System.Collections.Generic;
using System.Text;

namespace SolidSample
{
    public class InvalidBaseConverter : Converter
    {
        public InvalidBaseConverter(int decimalNumber):base(decimalNumber)
        {
        }

        public override string Convert()
        {
            return $"This base type is not a valid base.";
        }
    }
}
