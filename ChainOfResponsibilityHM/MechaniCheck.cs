using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHM
{
    public class MechaniCheck : Car
    {
        public override void Handle()
        {
            if (new Random().Next(1, 11) >= 6)
            {
                IsFixed = true;
                Console.WriteLine("Mechanic Check Passed");
            }
            else
            {
                if (next != null)
                {
                    Console.WriteLine("Mechaniic Check Failed");
                    next.Handle();
                }
            }
        }
    }
}
