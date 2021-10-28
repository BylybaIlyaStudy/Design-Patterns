using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IRainbow rainbow = new Random().Next() % 2 == 1
                ? CreateRainbow()
                : CreateColor();

            foreach (var color in rainbow.GetColors())
            {
                Console.WriteLine(color.Name);
            }
        }

        static Color CreateColor()
        {
            return new Color(); ;
        }

        static Rainbow CreateRainbow()
        {
            Rainbow rainbow = new Rainbow();

            int firstLimit = new Random().Next(3, 6);
            int secondLimit = new Random().Next(3, 6);

            for (int i = 0; i < firstLimit; i++)
            {
                Rainbow partOfRainbow = new Rainbow();

                for (int j = 0; j < secondLimit; j++)
                {
                    partOfRainbow.Colors.Add(new Color());
                }

                rainbow.Colors.Add(partOfRainbow);
            }

            return rainbow;
        }
    }
}
