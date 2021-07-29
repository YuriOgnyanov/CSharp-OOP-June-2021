using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Model.Food;


namespace WildFarm.Model.Animal
{
    public abstract class Animal
    {
        //string Name, double Weight, int FoodEaten;
        public string Name { get; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; } 

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public abstract string Sound();

        public abstract void Eat(Food.Food food);

    }
}
