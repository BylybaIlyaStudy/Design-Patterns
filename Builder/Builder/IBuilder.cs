using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Transport;

namespace Builder.Builder
{
    public interface IBuilder<T>
    {
        public void SetSeats(int countOfSeats);
        public void SetEngine(TypeOfEngine typeOfEngine, int countOfEngines = 1);
        public void SetWheels(int countOfWheels);
        public T GetResult();
    }
}
