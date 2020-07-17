using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int PaladinBasePower = 100;
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

        public Paladin(string name)
        {
            this.Name = name;
            this.Power = PaladinBasePower;
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
