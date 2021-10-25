using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.State
{
    public class StateOne : IState
    {
        public void Print(Printer printer)
        {
            Console.WriteLine("State One");
            printer.State = new StateTwo();
        }
    }
}
