using System;
using Abstract_Factory.Factory;
using Abstract_Factory.Transport;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransportFactory transportFactory;

            if (new Random().Next() % 2 == 1)
            {
                transportFactory = new SportTransportFactory();
            }
            else
            {
                transportFactory = new CargoTransportFactory();
            }

            var car = transportFactory.CreateCar(4, 2, 1);
            var train = transportFactory.CreateTrain(8, 2, 5);
        }
    }
}
