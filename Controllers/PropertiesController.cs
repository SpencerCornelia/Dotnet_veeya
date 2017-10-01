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
        public IActionResult CreateProperty([FromBody] PropertyResource propertyResource)
        {
            var property = Mapper.Map<PropertyResource, Property>(propertyResource);
            return Ok(property);
        }

        [HttpGet]
        public async Task<IEnumerable<PropertyResource>> GetProperties()
        {
            var listOfProperties = await context.Properties.Include(m => m.Wholesaler).ToListAsync();

            return Mapper.Map<List<Property>, List<PropertyResource>>(listOfProperties);
        }          

    }
}