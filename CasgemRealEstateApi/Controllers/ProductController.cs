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
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var properties = _productService.GetList();
            return Ok(properties);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Product product)
        {
            _productService.Update(id, product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _productService.Delete(id);
            return NoContent();
        }

    }
}
