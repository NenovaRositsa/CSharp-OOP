using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCREASE = 1.6;
        public Truck(double fuel, double liters, int tankCapacity)
            : base(fuel, liters + FUEL_CONSUMPTION_INCREASE, tankCapacity)
        {
           
        }
      
        public override void Refuel(double liters)
        {
            if (liters > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                this.FuelQuantity += (liters * 0.95);
            }
          
        }
    }
}
