using System;
using Visitor.Printers;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new Random().Next() % 2 == 1
                ? new PrinterOne()
                : new PrinterTwo();
            printer.Accept(new Visitor.Visitor());
        }
    }
}
