using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Car
    {
        public int Engines { get; set; }
        public CarName Name { get; set; }

        public Car(int engines, string name)
        {
            Engines = engines;
            Name = CarName.GetCarName(name);
        }

        public void ShowName()
        {
            Name.ShowName();
        }

        public int NameArrayLength()
        {
            return CarName.CarNames.Count;
        }
    }
}
