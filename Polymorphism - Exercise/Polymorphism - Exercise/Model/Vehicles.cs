using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicles
    {
        public  double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; protected set; }
        private double tankCapacity;
        public double TankCapacity 
        {
            get { return this.tankCapacity; }
            protected set 
            {
                if (this.FuelQuantity > value)
                {
                    this.tankCapacity = 0;
                }
                else
                {
                    this.tankCapacity = value;
                }
            }
        }

        public Vehicles(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public abstract void Drive(double distance);
        public virtual void Refuel(double liters) 
        {
            if (liters > 0)
            {
                if (this.FuelQuantity + liters <= this.TankCapacity)
                {
                    this.FuelQuantity += liters;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }
    }
}
