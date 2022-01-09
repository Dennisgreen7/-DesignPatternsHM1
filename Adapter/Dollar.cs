using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Dollar
    {
       public Double amount;

        public Dollar(double amount)
        {
            this.amount = amount;
        }

        public string Pay(Double price) 
        {
            return "You paid "+price * 3.12;
        }
    }
}
