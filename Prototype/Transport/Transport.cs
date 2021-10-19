using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Transport
{
    public abstract class Transport
    {
        public abstract int MaxSpeed { get; set; }
        public abstract Transport Clone();
    }
}
