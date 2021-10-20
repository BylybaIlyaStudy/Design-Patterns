using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Transport
{
    public interface ITrain : ITransport
    {
        public int Wagon { get; set; }
    }
}
