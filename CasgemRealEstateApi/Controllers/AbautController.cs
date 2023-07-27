using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemRealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] About about)
        {
            var insertAbout = _aboutService.Add(about);
            return CreatedAtAction(nameof(GetById), new { id = insertAbout.AboutId }, insertAbout);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var about = _aboutService.GetById(id);
            if (about == null)
            {
                return NotFound();
            }
            return Ok(about);
        }
    }
}
