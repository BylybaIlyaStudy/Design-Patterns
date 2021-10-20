using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Transport
{
    public class CargoTrain : ITrain
    {
        public int Engines { get; set; } = 2;
        public int Wheels { get; set; } = 8;
        public int Wagon { get; set; } = 50;
    }
}
