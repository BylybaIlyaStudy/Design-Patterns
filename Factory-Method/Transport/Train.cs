using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Transport
{
    class Train : Transport
    {
        public Train(double speed, double fuel)
        {
            this.FuelConsumption = 200;

            this.Speed = speed;
            this.Fuel = fuel;
        }

        public override double GetDistance()
        {
            return this.Speed * this.GetTime();
        }
    }
}
