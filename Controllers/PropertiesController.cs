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

        private readonly VeeyaDbContext context;
        private readonly IMapper mapper;

        public PropertiesController(VeeyaDbContext context, IMapper mapper)
        {
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
            context.Properties.Add(property);
            await context.SaveChangesAsync();
            return Ok(property);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProperty(int id)
        {
            var property = await context.Properties.FindAsync(id);

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
            var listOfProperties = await context.Properties.Include(m => m.Wholesaler).ToListAsync();

            return Mapper.Map<List<Property>, List<SavePropertyResource>>(listOfProperties);
        }        

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProperty(int id, [FromBody] SavePropertyResource propertyResource)
        {
            var property = await context.Properties.FindAsync(id);
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }
            if (property == null) 
            {
                return NotFound();
            }
            
            Mapper.Map<SavePropertyResource, Property>(propertyResource, property);
            
            await context.SaveChangesAsync();
            return Ok(property);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            var property = await context.Properties.FindAsync(id);
            
            if (property == null) 
            {
                return NotFound();
            }
            context.Remove(property);
            await context.SaveChangesAsync();

            return Ok(id);
        }

    }
}