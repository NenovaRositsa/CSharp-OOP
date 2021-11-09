using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models
{
    public class Dough
    {
        private const double MIN_WEIGHT = 1;
        private const double MAX_WEIGHT = 200;
        private const string INVALID_TYPE_FLOUR_ERROR_MESSAGE = "Invalid type of dough.";
        private const string INVALID_WEIGHT_ERROR_MESSAGE = "Dough weight should be in the range [1..200].";

        private const double white = 1.5;
        private const double wholegrain = 1.0;
        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1.0;


        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string technique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = technique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                ValidationFlourType(value);

                this.flourType = value;
            }
        }

        

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                ValidationBakingTechnique(value);
                this.bakingTechnique = value;
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
                if (1 > value || value > 200)
                {
                    throw new ArgumentException(INVALID_WEIGHT_ERROR_MESSAGE);
                }
                this.weight = value;

            }
        }

        private static void ValidationFlourType(string value)
        {
            if (value.ToLower()
                != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException(INVALID_TYPE_FLOUR_ERROR_MESSAGE);
            }
        }
        private static void ValidationBakingTechnique(string value)
        {
            if (value.ToLower()
                != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException(INVALID_TYPE_FLOUR_ERROR_MESSAGE);
            }
        }
        public double CalculateCalories()
        {
            double calories = 0.0;

            switch (this.FlourType.ToLower())
            {
                case "white":
                    switch (this.BakingTechnique.ToLower())
                    {
                        case "crispy": calories = 2 * this.Weight * white * crispy; break;
                        case "chewy": calories = 2 * this.Weight * white * chewy; break;
                        case "homemade": calories = 2 * this.Weight * white * homemade; break;
                    }; break;
                case "wholegrain":
                    switch (this.BakingTechnique.ToLower())
                    {
                        case "crispy": calories = 2 * this.Weight * wholegrain * crispy; break;
                        case "chewy": calories = 2 * this.Weight * wholegrain * chewy; break;
                        case "homemade": calories = 2 * this.Weight * wholegrain * homemade; break;
                        default:
                            break;
                    }; break;
                default:
                    break;
            }

            return calories;
        }

    }
}
