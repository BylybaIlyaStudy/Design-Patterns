using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface INewString
    {
        public string String { get; set; }
        public void Append(INewString newString);
    }
}
