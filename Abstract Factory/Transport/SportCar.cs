using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Transport
{
    public class SportCar : ICar
    {
        public int Engines { get; set; } = 4;
        public int Wheels { get; set; } = 4;
        public int Seats { get; set; } = 2;
    }
}
