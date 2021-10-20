using System;
using Abstract_Factory.Factory;
using Abstract_Factory.Transport;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var sportTransportFactory = new SportTransportFactory();
            var car = sportTransportFactory.CreateCar(4, 2, 1);
        }
    }
}
