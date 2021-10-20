using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LegacyString
    {
        private char[] str = Array.Empty<char>();

        public char[] GetString()
        {
            return str;
        }

        public void ChangeString(char[] newString)
        {
            foreach (var symbol in newString)
            {
                str = str.Append(symbol).ToArray();
            }
        }
    }
}
