using Birthday_Celebrations.Interfaces;
using Birthday_Celebrations.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Birthday_Celebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 5
            //List<IBirthable> all = new List<IBirthable>();

            //string input;

            //while ((input = Console.ReadLine()) != "End")
            //{
            //    string[] tokens = input.Split();

            //    string kindModel = tokens[0];

            //    switch (kindModel)
            //    {
            //        case "Citizen":
            //            IBirthable citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
            //            all.Add(citizen); break;
            //        case "Pet":
            //            all.Add(new Pet(tokens[1], tokens[2])); break;


            //    }
            //}

            //int year = int.Parse(Console.ReadLine());

            //foreach (var birthDate in all)
            //{
            //    if (birthDate.BirthDate.Year == year)
            //    {

            //        Console.WriteLine(birthDate.BirthDate.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            //    }

            //}

            List<IBuyer> all = new List<IBuyer>();

            int countPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPeople; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (input.Length == 4)
                {
                    all.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                }
                else if (input.Length == 3)
                {
                    all.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End") 
            {
                var buyer = all.SingleOrDefault(x => x.Name == command);

                if (buyer != null)
                {
                    buyer.Buyfood();
                }
            }

            Console.WriteLine(all.Sum(b => b.Food));
        }
    }
}
