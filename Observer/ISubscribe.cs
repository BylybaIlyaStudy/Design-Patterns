using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubscribe
    {
        public EventManager EventManager { get; set; }
        public void Update(string event_);
    }
}
