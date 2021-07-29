using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; }
        public double TankCapacity { get; }
        public bool IEmpty { get; set; }

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = 0;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;
            }
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        //driven a given distance 
        public abstract string Drive(double distance);

        //refueled with a given amount of fuel
        public abstract void Refuel(double fuelAmount);
    }
}
