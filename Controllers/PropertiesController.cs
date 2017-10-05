using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veeya.Controllers.Resources;
using Veeya.Models;
using Veeya.Persistence;

namespace Veeya.Controllers
{
    [Route("/api/properties")]
    public class PropertiesController : Controller
    {
        // delete context when listOfProperties is sent to PropertyRepository.cs
        // and remove from constructor too
        private readonly VeeyaDbContext context;
        private readonly IMapper mapper;
        private readonly IPropertyRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public PropertiesController(VeeyaDbContext context, IMapper mapper, IPropertyRepository repository, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.repository = repository;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProperty([FromBody] SavePropertyResource propertyResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var property = Mapper.Map<SavePropertyResource, Property>(propertyResource);
            repository.Add(property);
            await unitOfWork.CompleteAsync();
            return Ok(property);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProperty(int id)
        {
            var property = await repository.GetProperty(id);

            if (property == null)
            {
                return NotFound();
            }

            var propertyResource = Mapper.Map<Property, PropertyResource>(property);
            return Ok(propertyResource);
        }

        [HttpGet("list")]
        public async Task<IEnumerable<SavePropertyResource>> GetListOfProperties(int id)
        {
            // add this to PropertyRepository.cs at later time. This isn't part of Mosh's tutorial
            var listOfProperties = await context.Properties.Include(m => m.Wholesaler).ToListAsync();

            return Mapper.Map<List<Property>, List<SavePropertyResource>>(listOfProperties);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProperty(int id, [FromBody] SavePropertyResource propertyResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var property = await repository.GetProperty(id);
            
            if (property == null)
            {
                return NotFound();
            }
            Mapper.Map<SavePropertyResource, Property>(propertyResource, property);
            await unitOfWork.CompleteAsync();

            property = await repository.GetProperty(property.PropertyId);
            var result = Mapper.Map<Property, PropertyResource>(property);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            var property = await repository.GetProperty(id, includeRelated: false);

            if (property == null)
            {
                return NotFound();
            }
            repository.Remove(property);
            await unitOfWork.CompleteAsync();

            return Ok(id);
        }

    }
}