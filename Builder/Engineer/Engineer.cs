using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Engineer
{
    public class Engineer : IEngineer
    {
        public HashSet<Skills> Skills { get; set; } = new HashSet<Skills>();
    }
}
