using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Transport
{
    class Train : Transport
    {
        private Train(double speed, double fuel)
        {
            this.FuelConsumption = 200;

            this.Speed = speed;
            this.Fuel = fuel;
        }

        public static ITransport Create(double speed, double fuel)
        {
            return new Train(speed, fuel);
        }

        public override double GetDistance()
        {
            return this.Speed * this.GetTime();
        }
    }
}
