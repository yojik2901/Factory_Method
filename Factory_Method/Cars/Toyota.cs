using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Toyota : Car
    {
        public void Drive()
        {
            Console.WriteLine("speed = 15000 km/h");
        }

        public void Stop()
        {
            Console.WriteLine("stop in 10000 sec");
        }
    }
}
