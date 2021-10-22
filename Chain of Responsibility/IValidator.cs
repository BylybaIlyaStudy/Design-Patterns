using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public interface IValidator
    {
        public IValidator NextValidator { get; set; }

        public string Validate(int x);
    }
}
