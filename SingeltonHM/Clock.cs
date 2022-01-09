using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonHM
{
    public class Clock
    {
        private static Clock instance;

        private static readonly object key = new object();
        private TimeOnly Time = new TimeOnly(08, 00); 

        private Clock()
        {

        }
        public static Clock GetInstance()
        {

            if (instance == null)
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new Clock();
                    }
                }
            }

            return instance;
        }

        public  void GetTime()
        {
            Console.WriteLine(Time.ToString());
        }
    }
}
