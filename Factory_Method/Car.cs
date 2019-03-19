using System;

namespace Factory_Method
{
    public interface Car//Интерфейс от которого мы будем наследовать наши классы
    {
        void Drive();
        void Stop();
    }
}