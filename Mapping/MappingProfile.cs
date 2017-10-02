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
                .ForMember(p => p.PropertyId, opt => opt.Ignore())
                .ForMember(p => p.AddressName, opt => opt.MapFrom(pr => pr.AddressName))
                .ForMember(p => p.WholesalerId, opt => opt.MapFrom(pr => pr.WholesalerId))
                .ForMember(p => p.City, opt => opt.MapFrom(pr => pr.City))
                .ForMember(p => p.State, opt => opt.MapFrom(pr => pr.State))
                .ForMember(p => p.ZipCode, opt => opt.MapFrom(pr => pr.ZipCode))
                .ForMember(p => p.PurchasePrice, opt => opt.MapFrom(pr => pr.PurchasePrice))
                .ForMember(p => p.Bedrooms, opt => opt.MapFrom(pr => pr.Bedrooms))
                .ForMember(p => p.Bathrooms, opt => opt.MapFrom(pr => pr.Bathrooms))
                .ForMember(p => p.RehabCostMin, opt => opt.MapFrom(pr => pr.RehabCostMin))
                .ForMember(p => p.RehabCostMax, opt => opt.MapFrom(pr => pr.RehabCostMax))
                .ForMember(p => p.AfterRepairValue, opt => opt.MapFrom(pr => pr.AfterRepairValue))
                .ForMember(p => p.AverageRent, opt => opt.MapFrom(pr => pr.AverageRent))
                .ForMember(p => p.SquareFootage, opt => opt.MapFrom(pr => pr.SquareFootage))
                .ForMember(p => p.PropertyType, opt => opt.MapFrom(pr => pr.PropertyType))
                .ForMember(p => p.YearBuilt, opt => opt.MapFrom(pr => pr.YearBuilt));
        }
    }
}