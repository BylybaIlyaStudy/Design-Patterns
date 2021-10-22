using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Smith")
            {
                Name = "Jhon"
            };

            Console.WriteLine(person.Name);

            Snapshot snapshot = person.CreateSnapshot();

            person.Name = "Tim";

            Console.WriteLine(person.Name);

            snapshot.Restore(person);

            Console.WriteLine(person.Name);
        }
    }
}
