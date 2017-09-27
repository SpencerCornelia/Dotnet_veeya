using AutoMapper;
using Veeya.Controllers.Resources;
using Veeya.Models;

namespace Veeya.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Wholesaler, WholesalerResource>();
            CreateMap<Property, PropertyResource>();
            CreateMap<Investor, InvestorResource>();
            CreateMap<InvestorToWholesaler, InvestorToWholesalerResource>();
        }
    }
}