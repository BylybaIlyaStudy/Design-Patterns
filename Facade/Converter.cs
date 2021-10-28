using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Car;

namespace Facade
{
    public class Converter
    {
        public ICar ToSportCar(ICar car)
        {
            car.Engines = car.Wheels;
            car.TypeOfEngine = TypeOfEngine.Electric;
            car.Seats = car.Seats > 2 ? 2 : car.Seats;

            return car;
        }

        public ICar ToCargoCar(ICar car)
        {
            car.Engines = car.Engines > 2 ? 2 : car.Engines;
            car.TypeOfEngine = TypeOfEngine.DIC;
            car.Seats = car.Seats > 2 ? 2 : car.Seats;
            car.Wheels = car.Wheels * 2 - 2;

            return car;
        }
    }
}
