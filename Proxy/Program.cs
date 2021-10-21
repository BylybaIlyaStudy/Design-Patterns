using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase database = new Database(new string[] { "Tim", "Tom", "Sam" });
            IDatabase proxyDatabase = new ProxyDatabase(database);

            Console.Write(Database.CountOfAccess + " -> ");
            _ = proxyDatabase.GetName(1);
            _ = proxyDatabase.GetName(1);
            _ = proxyDatabase.GetName(1);
            Console.WriteLine(Database.CountOfAccess);

            Console.Write(Database.CountOfAccess + " -> ");
            _ = database.GetName(1);
            _ = database.GetName(1);
            _ = database.GetName(1);
            Console.WriteLine(Database.CountOfAccess);
        }
    }
}
