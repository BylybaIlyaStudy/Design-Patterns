using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class StrategyOne : IStrategy
    {
        public void Print()
        {
            Console.WriteLine("State One");
        }
    }
}
