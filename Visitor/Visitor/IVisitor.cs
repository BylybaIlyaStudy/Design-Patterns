using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Printers;

namespace Visitor.Visitor
{
    public interface IVisitor
    {
        public void Visit(PrinterTwo printer);
        public void Visit(PrinterOne printer);
    }
}
