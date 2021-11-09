using Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations.Models
{
    public class Robot : IId
    {
        private readonly string model;

        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;

        }
        public string Id { get; private set; }
    }
}
