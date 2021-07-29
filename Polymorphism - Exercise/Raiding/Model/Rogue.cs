﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Model
{
    public class Rogue : BaseHero
    {
        private const int power = 80;
        public Rogue(string name) 
            : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}