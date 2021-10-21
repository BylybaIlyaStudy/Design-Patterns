using System;
using System.Drawing;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new(2, "Cargo");
            Car car2 = new(2, "Cargo");

            car1.ShowName();
            Console.WriteLine(car2.NameArrayLength());
        }
    }
}
