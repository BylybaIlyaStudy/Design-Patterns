using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Writer
{
    public class StringWriter : IWriter
    {
        public void PrintString()
        {
            Console.WriteLine("ordinary string");
        }

        public Mediator Mediator { get; set; }
    }
}
