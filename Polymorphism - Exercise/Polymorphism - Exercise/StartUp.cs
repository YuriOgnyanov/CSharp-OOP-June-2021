using System;
using System.Collections.Generic;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Vehicles> all = new List<Vehicles>();

            string[] carParts = Console.ReadLine()
                .Split();

            Vehicles car = new Car(double.Parse(carParts[1]), double.Parse(carParts[2]), double.Parse(carParts[3]));
            all.Add(car);

            string[] truckParts = Console.ReadLine()
                 .Split();

            Vehicles truck = new Truck(double.Parse(truckParts[1]), double.Parse(truckParts[2]), double.Parse(truckParts[3]));
            all.Add(truck);

            string[] busParts = Console.ReadLine()
                 .Split();

            Vehicles bus = new Bus(double.Parse(busParts[1]), double.Parse(busParts[2]), double.Parse(busParts[3]));
            all.Add(bus);

            int line = int.Parse(Console.ReadLine());

            for (int i = 0; i < line; i++)
            {
                string[] commands = Console.ReadLine()
                .Split();

                string command = commands[0];
                string type = commands[1];
                

                if (command is "Drive")
                {
                    double distance = double.Parse(commands[2]);
                    DrivePerCarAndTruck(car, truck, bus, type, distance);
                }
                else if (command is "Refuel")
                {
                    double liters = double.Parse(commands[2]);
                    RefuelPerCarAndTruck(car, truck, bus, type, liters);
                }
                else if (command is "DriveEmpty")
                {
                    double distance = double.Parse(commands[2]);
                    
                    DrivePerCarAndTruck(car, truck, bus, type, distance);
                }
            }

            foreach (var vehicle in all)
            {
                Console.WriteLine($"{vehicle.GetType().Name}: {vehicle.FuelQuantity:F2}");
            }
        }

        private static void RefuelPerCarAndTruck(Vehicles car, Vehicles truck, Vehicles bus, string type, double liters)
        {
            if (type is "Car")
            {
                car.Refuel(liters);
            }
            else if (type is "Truck")
            {
                truck.Refuel(liters);
            }
            else if (type is "Bus")
            {
                bus.Refuel(liters);
            }
        }

        private static void DrivePerCarAndTruck(Vehicles car, Vehicles truck, Vehicles bus, string type, double distance)
        {
            if (type is "Car")
            {
                car.Drive(distance);
            }
            else if (type is "Truck")
            {
                truck.Drive(distance);
            }
            else if (type is "Bus")
            {
                bus.Drive(distance);
            }
        }
    }
}
