using Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations.Models
{
    public class Rebel : IAge, IBuyer
    {
        private readonly string group;
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.group = group;
            this.Food = 0;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; private set; }

        public void Buyfood()
        {
            this.Food += 5;
        }
    }
}
