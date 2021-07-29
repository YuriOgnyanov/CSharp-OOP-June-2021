using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food.Food food)
        {
            if (food.GetType().Name is "Vegetable")
            {
                this.Weight += food.Quantity * 0.35;
                this.FoodEaten = food.Quantity;
            }
            else if (food.GetType().Name is "Meat")
            {
                this.Weight += food.Quantity * 0.35;
                this.FoodEaten = food.Quantity;
            }
            else if (food.GetType().Name is "Fruit")
            {
                this.Weight += food.Quantity * 0.35;
                this.FoodEaten = food.Quantity;
            }
            else if (food.GetType().Name is "Seeds")
            {
                this.Weight += food.Quantity * 0.35;
                this.FoodEaten = food.Quantity;
            }
        }

        public override string Sound()
        {
            return $"Cluck";
        }
    }
}
