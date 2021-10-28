using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SportCarDecorator : ICar
    {
        private ICar car;

        public SportCarDecorator(ICar car)
        {
            this.car = car;
        }

        public string GetCarClass()
        {
            return car.GetCarClass() + "\n\t sportMode:on";
        }
    }
}
