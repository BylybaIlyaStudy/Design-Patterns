using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Writer
{
    public class NumberWriter : IWriter
    {
        public void PrintNumber()
        {
            Console.WriteLine(1);
        }

        public Mediator Mediator { get; set; }
    }
}
