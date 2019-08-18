using System;
using System.Collections.Generic;
using System.Text;

namespace SolidSample
{
    public abstract class Converter
    {
        public int DecimalNumber { get; set; }

        public Converter(int decimalNumber)
        {
            DecimalNumber = decimalNumber;
        }

        public static explicit operator Converter(Type v)
        {
            throw new NotImplementedException();
        }

        public abstract string Convert();
    }
}
