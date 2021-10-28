using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Rainbow : IRainbow
    {
        public HashSet<IRainbow> Colors { get; set; } = new HashSet<IRainbow>();

        public HashSet<System.Drawing.Color> GetColors()
        {
            HashSet<System.Drawing.Color> colors = new HashSet<System.Drawing.Color>();

            foreach (var color in Colors)
            {
                foreach (var deepColor in color.GetColors())
                {
                    colors.Add(deepColor);
                }
            }

            return colors;
        }
    }
}
