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
        [HttpPost]
        public IActionResult CreateProperty([FromBody] Property property)
        {
            return Ok(property);
        }

        private readonly VeeyaDbContext context;
        public PropertiesController(VeeyaDbContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<PropertyResource>> GetProperties()
        {
            var listOfProperties = await context.Properties.Include(m => m.Wholesaler).ToListAsync();

            return Mapper.Map<List<Property>, List<PropertyResource>>(listOfProperties);
        }          

    }
}