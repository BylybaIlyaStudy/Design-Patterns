using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Writer
{
    public interface IWriter
    {
        public Mediator Mediator { get; set; }
    }
}
