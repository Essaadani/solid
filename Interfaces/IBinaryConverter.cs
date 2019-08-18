using System;
using System.Collections.Generic;
using System.Text;

namespace SolidSample
{
    public interface IBinaryConverter
    {
        string BinaryToText(string binary);
        string TextToBinary(string text);
    }

}
