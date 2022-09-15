using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("/");            

            Catalogue catalog = new Catalogue();


            while (input[0] != "end")
            {
                string type = input[0];
                if (type =="Car")
                {
                    string brand = input[1];
                    string model = input[2];
                    int horsePower = int.Parse(input[3]);
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,  
                        HP = horsePower
                    };
                    catalog.Cars.Add(car);
                }
                else
                {
                    string brand = input[1];
                    string model = input[2];
                    double weight = double.Parse(input[3]);
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    catalog.Trucks.Add(truck);
                }
                input = Console.ReadLine().Split("/");
            }
            
            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCars = catalog.Cars.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HP}hp");
                }
            }
            if (catalog.Trucks.Count>0)
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars{ get; set; }

        public List<Truck> Trucks { get; set; }

    }
}
