using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Snapshot
    {
        private string name;
        private string surname;
        public Snapshot(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void Restore(Person person)
        {
            person.Restore(new Person(surname)
            {
                Name = name
            });
        }
    }
}
