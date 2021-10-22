using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Writer;

namespace Mediator
{
    public class Mediator
    {
        public StringWriter StringWriter { get; set; }
        public NumberWriter NumberWriter { get; set; }

        public void Notify(IWriter writer)
        {
            if (writer == StringWriter)
            {
                StringWriter.PrintString();
            }

            if (writer == NumberWriter)
            {
                NumberWriter.PrintNumber();
            }
        }
    }
}
