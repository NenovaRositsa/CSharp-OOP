using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed.Car
{
    public class Car : Vehicle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 3;

        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption
        {
            get
            {
                return DEFAULT_FUEL_CONSUMPTION;
            }

        }
    }
}
