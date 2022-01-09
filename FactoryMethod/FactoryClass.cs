using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FactoryClass
    {
        private FactoryClass()
        {
        }
        public static FactoryClass Instance() 
        {
            return new FactoryClass();  
        }
    }
}
