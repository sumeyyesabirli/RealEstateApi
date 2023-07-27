using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CasgemRealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            var insertedProperty = _productService.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = insertedProperty.ProductId }, insertedProperty);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var property = _productService.GetById(id);
            if (property == null)
            {
                return NotFound();
            }
            return Ok(property);
        }

    }
}
