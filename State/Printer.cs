using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.State;

namespace State
{
    public class Printer
    {
        public IState State { get; set; }

        public Printer(IState state)
        {
            State = state;
        }

        public void Print()
        {
            State.Print(this);
        }
    }
}
