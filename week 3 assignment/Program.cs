using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            // Clear all existing data
            context.Products.RemoveRange(context.Products);
            context.SaveChanges();
            Console.WriteLine("Old data cleared.");

            // -------- Insert --------
            var product = new Product { Name = "Notebook", Quantity = 40, Price = 25 };
            context.Products.Add(product);
            context.SaveChanges();
            Console.WriteLine("Product inserted.");

            // -------- Update --------
            var existingProduct = context.Products.FirstOrDefault(p => p.Name == "Notebook");
            if (existingProduct != null)
            {
                existingProduct.Quantity = 60;
                existingProduct.Price = 30;
                context.SaveChanges();
                Console.WriteLine("Product updated.");
            }

            // -------- Delete --------
            var toDelete = context.Products.FirstOrDefault(p => p.Name == "Notebook");
            if (toDelete != null)
            {
                context.Products.Remove(toDelete);
                context.SaveChanges();
                Console.WriteLine("Product deleted.");
            }

            // -------- LINQ Queries --------
            var expensive = context.Products.Where(p => p.Price > 20).ToList();
            Console.WriteLine("\nProducts > ₹20:");
            foreach (var p in expensive)
                Console.WriteLine($"{p.Name} - ₹{p.Price}");

            var sorted = context.Products.OrderBy(p => p.Name).ToList();
            Console.WriteLine("\nSorted by Name:");
            foreach (var p in sorted)
                Console.WriteLine($"{p.Name} - ₹{p.Price}");

            var projected = context.Products.Select(p => new { p.Name, p.Price }).ToList();
            Console.WriteLine("\nOnly Name & Price:");
            foreach (var p in projected)
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }
    }
}
