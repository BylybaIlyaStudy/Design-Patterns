using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Engineer;
using Builder.Transport;

namespace Builder.Builder
{
    public class EngineerBuilder : IBuilder<Engineer.Engineer>
    {
        private Engineer.Engineer engineer = new();

        public void SetSeats(int countOfSeats)
        {
            engineer.Skills.Add(Skills.Seat);
        }

        public void SetEngine(TypeOfEngine typeOfEngine, int countOfEngines = 1)
        {
            engineer.Skills.Add(Skills.Engine);
        }

        public void SetWheels(int countOfWheels)
        {
            engineer.Skills.Add(Skills.Wheel);
        }

        public Engineer.Engineer GetResult()
        {
            return engineer;
        }
    }
}
