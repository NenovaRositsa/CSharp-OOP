using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories.Models
{
   public class Pizza
    {
        private const int MaxLength = 15;
        private const int MaxToppingCount = 10;
        private const int MinToppingCount = 0;

        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;

            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length > MaxLength || string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough { get; set; }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count < MinToppingCount || this.toppings.Count > MaxToppingCount)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            double calories = this.Dough.CalculateCalories() + this.toppings.Sum(t => t.CalculateCalories());
            return $"{this.Name} - {calories:F2} Calories.";
        }

    }
}
