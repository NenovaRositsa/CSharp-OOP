using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class Robot : IEntrant
    {
        public Robot(string model, string id)
        {
            this.Name = model;
            this.Id = id;
        }
        public string Name { get; private set; }

        public string Id { get; private set; }
    }
}
