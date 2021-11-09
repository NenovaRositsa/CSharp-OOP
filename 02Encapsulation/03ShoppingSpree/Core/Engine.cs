using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        private List<Product> products;
        private List<Person> people;

        public Engine()
        {
            this.products = new List<Product>();
            this.people = new List<Person>();
        }

        public void Run()
        {
           
            try
            {
                string[] peopleInput = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
                string[] productsInput = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < peopleInput.Length; i += 2)
                {
                    string name = peopleInput[i];
                    decimal money = decimal.Parse(peopleInput[i + 1]);

                    Person person = new Person(name, money);

                    people.Add(person);
                }


                for (int i = 0; i < productsInput.Length; i += 2)
                {
                    string name = productsInput[i];
                    decimal cost = decimal.Parse(productsInput[i + 1]);

                    Product product = new Product(name, cost);

                    products.Add(product);
                }

                string purchase = Console.ReadLine();

                while (purchase != "END")
                {
                    string[] inputArguments = purchase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    Person buyer = people.FirstOrDefault(x => x.Name == inputArguments[0]);
                    Product product = products.FirstOrDefault(y => y.Name == inputArguments[1]);

                    if (buyer != null && product != null)
                    {
                        buyer.BuyProduct(product);

                        purchase = Console.ReadLine();
                    }

                   
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            foreach (var element in people)
            {
                Console.WriteLine(element);
            }
        }
    }
}

