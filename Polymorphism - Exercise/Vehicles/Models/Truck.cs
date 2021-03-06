using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        //Its summer, so both vehicles use air conditioners and their fuel consumption per km is increased by 1.6 liters for the Truck
        private const double AirConditioners = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override string Drive(double distance)
        {
            double fuelNeeded = (this.FuelConsumption + AirConditioners) * distance;

            if (this.FuelQuantity - fuelNeeded < 0)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQuantity -= fuelNeeded;

            return $"{this.GetType().Name} travelled {distance} km";
        }

        public override void Refuel(double fuelAmount)
        {
            if (fuelAmount < 1)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (this.FuelQuantity + fuelAmount > this.TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += fuelAmount * 0.95;
                }
            }

            
        }
    }
}
