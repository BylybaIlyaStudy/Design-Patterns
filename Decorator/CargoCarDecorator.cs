using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CargoCarDecorator : ICar
    {
        private ICar car;

        public CargoCarDecorator(ICar car)
        {
            this.car = car;
        }

        public string GetCarClass()
        {
            return car.GetCarClass() + "\n\t cargoMode:on";
        }
    }
}
