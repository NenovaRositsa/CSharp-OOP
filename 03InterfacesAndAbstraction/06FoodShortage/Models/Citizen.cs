using Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations.Models
{
    public class Citizen : IId, IBirthable, IBuyer, IAge
    {
      
        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            BirthDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", null);
            this.Food = 0;

        }
        public string Name { get; private set; }

        public string Id { get; private set; }

        public DateTime BirthDate { get; private set; }

        public int Food { get; private set; }

        public int Age { get; private set; }

        public void Buyfood()
        {
            this.Food += 10;
        }
    }
}
