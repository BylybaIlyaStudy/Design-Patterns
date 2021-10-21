using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Car : ICar
    {
        public string GetCarClass()
        {
            return "ordinary car";
        }
    }
}
