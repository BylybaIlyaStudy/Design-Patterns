using System;

namespace Factory_Method.Transport
{
    class Car : Transport
    {
        public Car(double speed, double fuel)
        {
            this.FuelConsumption = 20;

            this.Speed = speed;
            this.Fuel = fuel;
        }

        public override double GetDistance()
        {
            return this.Speed * this.GetTime();
        }

        public void PrintCar()
        {
            Console.WriteLine(" /***\\");
            Console.WriteLine("/ |-| |");
            Console.WriteLine("-O---O-");
        }
    }
}
