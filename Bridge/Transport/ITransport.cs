using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Transport.Engine;

namespace Bridge.Transport
{
    public interface ITransport
    {
        public IEngine Engine { get; set; }
        public int Wheels { get; set; }
        public int Seats { get; set; }
    }
}
