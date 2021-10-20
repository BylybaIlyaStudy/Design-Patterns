using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Engineer;
using Builder.Transport;

namespace Builder.Builder
{
    public class Director
    {
        public void CreateTransport<T>(
            IBuilder<T> builder,
            int countOfSeats = 5,
            int countOfWheels = 4,
            int countOfEngine = 1,
            TypeOfEngine typeOfEngine = TypeOfEngine.InternalСombustion)
            where T : ITransport
        {
            builder.SetEngine(typeOfEngine, countOfEngine);
            builder.SetWheels(countOfWheels);
            builder.SetSeats(countOfSeats);
        }

        public void CreateEngineer(IBuilder<Engineer.Engineer> builder, bool canEngine = false, bool canWheel = false, bool canSeats = false)
        {
            if (canEngine)
            {
                builder.SetEngine(0, 0);
            }
            if (canSeats)
            {
                builder.SetSeats(0);
            }
            if (canWheel)
            {
                builder.SetWheels(0);
            }
        }
    }
}
