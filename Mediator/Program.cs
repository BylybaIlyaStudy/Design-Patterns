using System;
using Mediator.Writer;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberWriter numWriter = new NumberWriter();
            StringWriter strWriter = new StringWriter();

            Mediator mediator = new Mediator()
            {
                NumberWriter = numWriter,
                StringWriter = strWriter
            };

            mediator.Notify(numWriter);
            mediator.Notify(strWriter);
        }
    }
}
