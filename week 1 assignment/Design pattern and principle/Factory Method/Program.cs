using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<ProductFactory> factories = new List<ProductFactory>
        {
            new LaptopFactory(),
            new SmartphoneFactory(),
            new TabletFactory()
        };

        foreach (var factory in factories)
        {
            Product product = factory.CreateProduct();
            product.ShowDetails();
        }
    }
}
