using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public class ChangeNameCommand : ICommand
    {
        public string Name { get; set; }

        public Person Receiver { get; set; }

        public void Execute()
        {
            Receiver.Name = Name;
        }
    }
}
