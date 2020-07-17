using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        private const int DruidBasePower = 80;
        private string name;
        public override string Name 
        {
            get => name;
            set
            {
                name = value;
            }
        }
        private int power;
        public override int Power
        {
            get => power;
            set
            {
                power = value;
            }
        }

        public Druid(string name)
        {
            this.Name = name;
            this.Power = DruidBasePower;
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
