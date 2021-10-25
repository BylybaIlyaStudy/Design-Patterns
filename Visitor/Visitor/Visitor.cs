using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Printers;

namespace Visitor.Visitor
{
    public class Visitor : IVisitor
    {
        public void Visit(PrinterTwo printer)
        {
            printer.PrintTwo();
        }

        public void Visit(PrinterOne printer)
        {
            printer.PrintOne();
        }
    }
}
