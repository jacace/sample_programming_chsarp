using System;
using System.Collections.Generic;

public class ProductTest
{

    public static void Run()
    {
        Product p1 = new Product { Name = "Bike", Quantity = 1, Country = "China" };
        Product p2 = new Product { Name = "Laptop", Quantity = 3, Country = "China" };
        Product p3 = new Product { Name = "Fridge", Quantity = 100, Country = "Germany" };
        List<Product> products = new List<Product>();
        products.Add(p1);
        products.Add(p2);
        products.Add(p3);

        ProductInventory inventory = new ProductInventory();
        inventory.Load(products);

        Console.WriteLine("Total by country: " + inventory.GetTotalByCountry("China"));
        Console.WriteLine("Total by country: " + inventory.GetTotalByCountry("Germany"));
        Console.WriteLine("Total by country: " + inventory.GetTotalByCountry("Ireland"));
        Console.WriteLine("Total by product: " + inventory.GetTotalByProduct("Bike"));
        Console.WriteLine("Total by product: " + inventory.GetTotalByProduct("Laptop"));
        Console.WriteLine("Total by product: " + inventory.GetTotalByProduct("Smartphone"));
    }

}