using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food.Food food)
        {
            if (food.GetType().Name is "Meat")
            {
                this.Weight += food.Quantity * 0.25;
                this.FoodEaten = food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Sound()
        {
            return $"Hoot Hoot";
        }
    }
}
