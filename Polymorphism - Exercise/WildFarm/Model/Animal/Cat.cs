using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food.Food food)
        {
            double sumWeight = food.Quantity * 0.30;
            this.FoodEaten = food.Quantity;
            if (food.GetType().Name is "Vegetable")
            {
                this.Weight += sumWeight;
            }
            else if (food.GetType().Name is "Meat")
            {
                this.Weight += sumWeight;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Sound()
        {
            return $"Meow";
        }

    }
}
