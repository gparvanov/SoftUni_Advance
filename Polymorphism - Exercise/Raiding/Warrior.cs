using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int WarriorBasePower = 100;
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

        public Warrior(string name)
        {
            this.Name = name;
            this.Power = WarriorBasePower;
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
