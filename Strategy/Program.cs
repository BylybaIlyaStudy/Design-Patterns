using System;
using Strategy.Strategy;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer(new StrategyOne());
            printer.Print();
            printer.Print();
            printer.Strategy = new StrategyTwo();
            printer.Print();
        }
    }
}
