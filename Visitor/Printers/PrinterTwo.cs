using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor;

namespace Visitor.Printers
{
    public class PrinterTwo : IPrinter
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void PrintTwo()
        {
            Console.WriteLine("Two");
        }
    }
}
