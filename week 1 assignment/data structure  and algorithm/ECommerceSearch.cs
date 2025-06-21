using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id;
    public string Name;
    public double Price;

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"{Id}. {Name} - ₹{Price}");
    }
}

class Program
{
    static List<Product> products = new List<Product>();

    static void SeedProducts()
    {
        products.Add(new Product(1, "Laptop", 50000));
        products.Add(new Product(2, "Smartphone", 25000));
        products.Add(new Product(3, "Bluetooth Headphones", 2000));
        products.Add(new Product(4, "Wireless Mouse", 700));
        products.Add(new Product(5, "Smartwatch", 5000));
    }

    static void SearchProduct()
    {
        Console.Write("\n🔍 Enter a product name or keyword to search: ");
        string keyword = Console.ReadLine().ToLower();

        var results = products.Where(p => p.Name.ToLower().Contains(keyword)).ToList();

        if (results.Count == 0)
        {
            Console.WriteLine("❌ No products found.");
        }
        else
        {
            Console.WriteLine("\n✅ Search Results:");
            foreach (var product in results)
            {
                product.Display();
            }
        }
    }

    static void Main(string[] args)
    {
        SeedProducts();
        int choice;

        do
        {
            Console.WriteLine("\n🛒 E-Commerce Search Menu");
            Console.WriteLine("1. View All Products");
            Console.WriteLine("2. Search Product");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n📦 All Products:");
                    foreach (var product in products)
                        product.Display();
                    break;

                case 2:
                    SearchProduct();
                    break;

                case 0:
                    Console.WriteLine("👋 Exiting...");
                    break;

                default:
                    Console.WriteLine("❌ Invalid choice.");
                    break;
            }
        } while (choice != 0);
    }
}
