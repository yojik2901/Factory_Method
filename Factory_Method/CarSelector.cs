using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class CarSelector//Наша фарбика по созданию автомобилей
    {
        private static CarSelector _instance;

        private CarSelector() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static CarSelector getInstance()
        {
            if (_instance == null)
                _instance = new CarSelector();
            return _instance;
        }

        public Car GetCar(RoadType roadType)//фабричный метод, который создает нужный автомобиль
        {
            Car car = null;

            switch (roadType)
            {
                case RoadType.CITY:
                    car = new Toyota();
                    break;
                case RoadType.OFF_ROAD:
                    car = new Jeep();
                    break;
                case RoadType.GAZON:
                    car = new Jeep_upd();
                    break;
            }

            return car;
        }
    }
}
