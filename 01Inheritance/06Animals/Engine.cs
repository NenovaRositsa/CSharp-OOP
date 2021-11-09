using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Animals
{
    public class Engine
    {
        private List<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
        }
        public void Run()
        {
            string animaltype;

            while ((animaltype = Console.ReadLine()) != "Beast!")
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                string gender = input[2];




            }
        }
    }
}
