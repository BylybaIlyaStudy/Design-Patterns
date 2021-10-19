using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Transport
{
    class Train: Transport
    {
        public override int MaxSpeed { get; set; }

        public Train(int maxSpeed)
        {
            this.MaxSpeed = maxSpeed;
        }
        public Train(Train train)
        {
            this.MaxSpeed = train.MaxSpeed;
        }

        public override Transport Clone()
        {
            return new Train(this);
        }
    }
}
