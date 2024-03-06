using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Type { get; set; }

    public override string ToString()
    {
        return $"{Name}, {Price} RS, {Quantity}, {Type}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> inventory = new List<Product>
        {
            new Product { Name = "lettuce", Price = 10.5m, Quantity = 50, Type = "Leafy green" },
            new Product { Name = "cabbage", Price = 20m, Quantity = 100, Type = "Cruciferous" },
            new Product { Name = "pumpkin", Price = 30m, Quantity = 30, Type = "Marrow" },
            new Product { Name = "cauliflower", Price = 10m, Quantity = 25, Type = "Cruciferous" },
            new Product { Name = "zucchini", Price = 20.5m, Quantity = 50, Type = "Marrow" },
            new Product { Name = "yam", Price = 30m, Quantity = 50, Type = "Root" },
            new Product { Name = "spinach", Price = 10m, Quantity = 100, Type = "Leafy green" },
            new Product { Name = "broccoli", Price = 20.2m, Quantity = 75, Type = "Cruciferous" },
            new Product { Name = "garlic", Price = 30m, Quantity = 20, Type = "Leafy green" },
            new Product { Name = "silverbeet", Price = 10m, Quantity = 50, Type = "Marrow" }
        };

        Console.WriteLine($"Total number of products: {inventory.Count}");

        inventory.Add(new Product { Name = "Potato", Price = 10m, Quantity = 50, Type = "Root" });

        Console.WriteLine("\nList of all products:");
        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine($"Total number of products: {inventory.Count}");

        Console.WriteLine("\nProducts of type Leafy green:");
        foreach (var product in inventory.Where(p => p.Type == "Leafy green"))
        {
            Console.WriteLine(product);
        }

        inventory.RemoveAll(p => p.Name == "garlic");

        Console.WriteLine($"\nTotal number of products left: {inventory.Count}");

        var cabbageQuantity = inventory.First(p => p.Name == "cabbage").Quantity;
        Console.WriteLine($"\nFinal quantity of cabbage in the inventory: {cabbageQuantity}");

        var lettucePrice = inventory.First(p => p.Name == "lettuce").Price;
        var zucchiniPrice = inventory.First(p => p.Name == "zucchini").Price;
        var broccoliPrice = inventory.First(p => p.Name == "broccoli").Price;

        decimal totalPrice = (lettucePrice * 1) + (zucchiniPrice * 2) + (broccoliPrice * 1);
        Console.WriteLine($"\nTotal price for purchasing 1 kg lettuce, 2 kg zucchini, 1 kg broccoli: {totalPrice} RS");
    }
}
