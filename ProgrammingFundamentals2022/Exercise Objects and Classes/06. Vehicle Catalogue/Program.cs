using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> listOfVehicles = new List<Vehicle>();
            string[] vehiclesInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (vehiclesInput[0] != "End")
            {
                string typeOfVehicle = vehiclesInput[0];
                if (typeOfVehicle == "car")
                {
                    typeOfVehicle = "Car";
                }
                else
                {
                    typeOfVehicle = "Truck";
                }
                string model = vehiclesInput[1];
                string color = vehiclesInput[2];
                int horsePower = int.Parse(vehiclesInput[3]);
                
                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                listOfVehicles.Add(vehicle);

                vehiclesInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            
            string vehicleNeeded = Console.ReadLine();
            
            while (vehicleNeeded != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in listOfVehicles)
                {                    
                    if (vehicle.Model==vehicleNeeded)
                    {                        
                        Console.Write("Type: ");
                        Console.Write(vehicle.Type);
                        Console.WriteLine();
                        Console.Write("Model: ");
                        Console.Write(vehicle.Model);
                        Console.WriteLine();
                        Console.Write("Color: ");
                        Console.Write(vehicle.Color);
                        Console.WriteLine();
                        Console.Write("Horsepower: ");
                        Console.Write(vehicle.HorsePower);
                        Console.WriteLine();
                    }
                }
                vehicleNeeded = Console.ReadLine();
            }
            List<Vehicle> cars = listOfVehicles.Where(x => x.Type == "Car").ToList();
            List<Vehicle> trucks = listOfVehicles.Where(x => x.Type == "Truck").ToList();
            
            AverageHorsePowerCalculator(cars, trucks);
  
        }

        static void AverageHorsePowerCalculator(List<Vehicle> cars, List<Vehicle> trucks)
        {          
            int horsePowerSumCar = 0;
            int horsePowerSumTruck = 0;
            
            foreach (var car in cars)
            {
                horsePowerSumCar += car.HorsePower;
            }
            foreach (var truck in trucks)
            {
                horsePowerSumTruck += truck.HorsePower;
            }
            double averageCars = 0;
            if (cars.Count>0)
            {
                averageCars = 1.0*horsePowerSumCar / cars.Count;
            }

            double averageTrucks = 0;
            if (trucks.Count>0)
            {
                averageTrucks = 1.0 * horsePowerSumTruck / trucks.Count;
            }
           

            Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");
        }
    }
    class Vehicle
    {
        public Vehicle(string typeOfVehicle, string model, string color, int horsePower)
        {
            Type = typeOfVehicle;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; } 
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
