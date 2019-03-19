using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Jeep : Car
    {
        public void Drive()
        {
            Console.WriteLine("speed = 150 km/h");
        }

        public void Stop()
        {
            Console.WriteLine("stop in 1 sec");
        }
    }
}
