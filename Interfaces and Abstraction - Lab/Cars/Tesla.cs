using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : Car , IElectricCar
    {
        public int Battery { get; set; }
        public Tesla(string model, string color, int battery) 
            : base(model, color)
        {
            this.Battery = battery;
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries";
        }
    }
}
