using System;
using Iterator.Collection;
using Iterator.Iterator;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            ICollection<int> collection = list;

            IIterator<int> forward = collection.CreateForwardIterator();

            while (forward.HasMore())
            {
                Console.WriteLine(forward.GetNext());
            }
        }
    }
}
