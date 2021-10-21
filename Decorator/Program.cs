using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar sportCargoCar = new CargoCarDecorator(new SportCarDecorator(new Car()));
            ICar cargoCar = new CargoCarDecorator(new Car());
            ICar sportCar = new SportCarDecorator(new Car());
            ICar car = new Car();

            Console.WriteLine(sportCargoCar.GetCarClass());
            Console.WriteLine(cargoCar.GetCarClass());
            Console.WriteLine(sportCar.GetCarClass());
            Console.WriteLine(car.GetCarClass());
        }
    }
}
