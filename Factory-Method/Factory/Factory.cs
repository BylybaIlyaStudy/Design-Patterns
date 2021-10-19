using System;

namespace Factory_Method.Factory
{
    public abstract class Factory
    {
        public abstract Transport.Transport CreateTransport(double speed, double fuel);

        public void Print(double speed, double fuel)
        {
            Transport.Transport transport = CreateTransport(speed, fuel);
            Console.WriteLine($"time: {transport.GetTime()}");
            Console.WriteLine($"distance: {transport.GetDistance()}");
        }
    }
}
