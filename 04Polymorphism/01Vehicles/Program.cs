using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carArgs = Console.ReadLine()
                .Split()
                .ToArray();

            Car car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), int.Parse(carArgs[3]));

            string[] truckArgs = Console.ReadLine()
               .Split()
               .ToArray();

            Truck truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), int.Parse(truckArgs[3]));

            string[] busArgs = Console.ReadLine()
               .Split()
               .ToArray();

            Bus bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), int.Parse(busArgs[3]));




            int countCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommand; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = input[0];
                string typeVehicle = input[1];
                double arg = double.Parse(input[2]);

                if (command == "Drive")
                {
                    if (typeVehicle == "Car")
                    {
                        Console.WriteLine(car.Drive(arg));
                    }
                    else if (typeVehicle == "Truck")
                    {
                        Console.WriteLine(truck.Drive(arg));
                    }
                    else if (typeVehicle == "Bus")
                    {
                        Console.WriteLine(bus.Drive(arg));
                    }
                }
                else if (command == "Refuel")
                {
                    if (typeVehicle == "Car")
                    {
                        car.Refuel(arg);
                    }
                    else if (typeVehicle == "Truck")
                    {
                        truck.Refuel(arg);
                    }
                    else if (typeVehicle == "Bus")
                    {
                        bus.Refuel(arg);
                    }
                }
                else if (command == "DriveEmpty")
                {
                    Console.WriteLine(bus.DriveEmpty(arg));
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}

//Car car = (Car)Factory();
//Truck truck = (Truck)Factory();

//private static Vehicle Factory()
//{
//    string[] part = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//    double fuelQty = double.Parse(part[1]);
//    double fuelConsumption = double.Parse(part[2]);
//    switch (part[0])
//    {
//        case "Car":
//            return new Car(fuelQty, fuelConsumption);
//        case "Truck":
//            return new Truck(fuelQty, fuelConsumption);
//        default:
//            return null;
//    }
//}