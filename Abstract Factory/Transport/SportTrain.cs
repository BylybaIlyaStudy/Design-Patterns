using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Transport
{
    public class SportTrain : ITrain
    {
        public int Wagon { get; set; } = 1;
        public int Engines { get; set; } = 8;
        public int Wheels { get; set; } = 8;
    }
}
