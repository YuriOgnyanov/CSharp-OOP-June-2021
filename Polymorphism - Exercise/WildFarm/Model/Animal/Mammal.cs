using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal
{
    public abstract class Mammal : Animal
    {
        //string LivingRegion;
        public string LivingRegion { get; }
        protected Mammal(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

    }
}
