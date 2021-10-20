using System;
using Builder.Builder;
using Builder.Transport;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var carBuilder = new TransportBuilder<Car>();
            var engineerBuilder = new EngineerBuilder();

            director.CreateTransport(carBuilder);
            director.CreateEngineer(engineerBuilder, true);

            var car = carBuilder.GetResult();
            var engineer = engineerBuilder.GetResult();
        }
    }
}
