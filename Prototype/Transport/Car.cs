using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Transport
{
    class Car : Transport
    {
        public override int MaxSpeed { get; set; }

        public Car(int maxSpeed)
        {
            this.MaxSpeed = maxSpeed;
        }

        public Car(Car car)
        {
            this.MaxSpeed = car.MaxSpeed;
        }

        public override Transport Clone()
        {
            return new Car(this);
        }
    }
}
