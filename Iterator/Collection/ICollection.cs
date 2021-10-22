using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterator;

namespace Iterator.Collection
{
    public interface ICollection<T>
    {
        public IIterator<T> CreateForwardIterator();
        public IIterator<T> CreateBackwardIterator();
    }
}
