using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Transport
{
    public interface ITransport
    {
        public double FuelConsumption { get; set; }
        public double Fuel { get; set; }
        public double Speed { get; set; }

        public double GetDistance();

        public double GetTime();
    }
}
