using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Car
{
    public class SportCar : ICar
    {
        public int Wheels { get; set; }
        public int Engines { get; set; }
        public int Seats { get; set; }
        public TypeOfEngine TypeOfEngine { get; set; }
    }
}
