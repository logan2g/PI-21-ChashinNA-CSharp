﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLab
{
    class ParkingOccupiedPlaceException : Exception 
    {
        public ParkingOccupiedPlaceException() : base("Место уже занято")
        { }
    }
}
