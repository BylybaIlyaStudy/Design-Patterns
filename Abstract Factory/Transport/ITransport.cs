using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Transport
{
    public interface ITransport
    {
        public int Engines { get; set; }
        public int Wheels { get; set; }
    }
}
