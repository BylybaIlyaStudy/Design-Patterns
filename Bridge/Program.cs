using System;
using Bridge.Transport;
using Bridge.Transport.Engine;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransport transport = new Car()
            {
                Engine = new Random().Next() % 2 == 1
                    ? new ElectricEngine()
                    : new SteamEngine(),
                Seats = 1,
                Wheels = 4
            };
        }
    }
}
