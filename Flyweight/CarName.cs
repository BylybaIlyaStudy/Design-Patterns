using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CarName
    {
        public static HashSet<string> CarNames = new();

        public static CarName GetCarName(string name)
        {
            if (!CarNames.Contains(name))
            {
                CarNames.Add(name);
            }

            return new CarName(name);
        }

        public string Name { get; }

        private CarName(string name)
        {
            Name = name;
        }

        public void ShowName()
        {
            Console.WriteLine(Name);
        }
    }
}
