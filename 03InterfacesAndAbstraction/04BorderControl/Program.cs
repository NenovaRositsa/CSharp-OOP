using System;
using System.Collections.Generic;
using System.Linq;

namespace Border_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEntrant> entrants = new List<IEntrant>();



            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (input[0] == "End")
                {
                    break;
                }

                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];

                    IEntrant currentCitizen = new Citizen(name, age, id);
                    entrants.Add(currentCitizen);
                }
                else if (input.Length == 2)
                {
                    string model = input[0];
                    string id = input[1];

                    IEntrant currentRobot = new Robot(model, id);
                    entrants.Add(currentRobot);
                }
            }

            string fakeDigits = Console.ReadLine();

            foreach (var entrant in entrants)
            {
                if (entrant.Id.EndsWith(fakeDigits))
                {
                    Console.WriteLine(entrant.Id);
                }
            }

        }
    }
}
