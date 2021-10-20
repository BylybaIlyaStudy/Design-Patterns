using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Transport;

namespace Abstract_Factory.Factory
{
    public interface ITransportFactory
    {
        public ICar CreateCar(int countOfWheels, int countOfEngines, int countOfSeats);
        public ITrain CreateTrain(int countOfWheels, int countOfEngines, int countOfWagon);
    }
}
