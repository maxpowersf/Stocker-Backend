using AutoMapper;
using Stocker.API.DTO;
using Stocker.Data.Entities;
using Stocker.Domain;
using Stocker.Domain.Enums;

namespace Stocker.API.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CategoryDTO, Category>()
                .ForMember(e => e.Type, opt => opt.MapFrom(e => (EnumCategoryType)e.Type));
            CreateMap<Category, Categories>()
                .ForMember(e => e.CategoryId, opt => opt.MapFrom(e => e.Id))
                .ForMember(e => e.TypeId, opt => opt.MapFrom(e => (int)e.Type))
                    .ReverseMap().ForMember(e => e.Type, opt => opt.MapFrom(e => (EnumCategoryType)e.TypeId));

            CreateMap<ProductDTO, Product>()
                .ForMember(e => e.Type, opt => opt.MapFrom(e => (EnumProductType)e.Type));
            CreateMap<Product, Products>()
                .ForMember(e => e.ProductId, opt => opt.MapFrom(e => e.Id))
                .ForMember(e => e.TypeID, opt => opt.MapFrom(e => (int)e.Type))
                    .ReverseMap().ForMember(e => e.Type, opt => opt.MapFrom(e => (EnumProductType)e.TypeID));
        }
    }
}
