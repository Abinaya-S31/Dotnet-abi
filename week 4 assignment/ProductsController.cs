using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> _products = new();

    [HttpGet]
    public IEnumerable<Product> Get() => _products;

    [HttpPost]
    public IActionResult Post(Product p) { _products.Add(p); return CreatedAtAction("Get", new { id = p.Id }, p); }
    // Add PUT & DELETE similarly
}
