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

            // used for posting to /api/properties. need to convert propertyResource
            // back to Property. add additional Property properties here when the time
            // comes (city, state, zip, etc.)
            CreateMap<PropertyResource, Property>()
                .ForMember(p => p.PropertyId, opt => opt.MapFrom(pr => pr.PropertyId))
                .ForMember(p => p.AddressName, opt => opt.MapFrom(pr => pr.AddressName))
                .ForMember(p => p.WholesalerId, opt => opt.MapFrom(pr => pr.WholesalerId));
        }
    }
}