using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = CarSelector.getInstance().GetCar(RoadType.CITY);
            car.Drive();
            car.Stop();

            Car car1 = CarSelector.getInstance().GetCar(RoadType.GAZON);
            car.Drive();
            car.Stop();

            Car car2 = CarSelector.getInstance().GetCar(RoadType.OFF_ROAD);
            car2.Drive();
            car2.Stop();
        }
    }
}
