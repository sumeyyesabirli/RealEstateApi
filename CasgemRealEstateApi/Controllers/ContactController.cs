using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemRealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Contact contact)
        {
            var insertedProperty = _contactService.Add(contact);
            return CreatedAtAction(nameof(GetById), new { id = insertedProperty.ContactId }, insertedProperty);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var contact = _contactService.GetById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

    }
}
