using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Model
{
    public abstract class BaseHero
    {
        public string Name { get; }
        public int Power { get; }

        public BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }
        public abstract string CastAbility();
        

    }
}
