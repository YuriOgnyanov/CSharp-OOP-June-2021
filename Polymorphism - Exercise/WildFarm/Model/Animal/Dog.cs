using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food.Food food)
        {
            if (food.GetType().Name is "Meat")
            {
                this.Weight += food.Quantity * 0.40;
                this.FoodEaten = food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Sound()
        {
            return "Woof!";
        }
    }
}
