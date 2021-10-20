using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Transport
{
    public interface ICar : ITransport
    {
        public int Seats { get; set; }
    }
}
