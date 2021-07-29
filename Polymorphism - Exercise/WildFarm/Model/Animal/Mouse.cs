using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food.Food food)
        {
            if (food.GetType().Name is "Vegetable")
            {
                this.Weight += food.Quantity * 0.10;
                this.FoodEaten = food.Quantity;
            }
            else if (food.GetType().Name is "Fruit")
            {
                this.Weight += food.Quantity * 0.10;
                this.FoodEaten = food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Sound()
        {
            return "Squeak";
        }
    }
}
