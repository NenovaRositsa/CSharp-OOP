using System;
using System.Collections.Generic;
using System.Text;


namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name)
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
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
