using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Food
{
    public abstract class Food
    {
        public int Quantity { get; }

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

    }
}
