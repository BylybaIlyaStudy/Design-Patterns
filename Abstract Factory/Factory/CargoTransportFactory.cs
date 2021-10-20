using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Transport;

namespace Abstract_Factory.Factory
{
    public class CargoTranCargoFactory : ITransportFactory
    {
        public ICar CreateCar(int countOfWheels, int countOfEngines, int countOfSeats)
        {
            return new CargoCar
            {
                Engines = countOfEngines,
                Wheels = countOfWheels,
                Seats = countOfSeats
            };
        }

        public ITrain CreateTrain(int countOfWheels, int countOfEngines, int countOfWagon)
        {
            return new CargoTrain()
            {
                Engines = countOfEngines,
                Wheels = countOfWheels,
                Wagon = countOfWagon
            };
        }
    }
}
