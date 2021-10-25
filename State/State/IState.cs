using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.State
{
    public interface IState
    {
        public void Print(Printer printer);
    }
}
