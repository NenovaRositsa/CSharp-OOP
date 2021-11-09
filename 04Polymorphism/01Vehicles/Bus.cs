using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCREASE = 1.4;
        public Bus(double fuel, double liters, int tankCapacity)
            : base(fuel, liters, tankCapacity)
        {
        }


        public override string Drive(double distance)
        {
            if (distance * (this.LitersPerKm + FUEL_CONSUMPTION_INCREASE) > FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            this.FuelQuantity -= distance * (this.LitersPerKm + FUEL_CONSUMPTION_INCREASE);
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public string DriveEmpty(double distance) => base.Drive(distance);


    }
}
