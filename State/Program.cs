using System;
using State.State;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new(new StateOne());
            printer.Print();
            printer.Print();
            printer.State = new StateTwo();
            printer.Print();
        }
    }
}
