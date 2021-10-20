using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Color : IRainbow
    {
        public HashSet<System.Drawing.Color> GetColors()
        {
            var random = new Random();

            return new HashSet<System.Drawing.Color>()
            {
                System.Drawing.Color.FromArgb(
                    random.Next(255),
                    random.Next(255),
                    random.Next(255))
            };
        }
    }
}
