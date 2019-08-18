using System;
using System.Collections.Generic;
using System.Text;

namespace SolidSample
{
    public class OctalConverter : Converter
    {
        public OctalConverter(int decimalNumber)
    : base(decimalNumber)
        {

        }

        public override string Convert()
        {
            return $"The result is: {System.Convert.ToString(DecimalNumber, 8)}";
        }
    }
}
