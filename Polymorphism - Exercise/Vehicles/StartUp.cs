using System;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //•	On the first line – information about the car in the format: "Car {fuel quantity} {liters per km} {tank capacity}"
            string[] carInformation = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(carInformation[1]), double.Parse(carInformation[2]), double.Parse(carInformation[3]));

            //•	On the second line – info about the truck in the format: "Truck {fuel quantity} {liters per km} {tank capacity}"
            string[] TruckInformation = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle truck = new Truck(double.Parse(TruckInformation[1]), double.Parse(TruckInformation[2]), double.Parse(TruckInformation[3]));

            //•	On the third line – info about the Bus in the format: "Bus {fuel quantity} {liters per km} {tank capacity}"
            string[] busInformation = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle bus = new Bus(double.Parse(busInformation[1]), double.Parse(busInformation[2]), double.Parse(busInformation[3]));

            
            //•	On the third line – the number of commands N that will be given on the next N lines
            int numberOfCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string method = cmdArgs[0];
                string type = cmdArgs[1];
                double distance, liters;

                switch (method)
                {
                    case "Drive":
                        distance = double.Parse(cmdArgs[2]);
                        if (type is "Car")
                        {
                            Console.WriteLine(car.Drive(distance));
                        }
                        else if (type is "Truck")
                        {
                            Console.WriteLine(truck.Drive(distance));
                        }
                        else if (type is "Bus")
                        {
                            bus.IEmpty = false;
                            Console.WriteLine(bus.Drive(distance));
                        }
                        break;

                    case "Refuel":
                        liters = double.Parse(cmdArgs[2]);
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
                            truck.Refuel(liters);
                        }
                        break;

                    case "DriveEmpty":
                        distance = double.Parse(cmdArgs[2]);
                        bus.IEmpty = true;
                        Console.WriteLine(bus.Drive(distance));
                        break;
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
