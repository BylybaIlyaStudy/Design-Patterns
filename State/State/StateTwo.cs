using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.State
{
    public class StateTwo : IState
    {
        public void Print(Printer printer)
        {
            Console.WriteLine("State Two");
            printer.State = new StateTwo();
        }
    }
}
