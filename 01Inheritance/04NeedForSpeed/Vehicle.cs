using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual double FuelConsumption 
        { 
            get
            {
                return DEFAULT_FUEL_CONSUMPTION;
            }
            
        }

        public virtual void Drive(double kilometers)
        {
            double fuelNeeded = kilometers * this.FuelConsumption;

            if (this.Fuel >= fuelNeeded)
            {
                this.Fuel -= fuelNeeded;
            }
        }


    }
}
