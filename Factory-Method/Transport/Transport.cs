using System;

namespace Factory_Method.Transport
{
    public abstract class Transport : ITransport
    {
        public double FuelConsumption { get; set; }
        public double Fuel { get; set; }
        public double Speed { get; set; }

        public abstract double GetDistance();

        public virtual double GetTime()
        {
            return this.Fuel / this.FuelConsumption;
        }
    }
}
