using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : INewString
    {
        private readonly LegacyString legacyString;

        public string String
        {
            get => new(legacyString.GetString());
            set => legacyString.ChangeString(value.ToCharArray());
        }

        public Adapter(LegacyString legacyString)
        {
            this.legacyString = legacyString;
        }

        public void Append(INewString newString)
        {
            var chars = legacyString.GetString();

            foreach (var symbol in newString.String)
            {
                chars = chars.Append(symbol).ToArray();
            }

            legacyString.ChangeString(chars);
        }
    }
}
