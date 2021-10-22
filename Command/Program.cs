using System;
using Command.Command;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new()
            {
                Growth = 1.85,
                Name = "Tom"
            };

            ICommand changeName = new ChangeNameCommand()
            {
                Name = "Nick",
                Receiver = person
            };
            ICommand changeGrowth = new ChangeGrowthCommand()
            {
                Growth = 1.9,
                Receiver = person
            };
            ICommand changeGrowthImperial = new ChangeGrowthImperialCommand()
            {
                Growth = 7,
                Receiver = person
            };

            changeName.Execute();
            changeGrowth.Execute();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Growth);

            changeGrowthImperial.Execute();
            Console.WriteLine(person.Growth);
        }
    }
}
