using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Strategy;

namespace Strategy
{
    public class Printer
    {
        public IStrategy Strategy { get; set; }

        public Printer(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void Print()
        {
            Strategy.Print();
        }
    }
}
