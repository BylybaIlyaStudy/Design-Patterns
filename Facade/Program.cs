using System;
using Facade.Car;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Car.Car();
            Converter converter = new();

            car = new Random().Next() % 2 == 1
                ? converter.ToCargoCar(car)
                : converter.ToSportCar(car);

            Console.WriteLine(car.TypeOfEngine);
        }
    }
}
