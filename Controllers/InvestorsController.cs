using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    }
}