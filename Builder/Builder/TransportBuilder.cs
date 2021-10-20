using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Transport;

namespace Builder.Builder
{
    public class TransportBuilder<T> : IBuilder<T> where T : ITransport, new()
    {
        private T transport = new T();

        public void SetSeats(int countOfSeats)
        {
            transport.Seats = countOfSeats;
        }

        public void SetEngine(TypeOfEngine typeOfEngine, int countOfEngines = 1)
        {
            transport.TypeOfEngine = typeOfEngine;
            transport.Engine = countOfEngines;
        }

        public void SetWheels(int countOfWheels)
        {
            transport.Wheels = countOfWheels;
        }

        public T GetResult()
        {
            return transport;
        }
    }
}
