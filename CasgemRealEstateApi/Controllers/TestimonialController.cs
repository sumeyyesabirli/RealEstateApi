using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemRealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Testimonial testimonial)
        {
            var insertedProperty = _testimonialService.Add(testimonial);
            return CreatedAtAction(nameof(GetById), new { id = insertedProperty.TestimonialId }, insertedProperty);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var testimonial = _testimonialService.GetById(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return Ok(testimonial);
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var properties = _testimonialService.GetList();
            return Ok(properties);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Testimonial testimonial)
        {
            _testimonialService.Update(id, testimonial);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _testimonialService.Delete(id);
            return NoContent();
        }

    }
}
