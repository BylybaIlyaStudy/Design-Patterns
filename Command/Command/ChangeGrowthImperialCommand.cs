using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public class ChangeGrowthImperialCommand : ICommand
    {
        public double Growth { get; set; } 
        public Person Receiver { get; set; }
        public void Execute()
        {
            Receiver.Growth = Growth * 0.3048;
        }
    }
}
