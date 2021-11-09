using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models
{
    public class Topping
    {
        private const double BASE_CALORIES = 2;

        private const double meat = 1.2;
        private const double veggies = 0.8;
        private const double cheese = 1.1;
        private const double sauce = 0.9;


        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                ValidationType(value);
                this.type = value;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                ValidationWeight(value);
                this.weight = value;
            }
        }

        private  void ValidationWeight(double value)
        {
            if (1 > value || value > 50)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
            }
        }



        private void ValidationType(string value)
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            
        }

        public double CalculateCalories()
        {
            double calories = 0.0;

            switch (this.Type.ToLower())
            {
                case "meat": calories = BASE_CALORIES * this.Weight * meat; break;
                case "veggies": calories = BASE_CALORIES * this.Weight * veggies; break;
                case "cheese": calories = BASE_CALORIES * this.Weight * cheese; break;
                case "sauce": calories = BASE_CALORIES * this.Weight * sauce; break;

                default:
                    break;
            }

            return calories;
        }
    }
}
