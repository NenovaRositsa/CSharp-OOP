using Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations.Models
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", null);
        }
        public string Name { get; private set; }

        public DateTime BirthDate { get; private set; }
    }
}
