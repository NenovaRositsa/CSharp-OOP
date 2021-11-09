using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
      
       
        public Vehicle(double fuel, double letters, int tankCapacity)
        {
            this.FuelQuantity = fuel;
            this.LitersPerKm = letters;
            this.TankCapacity = tankCapacity;
            if (tankCapacity >= fuel)
            {
                this.FuelQuantity = fuel;
            }
            else
            {
                this.FuelQuantity = 0;
            }
        }
        public double FuelQuantity { get; protected set; }
       
        public double LitersPerKm { get; protected set; }
        public int TankCapacity { get; protected set; }

        public virtual string Drive(double distance)
        {
            if (distance * this.LitersPerKm > FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            this.FuelQuantity -= distance * this.LitersPerKm;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
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
                this.FuelQuantity += liters;
            }
            
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
