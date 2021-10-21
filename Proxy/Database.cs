using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Database : IDatabase
    {
        static private int countOfAccess = 0;
        private string[] names;

        static public int CountOfAccess => countOfAccess;

        public Database(string[] names)
        {
            this.names = names;
        }

        public string GetName(int index)
        {
            countOfAccess++;

            if (index >= 0 && index < names.Length)
            {
                return names[index];
            }

            return null;
        }
    }
}
