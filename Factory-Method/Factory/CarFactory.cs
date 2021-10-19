using Factory_Method.Transport;

namespace Factory_Method.Factory
{
    class CarFactory : Factory
    {
        public override Transport.Transport CreateTransport(double speed, double fuel)
        {
            return new Car(speed, fuel);
        }
    }
}
