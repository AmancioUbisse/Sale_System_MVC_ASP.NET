using Microsoft.AspNetCore.Mvc;
using Sale_System.Models;
using System.Threading.Tasks;

namespace Sale_System.Controllers
{
    [ApiController]
    [Route("api/sales")]
    public class SaleAPIController : Controller
    {
        private readonly List<Product> _product = new List<Product>();
        private int _nextProduct = 1;

        [HttpGet]
       public IActionResult Get()
        {
            return Ok(_product);
        }

        

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if (product == null)
                return BadRequest();

            product._code = _nextProduct++;
            _product.Add(product);

            return CreatedAtRoute("GetProducts", new { code = product._code }, product);
        }
    }
}
