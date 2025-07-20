using JwtAuthWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<Product>
            {
                new Product{ Id = 1, Name = "Pen" },
                new Product{ Id = 2, Name = "Book" },
                new Product{ Id = 3, Name = "Bag" }
            };

            return Ok(products);
        }
    }
}
