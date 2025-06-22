public class SmartphoneFactory : ProductFactory
{
    public override Product CreateProduct() => new Smartphone();
}
