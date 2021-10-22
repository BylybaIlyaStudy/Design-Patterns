using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterator;

namespace Iterator.Collection
{
    public class List<T> : ICollection<T>
    {
        public T Element { get; set; }
        public List<T> Next { get; set; }
        public List<T> Previous { get; set; }

        public List()
        {
            Element = default(T);
            Previous = Next = null;
        }

        public void Add(T newElement)
        {
            var lastList = this;

            while (lastList.Next != null)
            {
                lastList = lastList.Next;
            }

            lastList.Next = new List<T>
            {
                Previous = lastList,
                Element = newElement
            };
        }

        public IIterator<T> CreateForwardIterator()
        {
            return new ListForwardIterator<T>(this);
        }

        public IIterator<T> CreateBackwardIterator()
        {
            throw new NotImplementedException();
        }
    }
}
