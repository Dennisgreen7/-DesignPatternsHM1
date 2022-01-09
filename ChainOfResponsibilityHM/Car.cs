using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHM
{
    public abstract class Car
    {
        protected bool IsFixed { get; set; }
        protected Car next;
        public void setnext(Car next)
        {
            this.next = next;
        }
        public abstract void Handle();
    }
}
