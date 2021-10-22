using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Collection;

namespace Iterator.Iterator
{
    public interface IIterator<T>
    {
        public T GetNext();

        public bool HasMore();
    }
}
