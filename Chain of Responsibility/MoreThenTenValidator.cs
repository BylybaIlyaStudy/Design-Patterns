using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class MoreThenTenValidator : IValidator
    {
        public IValidator NextValidator { get; set; }
        public string Validate(int x)
        {
            if (x > 10)
            {
                return NextValidator?.Validate(x) ?? "Valid";
            }

            return "Error: Less or equal then ten";
        }
    }
}
