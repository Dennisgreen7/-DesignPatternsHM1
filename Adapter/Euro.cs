using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Euro
    {

        public Double amount;

        public Euro()
        {
        }

        public Euro(double amount)
        {
            this.amount = amount;
        }

        public string Pay(Double price)
        {
            return "You Paid "+price * 3.54;
        }
    }
}
