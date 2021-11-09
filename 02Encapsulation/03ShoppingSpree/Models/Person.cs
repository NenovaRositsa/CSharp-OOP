using System;
using System.Collections.Generic;
using System.Text;


namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<string> bag;

       
        public Person(string name, decimal money)
           
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public IReadOnlyList<String> Bag
        {
            get
            {
                return this.bag.AsReadOnly();
            }
        }


        public void BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");
                this.Money -= product.Cost;
                this.bag.Add(product.Name);
            }

            
        }

        public override string ToString()
        {
            string person = $"{this.Name} - ";

            if (this.bag.Count == 0)
            {
                person += "Nothing bought";
            }
            else
            {
                person += string.Join(", ", this.bag);
            }

            return person;
        }
    }
}