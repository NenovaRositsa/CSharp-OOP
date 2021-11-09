using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {

        private const double FUEL_CONSUMPTION_INCREASE = 0.9;
        public Car(double fuel, double litersPerKm, int tankCapacity)
            : base(fuel, litersPerKm + FUEL_CONSUMPTION_INCREASE, tankCapacity)
        {
            
        }
        
    }
}
