using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHM
{
    internal class ElectroiniCheck : Car
    {
        public override void Handle()
        {
            if (new Random().Next(1, 11) >= 6)
            {
                IsFixed = true;
                Console.WriteLine("Electronic Check Passed");
            }
            else
            {
                if (next != null)
                {
                    Console.WriteLine("Electronic Check Failed");
                    next.Handle();
                }
            }
        }
    }
}
