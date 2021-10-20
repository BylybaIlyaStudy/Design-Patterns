using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Transport
{
    public class CargoCar : ICar
    {
        public int Engines { get; set; } = 2;
        public int Wheels { get; set; } = 14;
        public int Seats { get; set; } = 5;
    }
}
