using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class NewString : INewString
    {
        public string String { get; set; }
        public void Append(INewString newString)
        {
            String += newString.String;
        }
    }
}
