using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veeya.Controllers.Resources;
using Veeya.Models;
using Veeya.Persistence;

namespace Veeya.Controllers
{
    public class WholesalersController : Controller
    {
        private readonly VeeyaDbContext context;
        private readonly IMapper mapper;
        public WholesalersController(VeeyaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/wholesalers")]
        public async Task<IEnumerable<WholesalerResource>> GetWholesalers()
        {
            var wholesalers = await context.Wholesalers.Include(m => m.Properties).ToListAsync();

            return Mapper.Map<List<Wholesaler>, List<WholesalerResource>>(wholesalers);
        }
    }
}