using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Box> boxes = new List<Box>();
          
            while (command[0]!= "end")
            {
                int serialNumber = int.Parse(command[0]);
                string itemName = command[1];
                int itemQuantity = int.Parse(command[2]);
                decimal itemPrice = decimal.Parse(command[3]);

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = new Item(itemName,itemPrice),
                    ItemQuantity = itemQuantity
                };
                boxes.Add(box);
                
                command = Console.ReadLine().Split();
            }
            
            List<Box> order = boxes.OrderByDescending(box => box.PriceForABox).ToList();

            foreach (Box box in order)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
            
        }
    }
    class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            Name = itemName;
            Price = itemPrice;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {       
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }   
        public decimal PriceForABox 
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }                
        }
    }
}
            