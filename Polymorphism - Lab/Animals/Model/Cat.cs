using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Model
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
        }

        public sealed override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}{Environment.NewLine}MEEOW";
        }
    }
}
