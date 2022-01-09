using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHM
{
    public class GarageCheck : Car
    {
        public override void Handle()
        {
            if (new Random().Next(1, 11) >= 6)
            {
                IsFixed = true;
                Console.WriteLine("Garage Check Passed");
            }
            else
            {
                if (next != null)
                {
                    Console.WriteLine("Garage Check Failed");
                    next.Handle();
                }
            }
        }
    }
}
