using Factory_Method.Transport;

namespace Factory_Method.Factory
{
    class TrainFactory : Factory
    {
        public override Transport.Transport CreateTransport(double speed, double fuel)
        {
            return new Train(speed, fuel);
        }
    }
}
