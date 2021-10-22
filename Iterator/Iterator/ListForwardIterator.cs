using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Collection;

namespace Iterator.Iterator
{
    public class ListForwardIterator<T> : IIterator<T>
    {
        private List<T> collection;

        public ListForwardIterator(List<T> collection)
        {
            this.collection = collection;
        }

        public T GetNext()
        {
            collection = collection.Next;

            return collection.Element;
        }

        public bool HasMore() => collection.Next != null;
    }
}
