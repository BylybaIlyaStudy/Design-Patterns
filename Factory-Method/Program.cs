using Factory_Method.Transport;
using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransport transport = Car.Create(200, 50);
            Console.WriteLine(transport.GetDistance());

            transport = Train.Create(200, 50);
            Console.WriteLine(transport.GetDistance());
        }
    }
}
