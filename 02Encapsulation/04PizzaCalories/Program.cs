using PizzaCalories.Models;
using System;


namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] pizzaTokens = Console.ReadLine().
                    Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string pizzaName = pizzaTokens[1];

                string[] doughTokens = Console.ReadLine().
                    Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string doughName = doughTokens[1];
                string bakeType = doughTokens[2];
                double doughWeight = double.Parse(doughTokens[3]);

                Dough dough = new Dough(doughName, bakeType, doughWeight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string command = Console.ReadLine();

                while (command.ToUpper() != "END")
                {
                    string[] toppingTokens = command.
                        Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string toppingName = toppingTokens[1];
                    double toppingWeight = double.Parse(toppingTokens[2]);

                    Topping topping = new Topping(toppingName, toppingWeight);

                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine(pizza);
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }
        }
    }
}
