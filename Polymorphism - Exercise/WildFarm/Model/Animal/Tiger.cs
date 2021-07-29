using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food.Food food)
        {
            if (food.GetType().Name is "Meat")
            {
                this.Weight += food.Quantity * 1.00;
                this.FoodEaten = food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
                
            }
        }

        public override string Sound()
        {
            return "ROAR!!!";
        }
    }
}
