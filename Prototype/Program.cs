using System;
using System.Collections.Generic;
using Prototype.Transport;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transport.Transport> transports = new()
            {
                new Train(100),
                new Car(300)
            };
            transports.Add(transports[0].Clone());
            transports.Add(transports[1].Clone());

            transports.ForEach(transport =>
            {
                Console.WriteLine(transport.MaxSpeed);
            });
        }
    }
}
