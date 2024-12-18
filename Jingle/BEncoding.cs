using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Jingle
{
    public static class BEncoding
    {
        private static byte dictionaryStart = System.Text.Encoding.UTF8.GetBytes("d")[0];
        private static byte dictionaryEnd = System.Text.Encoding.UTF8.GetBytes("e")[0];
        private static byte listStart = System.Text.Encoding.UTF8.GetBytes("l")[0];
        private static byte listEnd = System.Text.Encoding.UTF8.GetBytes("e")[0];
        private static byte integerStart = System.Text.Encoding.UTF8.GetBytes("i")[0];
        private static byte integerEnd = System.Text.Encoding.UTF8.GetBytes("e")[0];
        private static byte stringSeparator = System.Text.Encoding.UTF8.GetBytes(":")[0];   
    }
}
