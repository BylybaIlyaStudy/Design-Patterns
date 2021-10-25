using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor;

namespace Visitor.Printers
{
    public class PrinterOne : IPrinter
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void PrintOne()
        {
            Console.WriteLine("One");
        }
    }
}
