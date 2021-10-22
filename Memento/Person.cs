using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Person
    {
        private string surname;
        public string Name { get; set; }

        public Person(string surname)
        {
            this.surname = surname;
        } 

        public Snapshot CreateSnapshot()
        {
            return new Snapshot(Name, surname);
        }

        public void Restore(Person person)
        {
            this.Name = person.Name;
            this.surname = person.surname;
        }
    }
}
