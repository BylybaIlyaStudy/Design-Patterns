using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyDatabase : IDatabase
    {
        private Dictionary<int, string> CachedNames = new();
        private IDatabase database;

        public ProxyDatabase(IDatabase database)
        {
            this.database = database;
        }

        public string GetName(int index)
        {
            if (CachedNames.ContainsKey(index))
            {
                return CachedNames[index];
            }

            var name = database.GetName(index);
            CachedNames.Add(index, name);

            return name;
        }
    }
}
