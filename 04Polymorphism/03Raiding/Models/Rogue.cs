using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) 
            : base(name)
        {
        }

        public override int Power
        {
            get
            {
                return 80;
            }
            set { }
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
