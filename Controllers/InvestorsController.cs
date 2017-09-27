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
    [Route("/api/investors")]
    public class InvestorsController : Controller
    {
        private readonly VeeyaDbContext context;
        private readonly IMapper mapper;
        public InvestorsController(VeeyaDbContext context, IMapper mapper) 
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/investors")]
        public async Task<IEnumerable<InvestorResource>> GetInvestors()
        {
            var investors = await context.Investors.Include(i => i.WholesalersId).ToListAsync();
            return Mapper.Map<List<Investor>, List<InvestorResource>>(investors);
        }
    }
}