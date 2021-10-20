using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Transport
{
    public interface ITransport
    {
        public int Seats { get; set; }
        public int Wheels { get; set; }
        public int Engine { get; set; }
        public TypeOfEngine TypeOfEngine { get; set; }
    }
}
