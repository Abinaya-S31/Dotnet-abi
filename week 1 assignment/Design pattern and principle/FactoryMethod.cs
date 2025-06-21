using System;

public abstract class Product
{
    public abstract void Display();
}

public class Laptop : Product
{
    public override void Display()
    {
        Console.WriteLine("🖥️ Laptop object created.");
    }
}

public class Smartphone : Product
{
    public override void Display()
    {
        Console.WriteLine("📱 Smartphone object created.");
    }
}

public abstract class ProductFactory
{
    public abstract Product CreateProduct();
}

public class LaptopFactory : ProductFactory
{
    public override Product CreateProduct()
    {
        return new Laptop();
    }
}

public class SmartphoneFactory : ProductFactory
{
    public override Product CreateProduct()
    {
        return new Smartphone();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose a product to create:");
        Console.WriteLine("1. Laptop");
        Console.WriteLine("2. Smartphone");

        Console.Write("Enter your choice (1 or 2): ");
        string input = Console.ReadLine();
        int choice;

        if (!int.TryParse(input, out choice))
        {
            Console.WriteLine("❌ Invalid input.");
            return;
        }

        ProductFactory factory;

        if (choice == 1)
            factory = new LaptopFactory();
        else if (choice == 2)
            factory = new SmartphoneFactory();
        else
        {
            Console.WriteLine("❌ Invalid choice.");
            return;
        }

        Product product = factory.CreateProduct();
        product.Display();
    }
}
