using System;

namespace MyLab
{
    public class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("На парковке уже есть такой транспорт") 
        { }
    }

}
