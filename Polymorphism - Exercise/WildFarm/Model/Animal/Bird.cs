﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal
{
    public abstract class Bird : Animal
    {
        //double WingSize
        public double WingSize { get; }
        protected Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
